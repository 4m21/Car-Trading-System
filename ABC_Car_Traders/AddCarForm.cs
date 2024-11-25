using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DAO;

namespace ABC_Car_Traders
{
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }


        private void btn_image_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image file|*jpg;*jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic_car.Image = Image.FromFile(ofd.FileName);
                    txt_image.Text = ofd.FileName;

                }
            }
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            // Check if any fields are empty
            if (AreFieldsEmpty())
            {
                MessageBox.Show("All fields are required!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Check if stock and year are integers
            if (!IsValidInteger(txt_stock.Text) || !IsValidInteger(txt_year.Text))
            {
                MessageBox.Show("Stock and year must be integers!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                // Create new car object
                car newcar = new car
                {
                    car_make = txt_make.Text,
                    car_model = txt_model.Text,
                    car_price = txt_price.Text,
                    car_stock = int.Parse(txt_stock.Text),
                    car_year = int.Parse(txt_year.Text),
                    car_desc = txt_desc.Text,
                    car_image = txt_image.Text
                };

                // Pass object to BLL
                BLL.CarBLL.AddCar(newcar);

                // Show success message and clear fields
                ShowSuccessMessageAndClearFields();
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured. Please try again!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool AreFieldsEmpty()
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is TextBox && string.IsNullOrWhiteSpace(c.Text)) return true;
            }
            return false;
        }

        private bool IsValidInteger(string value)
        {
            return Regex.IsMatch(value, @"^\d+$");
        }

        private void ShowSuccessMessageAndClearFields()
        {
            DialogResult dr = MessageBox.Show("Car successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                foreach (Control c in panel1.Controls)
                {
                    if (c is TextBox tb)
                    {
                        tb.Clear();
                    }
                    else if (c is PictureBox pb)
                    {
                        pb.Image = null;
                    }
                }
            }
        }

    }
}
