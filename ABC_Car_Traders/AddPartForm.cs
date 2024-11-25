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
using System.Text.RegularExpressions;

namespace ABC_Car_Traders
{
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
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
            if (!IsValidInteger(txt_stock.Text))
            {
                MessageBox.Show("Stock must be integers!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                // Create new part object
                car_part newcar_part = new car_part
                {
                    part_name = txt_name.Text,
                    part_price = int.Parse(txt_price.Text),
                    part_stock = int.Parse(txt_stock.Text),
                    part_desc = txt_description.Text,
                    part_image = txt_image.Text
                };

                // Pass object to BLL
                BLL.CarPartBLL.AddPart(newcar_part);

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
            foreach (Control c in this.Controls)
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
            DialogResult dr = MessageBox.Show("Car part successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                foreach (Control c in this.Controls)
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

        private void btn_image_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image file|*jpg;*jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic_carpart.Image = Image.FromFile(ofd.FileName);
                    txt_image.Text = ofd.FileName;

                }
            }
        }
    }
}
