using LPMS.Forms.Admin_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPMS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
            this.MaximizeBox = false;
            //this.MinimizeBox = false;
        }
        private void customizeDesign()
        {
            panelEmpSubMenu.Visible = false;
            panelManageLeaveSub.Visible = false;
        }
        private void hideSubeMenu()
        {
            if (panelEmpSubMenu.Visible == true)
                panelEmpSubMenu.Visible = false;
            if (panelManageLeaveSub.Visible == true)
                panelManageLeaveSub.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubeMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        } 

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconBtnEmployee_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEmpSubMenu);
        }

        private void btnAddEmployeeSubMenu_Click(object sender, EventArgs e)
        {
            openChildForm(new AddEmployees());
            hideSubeMenu();
        }

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageEmployees());
            hideSubeMenu();
        }

        private void btnManageLeaveMain_Click(object sender, EventArgs e)
        {
            showSubMenu(panelManageLeaveSub);
        }

        private void btnSubMenuPending_Click(object sender, EventArgs e)
        {
            openChildForm(new PendingLeaveAdmin());
            hideSubeMenu();
        }

        private void btnHistorySubMenu_Click(object sender, EventArgs e)
        {
            openChildForm(new HistoryLeaveAdmin());
            hideSubeMenu();
        }

        private void btnManageAdmin_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageAdmin());
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            openChildForm(new Payroll());
        }

        private void iconBtnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new DashboardAdmin());
        }

        private void Home_Load(object sender, EventArgs e)
        {
            openChildForm(new DashboardAdmin());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            openChildForm(new AdminReport());
        }
    }
}
