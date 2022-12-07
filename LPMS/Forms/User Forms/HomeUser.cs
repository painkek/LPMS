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

namespace LPMS.Forms.User_Forms
{
    public partial class HomeUser : Form
    {
        public HomeUser()
        {
            InitializeComponent();
        }

        private void UserSidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeUser_Load(object sender, EventArgs e)
        {
            openChildForm(new DashboardUser());
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
        private void iconButton1_Click(object sender, EventArgs e) //request leave button
        {
            openChildForm(new RequestLeave());
        }

        private void iconButton2_Click(object sender, EventArgs e) //my request
        {
            openChildForm(new MyRequest());
        }
        private void btnUserDashboardSidePanel_Click(object sender, EventArgs e)
        {
            openChildForm(new DashboardUser());
        }

    }
}
