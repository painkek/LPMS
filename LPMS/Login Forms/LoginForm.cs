using LPMS.Forms.User_Forms;
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

namespace LPMS.Login_Forms
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-PVPF344M\\SQLEXPRESS01;Initial Catalog=LPMS;Integrated Security=True");
        public LoginForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
       
        }
        //temp login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "Select * From tbl_userLogin Where Username = '" + txtUsername.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if(dtbl.Rows.Count == 1)
            {
                MainForm mf = new MainForm();
                mf.Show();
                this.Hide(); 
            }
            else if(txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter input");
            }
            else
            {
                MessageBox.Show("Invalid Password or Username");
            }
            
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
