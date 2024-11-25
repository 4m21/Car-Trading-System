using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DAO;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace ABC_Car_Traders
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool IsValidEmailI(string emailaddress)
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


        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!(txt_email.Text.Trim() == "" || txt_pw.Text.Trim() == ""))
            {
                if (IsValidEmailI(txt_email.Text))
                {
                    List<user> userlist = UserBLL.GetUsers(txt_email.Text, txt_pw.Text);

                    if (userlist.Count == 0)
                        MessageBox.Show("Invalid Username or Password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {
                        //create a system user
                        user systemUser = new user();

                        //assign details to system user
                        systemUser = userlist.First();

                        //create a userstatic class
                        UserStatic.UserId = systemUser.uid;
                        UserStatic.IsAdmin = Convert.ToBoolean(systemUser.is_admin);

                        if (systemUser.is_admin)
                        {
                            var formAdmin = new AdminDashForm();
                            formAdmin.Show();
                            this.Hide();
                        }
                        else
                        {
                            List<customer> customerlist = CustomerBLL.GetCustomer(systemUser.uid);
                            customer customer1 = new customer();
                            customer1 = customerlist.First();
                            UserStatic.Username = customer1.name;
                            var formCustomer = new CustomerDashForm();
                            formCustomer.Show();
                            this.Hide();
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Invalid E-mail Address.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Both Username And Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void linklbl_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var fornRegistration = new RegistrationForm();
            fornRegistration.Show();
            this.Hide();
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
