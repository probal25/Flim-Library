using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flim_Library
{
    public partial class Registration : MetroFramework.Forms.MetroForm
    {
        DBConnect dbc = new DBConnect();

        public static int id;

        public Registration()
        {
            InitializeComponent();
           // public static int id;
            Registration.id += 1;
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin li = new FormLogin();
            li.Show();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textBoxName_r.Text != "" && this.textBoxU_Name_r.Text != "" && this.textBoxPass_r.Text != "" && this.textBoxPassR_r.Text != "" && this.textBoxEmail_r.Text != "")
                {
                    if (textBoxPass_r.Text == textBoxPassR_r.Text)
                    {
                        string query = "INSERT INTO user_info (ID,Name, User_name, Password, email) VALUES('" + Registration.id + "','"+ this.textBoxName_r.Text + "','" + this.textBoxU_Name_r.Text + "','" + this.textBoxPass_r.Text + "','" + this.textBoxEmail_r.Text + "')";
                        dbc.Insert(query);
                    }
                    else
                    {
                        labelAttn.Text = "Password Don't match";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        
    }
}
