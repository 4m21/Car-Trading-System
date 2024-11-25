using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using DAL.DAO;
using System.Text.RegularExpressions;

namespace ABC_Car_Traders
{
    public partial class CarUpdateForm : Form
    {
        public CarUpdateForm()
        {
            InitializeComponent();
        }

        List<car> list = new List<car>();
        List<car> result = new List<car>();
        public car carDetail = new car();


        private void CustomerForm_Load(object sender, EventArgs e)
        {

            list = CarBLL.GetCars();
            datagridcars.DataSource = list;
            datagridcars.Columns[0].Visible = false;
            datagridcars.Columns[1].HeaderText = "Make";
            datagridcars.Columns[2].HeaderText = "Model";
            datagridcars.Columns[3].HeaderText = "Year";
            datagridcars.Columns[4].HeaderText = "Price (Rs.)";
            datagridcars.Columns[5].Visible = false;
            datagridcars.Columns[6].HeaderText = "Stock";
            datagridcars.Columns[7].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                carDetail.car_id = Convert.ToInt32(datagridcars.Rows[e.RowIndex].Cells[0].Value);
                txt_make.Text = datagridcars.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_model.Text = datagridcars.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_price.Text = datagridcars.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_desc.Text = datagridcars.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_stock.Text = datagridcars.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_year.Text = datagridcars.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            try
            {
                UpdateCarDetails();
                RefreshDataGrid();
                MessageBox.Show("Car details successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred. Please try again!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            foreach (Control c in panel2.Controls)
            {
                if (c is TextBox && string.IsNullOrWhiteSpace(c.Text))
                {
                    MessageBox.Show("All fields are required!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            if (!Regex.IsMatch(txt_stock.Text, @"^\d+$"))
            {
                MessageBox.Show("Stock can only contain numbers!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (!Regex.IsMatch(txt_year.Text, @"^\d{4}$"))
            {
                MessageBox.Show("Enter a valid year!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void UpdateCarDetails()
        {
            carDetail.car_make = txt_make.Text;
            carDetail.car_model = txt_model.Text;
            carDetail.car_price = txt_price.Text;
            carDetail.car_desc = txt_desc.Text;
            carDetail.car_year = int.Parse(txt_year.Text);
            carDetail.car_stock = int.Parse(txt_stock.Text);

            CarBLL.UpdateCar(carDetail);
        }

        private void RefreshDataGrid()
        {
            list = CarBLL.GetCars();
            datagridcars.DataSource = list;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dr == DialogResult.Yes)
            {
                CarBLL.DeleteCar(carDetail.car_id);

                MessageBox.Show("Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                list = CarBLL.GetCars();
                datagridcars.DataSource = list;
            }
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            if(txt_search.Text.Trim() == "")
            {
                list = CarBLL.GetCars();
                datagridcars.DataSource = list;
            }
            else
            {
                result = CarBLL.Search(txt_search.Text);
                datagridcars.DataSource = result;
            }

            
        }
    }
}
