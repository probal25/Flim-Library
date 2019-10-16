using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Flim_Library
{
    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {
        DBConnect dbCon = new DBConnect();

        public FormLogin()
        {
            InitializeComponent();
            textBoxPass.PasswordChar = '*';
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                //labelAttention.Text = "Caps lock is ON!!!!";
                MessageBox.Show("Caps lock is ON!!!!");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1100;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox4.Visible = true;
            }

            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox6.Visible = true;
            }
            else if (pictureBox6.Visible == true)
            {
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
            }
            else if (pictureBox7.Visible == true)
            {
                pictureBox7.Visible = false;
                pictureBox3.Visible = true;
            }
        }

        private void btn_singin_Click(object sender, EventArgs e)
        {
            try
            {
                int count;
                string query = "select * from flim_library_db.user_info where User_name='" + this.textBoxUser.Text + "' and password='" + this.textBoxPass.Text + "' ;";
                //dbCon.OpenConnection();
                
                count = dbCon.query_(query);
                
                if (count == 1)
                {
                    MessageBox.Show("Successfully Logged In.");
                    labelAttention.Text = "Way to go. . .";
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate User name and password");
                }
                else
                {
                    labelAttention.Text = "User name and password not correct";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbCon.CloseConnection();
            }
            
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration rg = new Registration();
            rg.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        

        

        
    }
}
