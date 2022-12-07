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

    public partial class ManageEmployees : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-PVPF344M\\SQLEXPRESS01;Initial Catalog=LPMS;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public ManageEmployees()
        {
            InitializeComponent();
        }

        private void ManageEmployees_Load(object sender, EventArgs e)
        {
           refreshData();
        }

        public void refreshData()
        {
            dataGridView1.Rows.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbl_addemp", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["ID"].ToString(), dr["Firstname"].ToString(), dr["Lastname"].ToString(), dr["Address"].ToString(), dr["Contact"].ToString(), dr["Position"].ToString(), dr["Gender"].ToString(), dr["Username"].ToString(), dr["Password"].ToString());
            }
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        public void btnEdit_Click(object sender, EventArgs e)
        {
           

        }

        private void cbxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string cname = dataGridView1.Columns[e.ColumnIndex].Name;

            if(cname == "Edit")
            {
                UpdateEmployees updateEmp = new UpdateEmployees();
                updateEmp.txtEmployeeID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                updateEmp.txtFirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                updateEmp.txtLastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                updateEmp.txtAddress.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                updateEmp.txtContact.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                updateEmp.txtPosition.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                updateEmp.txtGender.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                updateEmp.txtUsername.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                updateEmp.txtPassword.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
               
                updateEmp.ShowDialog();
                refreshData();
            }
            if(cname == "Delete")
            {
                try
                {
                    if (dataGridView1.Rows.Count > 1)
                    {
                        if (dataGridView1.CurrentRow.Index == dataGridView1.Rows.Count - 1)
                        {
                            MessageBox.Show("Please Select Data!");
                        }
                        else
                        {
                            if (MessageBox.Show("Do you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                string del = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                                con.Open();
                                cmd = new SqlCommand("DELETE FROM tbl_addemp WHERE ID = '" + del + "'", con);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Data Deleted");

                                con.Close();
                                refreshData();  
                            }
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
}
