
namespace ABC_Car_Traders
{
    partial class CustomerDashForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cars = new System.Windows.Forms.Button();
            this.btn_orders = new System.Windows.Forms.Button();
            this.btnparts = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.btn_cars);
            this.panel2.Controls.Add(this.btn_orders);
            this.panel2.Controls.Add(this.btnparts);
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 58);
            this.panel2.TabIndex = 1;
            // 
            // btn_cars
            // 
            this.btn_cars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.btn_cars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cars.FlatAppearance.BorderSize = 0;
            this.btn_cars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cars.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cars.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cars.Image = global::ABC_Car_Traders.Properties.Resources.icons8_car_30;
            this.btn_cars.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cars.Location = new System.Drawing.Point(442, 6);
            this.btn_cars.Name = "btn_cars";
            this.btn_cars.Size = new System.Drawing.Size(170, 45);
            this.btn_cars.TabIndex = 0;
            this.btn_cars.Text = "Cars";
            this.btn_cars.UseVisualStyleBackColor = false;
            this.btn_cars.Click += new System.EventHandler(this.button1_Click);
            this.btn_cars.Click += new System.EventHandler(this.NavBtnCLick);
            // 
            // btn_orders
            // 
            this.btn_orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.btn_orders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_orders.FlatAppearance.BorderSize = 0;
            this.btn_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orders.ForeColor = System.Drawing.Color.Transparent;
            this.btn_orders.Image = global::ABC_Car_Traders.Properties.Resources.icons8_shopping_cart_24;
            this.btn_orders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_orders.Location = new System.Drawing.Point(38, 6);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(170, 45);
            this.btn_orders.TabIndex = 5;
            this.btn_orders.Text = "My Orders";
            this.btn_orders.UseVisualStyleBackColor = false;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            this.btn_orders.Click += new System.EventHandler(this.NavBtnCLick);
            // 
            // btnparts
            // 
            this.btnparts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.btnparts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnparts.FlatAppearance.BorderSize = 0;
            this.btnparts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnparts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnparts.ForeColor = System.Drawing.Color.Transparent;
            this.btnparts.Image = global::ABC_Car_Traders.Properties.Resources.icons8_gears_24;
            this.btnparts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnparts.Location = new System.Drawing.Point(240, 6);
            this.btnparts.Name = "btnparts";
            this.btnparts.Size = new System.Drawing.Size(170, 45);
            this.btnparts.TabIndex = 1;
            this.btnparts.Text = "Car Parts";
            this.btnparts.UseVisualStyleBackColor = false;
            this.btnparts.Click += new System.EventHandler(this.btnparts_Click);
            this.btnparts.Click += new System.EventHandler(this.NavBtnCLick);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(1078, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(30, 30);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::ABC_Car_Traders.Properties.Resources.icons8_sign_out_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(883, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sign Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(btnSignout_Click);
            this.button1.Click += new System.EventHandler(this.NavBtnCLick);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 58);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1120, 542);
            this.mainpanel.TabIndex = 3;
            // 
            // CustomerDashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 600);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerDashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashForm";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cars;
        private System.Windows.Forms.Button btnparts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_orders;
        private System.Windows.Forms.Panel mainpanel;
    }
}