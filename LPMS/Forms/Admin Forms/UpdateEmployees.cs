using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPMS.Forms.Admin_Forms
{
    public partial class UpdateEmployees : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-PVPF344M\\SQLEXPRESS01;Initial Catalog=LPMS;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public UpdateEmployees()
        {
            InitializeComponent();
        }


        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text == "")
            {
                MessageBox.Show("Please Enter Emplyee ID");
            }
            else if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please Enter First Name");
            }
            else if (txtLastName.Text == "")
            {
                MessageBox.Show("Please Enter Last Name");
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Please Enter Address");
            }
            else if (txtPosition.Text == "")
            {
                MessageBox.Show("Please Enter Position");
            }
            else if (txtGender.Text == "")
            {
                MessageBox.Show("Please Enter Gender");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password");
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Please Enter Username");
            }
            else
            {
                //add refresh
                con.Open();
                cmd = new SqlCommand("UPDATE  tbl_addEmp SET Firstname = '" + txtFirstName.Text + "', Lastname = '" + txtLastName.Text + "', Address = '" + txtAddress.Text + "', Position = '" + txtPosition.Text + "', Gender = '" + txtGender.Text + "', Username = '" + txtUsername.Text + "', Password = '" + txtPassword.Text + "' WHERE ID = '" + txtEmployeeID.Text + "' ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved!");
                con.Close();
                this.Hide();
            }

        }

        private void UpdateEmployees_Load(object sender, EventArgs e)
        {

        }

        private void cbShowpwEmp_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowpwEmp.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
