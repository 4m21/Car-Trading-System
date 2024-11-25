using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class CustomerDashForm : Form
    {
        public CustomerDashForm()
        {
            InitializeComponent();

            loadform(new CustomerCarForm());

        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new CustomerCarForm());
            
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnparts_Click(object sender, EventArgs e)
        {
            loadform(new CustomerPartForm());
        }


        private void btn_orders_Click(object sender, EventArgs e)
        {
            loadform(new CustomerOrderForm());
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to sign out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == dr)
            {
                UserStatic.UserId = "";
                UserStatic.Username = "";
                UserStatic.IsAdmin = false;

                var login = new Login();
                login.Show();
                this.Hide();

            }
        }

        private void NavBtnCLick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            foreach (Control c in panel2.Controls)
            {
                if (c != button)
                {
                    c.BackColor = Color.FromArgb(75, 101, 132);
                }
            }
            button.BackColor = Color.FromArgb(150, 180, 205);
            
        }
    }
}
