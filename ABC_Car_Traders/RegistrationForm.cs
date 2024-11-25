using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DAO;

namespace ABC_Car_Traders
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        //validate email address
        public bool EmailIsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            if (AllFieldsFilled())
            {
                if (EmailIsValid(txt_em.Text))
                {
                    if (txt_pw.Text == txt_pwconfirm.Text)
                    {
                        try
                        {
                            RegisterUser();
                            RegisterCustomer();

                            ShowSuccessMessage();
                            OpenLoginForm();

                        }
                        catch
                        {
                            MessageBox.Show("Error! Please try again.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid E-mail Address.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Fields.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool AllFieldsFilled()
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is TextBox && string.IsNullOrWhiteSpace(c.Text))
                {
                    return false;
                }
            }
            return true;
        }

        private void RegisterUser()
        {
            user newUser = new user();
            newUser.uid = txt_nic.Text;
            newUser.password = txt_pw.Text;
            newUser.email = txt_em.Text;
            UserBLL.AddUser(newUser);
        }

        private void RegisterCustomer()
        {
            customer newCustomer = new customer();
            newCustomer.name = txt_name.Text;
            newCustomer.customer_id = txt_nic.Text;
            newCustomer.address = txt_add.Text;
            newCustomer.contact = txt_tp.Text;
            newCustomer.dob = date_dob.Value;
            CustomerBLL.AddCustomer(newCustomer);
        }

        private void ShowSuccessMessage()
        {
            DialogResult dr = MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenLoginForm()
        {
            var formLogin = new Login();
            formLogin.Show();
            this.Hide();
        }




        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void linklbl_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Hide();
        }

    }
}
