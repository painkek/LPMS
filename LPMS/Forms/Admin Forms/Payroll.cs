using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPMS.Forms.Admin_Forms
{
    public partial class Payroll : Form
    {
        public Payroll()
        {
            InitializeComponent();
        }

        private void Payroll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lPMSDataSet.tbl_addEmp' table. You can move, or remove it, as needed.
            this.tbl_addEmpTableAdapter.Fill(this.lPMSDataSet.tbl_addEmp);

        }

        private void panelPayroll_Paint(object sender, PaintEventArgs e)
        {

        }

        public void payrollComputation()
        {
            //number of work days
            string a = txtNoOfWork.Text;
            int noworkday = int.Parse(a);

            string b = txtSalaryPerDay.Text;
            int salaryperday = int.Parse(b);

            int totalSalaryPerDay = noworkday * salaryperday;
            txttotalSalaryPerDay.Text = totalSalaryPerDay.ToString();

            //overtime
            string c = txtRegularOT.Text;
            int regularOT = int.Parse(c);
            int totalOT = regularOT * 50;
            txtTotalAmountOT.Text = totalOT.ToString();

            //deduction
            string d = txtLate.Text;
            int late = int.Parse(d);
            int totalLate = late * 20;
            txtTotalAmountLate.Text = totalLate.ToString();

            string f = txtAbsent.Text;
            int absent = int.Parse(f);
            int totalabsent = absent * salaryperday;

            int totalDeduction = totalLate + totalabsent;
            txtTotalDeduction.Text = totalDeduction.ToString();

            //total salary
            int totalsalary = (totalSalaryPerDay + totalOT) - totalDeduction;
            txtTotalSalary.Text = totalsalary.ToString();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if(txtRegularOT.Text == "" && txtLate.Text == "" && txtAbsent.Text == "")
            {
                txtRegularOT.Text = "0";
                txtLate.Text = "0";
                txtAbsent.Text = "0";
            }
            if (txtRegularOT.Text == "")
            {
                txtRegularOT.Text = "0";
            }
            if (txtLate.Text == "")
            {
                txtLate.Text = "0";
            }
            if (txtAbsent.Text == "")
            {
                txtAbsent.Text = "0";
            }
            payrollComputation();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            lblFirstname.Text = this.dgviewEmpPayroll.CurrentRow.Cells[1].Value.ToString();
            lblLastname.Text = this.dgviewEmpPayroll.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgviewEmpPayroll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNoOfWork.Text = "0";
            txtSalaryPerDay.Text = "0";
            txtRegularOT.Text = "0";
            txtLate.Text = "0";
            txtAbsent.Text = "0";

            txttotalSalaryPerDay.Text = "0";
            txtTotalAmountOT.Text = "0";
            txtTotalAmountLate.Text = "0";
            txtTotalDeduction.Text = "0";
            txtTotalSalary.Text = "0";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            //payroll header
            e.Graphics.DrawString("Payslip", new System.Drawing.Font("Arial", 26, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(350, 50));

            //date and time
            e.Graphics.DrawString(lbl_dash.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(30, 130));
            e.Graphics.DrawString("Time:  " + lblTime.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 152));
            e.Graphics.DrawString("Date:  " + lblDate.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 172)); // add + 22 for new line
            e.Graphics.DrawString(lbl_dash.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(30, 190));
            
            //name 
            e.Graphics.DrawString("First name:  " + lblFirstname.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 210));
            e.Graphics.DrawString("Last name:  " + lblLastname.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 232));
            e.Graphics.DrawString(lbl_dash.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(30, 250));

            //salary
            e.Graphics.DrawString("No of work days:  " + txtNoOfWork.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 270));
            e.Graphics.DrawString("Salary per day:  " + txtSalaryPerDay.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 290));
            e.Graphics.DrawString("Total salary per day:  " + txttotalSalaryPerDay.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 312));
            e.Graphics.DrawString(lbl_dash.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(30, 330));
           
            //overtime
            e.Graphics.DrawString("Regular overtime (hr/s):  " + txtRegularOT.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 350));
            e.Graphics.DrawString("Total overtime:  " + txtTotalAmountOT.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 372));
            e.Graphics.DrawString(lbl_dash.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(30, 390));

            //deduction
            e.Graphics.DrawString("Late (hr/s):  " + txtLate.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 410));
            e.Graphics.DrawString("Total late:  " + txtTotalAmountLate.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 430));
            e.Graphics.DrawString("Absent:  " + txtAbsent.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 450));
            e.Graphics.DrawString("Total deduction:  " + txtTotalDeduction.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 472));
            e.Graphics.DrawString(lbl_dash.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(30, 490));

            //total
            e.Graphics.DrawString("Total salary:  " + txtTotalSalary.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 512));
            e.Graphics.DrawString(lbl_dash.Text, new System.Drawing.Font("Arial", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(30, 530));

        }

        private void lblLastname_Click(object sender, EventArgs e)
        {

        }

        private void lblFirstname_Click(object sender, EventArgs e)
        {

        }
    }
}
