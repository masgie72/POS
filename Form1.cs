using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POS
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SYAMSIATUN\OneDrive - Universitas Terbuka\Documents\wajik.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {         
            conn.Open();
            SqlCommand Login_UserName_Check = new SqlCommand("select UserName from UserDetails where UserName = '"+txUser.Text+"'", conn);
            SqlDataReader NameChecker = Login_UserName_Check.ExecuteReader();
            if (NameChecker.Read() == true) 
            { 
                NameChecker.Close();
                conn.Close();

                conn.Open ();
                SqlCommand Login_Password_Check = new SqlCommand("select Password from UserDetails where UserName = '"+txUser.Text+"' and Password = '"+txPassword.Text+"'", conn);
                SqlDataReader Password_Reader = Login_Password_Check.ExecuteReader();
                if (Password_Reader.Read() == true) 
                {
                    Password_Reader.Close();
                    conn.Close();
                    this.Hide();
                    Work_Station work_Station = new Work_Station();
                    work_Station.Show();
                }
                else
                {
                    Password_Reader.Close();
                    conn.Close();
                    txPassword.Text = "";
                    MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {              
                NameChecker.Close();
                conn.Close();
                txUser.Text = "";
                MessageBox.Show("Username not available","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
