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

namespace LPMS.Forms.Admin_Forms
{
    public partial class AddEmployees : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-PVPF344M\\SQLEXPRESS01;Initial Catalog=LPMS;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public AddEmployees()
        {
            InitializeComponent();
        }

        private void AddEmployees_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text == "" && txtFirstName.Text == "" && txtLastName.Text == "" && txtAddress.Text == "" && txtPosition.Text == ""  && txtGender.Text == "" && txtUsername.Text == "" && txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Please enter input");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO tbl_addEmp(ID, Firstname, Lastname, Address, Contact, Position, Gender, Username, Password) VALUES('" + txtEmployeeID.Text + "', '" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtAddress.Text + "', '" + txtContact.Text + "', '" + txtPosition.Text + "', '" + txtGender.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "'  )", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Added");
                con.Close();
            }    
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbShowpwEmp_CheckedChanged_1(object sender, EventArgs e)
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
        private void lblStatus_Click(object sender, EventArgs e)
        {
           
        }

        private void txtEmployeeID_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_addemp WHERE ID=@Name", con);
                cmd.Parameters.AddWithValue("@Name", txtEmployeeID.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    lblStatus.Visible = true;
                    lblStatus.Text = "ID is already taken.";
                    lblStatus.ForeColor = Color.Red;
                }
                else if (txtEmployeeID.Text == "")
                {
                    lblStatus.Visible = false;
                }
                else
                {
                    lblStatus.Visible = true;
                    lblStatus.Text = "This ID is Available.";
                    lblStatus.ForeColor = Color.Green;
                }
                con.Close();
            }
        }
    }
}

