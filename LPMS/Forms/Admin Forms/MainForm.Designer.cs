namespace LPMS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMainSideBar = new System.Windows.Forms.Panel();
            this.btnReports = new FontAwesome.Sharp.IconButton();
            this.btnPayroll = new FontAwesome.Sharp.IconButton();
            this.btnManageAdmin = new FontAwesome.Sharp.IconButton();
            this.panelManageLeaveSub = new System.Windows.Forms.Panel();
            this.btnHistorySubMenu = new System.Windows.Forms.Button();
            this.btnSubMenuPending = new System.Windows.Forms.Button();
            this.btnManageLeaveMain = new FontAwesome.Sharp.IconButton();
            this.panelEmpSubMenu = new System.Windows.Forms.Panel();
            this.btnManageEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployeeSubMenu = new System.Windows.Forms.Button();
            this.iconBtnEmployee = new FontAwesome.Sharp.IconButton();
            this.iconBtnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelTop.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMainSideBar.SuspendLayout();
            this.panelManageLeaveSub.SuspendLayout();
            this.panelEmpSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(252, 78);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1137, 644);
            this.panelChildForm.TabIndex = 5;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.iconButton1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(252, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1137, 78);
            this.panelTop.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(1023, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(114, 78);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Admin";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(252, 78);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(26)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 78);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMainSideBar
            // 
            this.panelMainSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(26)))));
            this.panelMainSideBar.Controls.Add(this.btnReports);
            this.panelMainSideBar.Controls.Add(this.btnPayroll);
            this.panelMainSideBar.Controls.Add(this.btnManageAdmin);
            this.panelMainSideBar.Controls.Add(this.panelManageLeaveSub);
            this.panelMainSideBar.Controls.Add(this.btnManageLeaveMain);
            this.panelMainSideBar.Controls.Add(this.panelEmpSubMenu);
            this.panelMainSideBar.Controls.Add(this.iconBtnEmployee);
            this.panelMainSideBar.Controls.Add(this.iconBtnDashboard);
            this.panelMainSideBar.Controls.Add(this.panelLogo);
            this.panelMainSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelMainSideBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMainSideBar.Name = "panelMainSideBar";
            this.panelMainSideBar.Size = new System.Drawing.Size(252, 722);
            this.panelMainSideBar.TabIndex = 0;
            // 
            // btnReports
            // 
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReports.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnReports.IconColor = System.Drawing.Color.White;
            this.btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReports.IconSize = 23;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 650);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(252, 76);
            this.btnReports.TabIndex = 8;
            this.btnReports.Text = "    Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnPayroll
            // 
            this.btnPayroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayroll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayroll.FlatAppearance.BorderSize = 0;
            this.btnPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayroll.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayroll.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPayroll.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.btnPayroll.IconColor = System.Drawing.Color.White;
            this.btnPayroll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPayroll.IconSize = 23;
            this.btnPayroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayroll.Location = new System.Drawing.Point(0, 574);
            this.btnPayroll.Name = "btnPayroll";
            this.btnPayroll.Size = new System.Drawing.Size(252, 76);
            this.btnPayroll.TabIndex = 7;
            this.btnPayroll.Text = "    Payroll";
            this.btnPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayroll.UseVisualStyleBackColor = true;
            this.btnPayroll.Click += new System.EventHandler(this.btnPayroll_Click);
            // 
            // btnManageAdmin
            // 
            this.btnManageAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageAdmin.FlatAppearance.BorderSize = 0;
            this.btnManageAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAdmin.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAdmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnManageAdmin.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnManageAdmin.IconColor = System.Drawing.Color.White;
            this.btnManageAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManageAdmin.IconSize = 20;
            this.btnManageAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageAdmin.Location = new System.Drawing.Point(0, 498);
            this.btnManageAdmin.Name = "btnManageAdmin";
            this.btnManageAdmin.Size = new System.Drawing.Size(252, 76);
            this.btnManageAdmin.TabIndex = 2;
            this.btnManageAdmin.Text = "    Manage Admin";
            this.btnManageAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageAdmin.UseVisualStyleBackColor = true;
            this.btnManageAdmin.Click += new System.EventHandler(this.btnManageAdmin_Click);
            // 
            // panelManageLeaveSub
            // 
            this.panelManageLeaveSub.Controls.Add(this.btnHistorySubMenu);
            this.panelManageLeaveSub.Controls.Add(this.btnSubMenuPending);
            this.panelManageLeaveSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelManageLeaveSub.Location = new System.Drawing.Point(0, 400);
            this.panelManageLeaveSub.Name = "panelManageLeaveSub";
            this.panelManageLeaveSub.Size = new System.Drawing.Size(252, 98);
            this.panelManageLeaveSub.TabIndex = 5;
            // 
            // btnHistorySubMenu
            // 
            this.btnHistorySubMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorySubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorySubMenu.FlatAppearance.BorderSize = 0;
            this.btnHistorySubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorySubMenu.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorySubMenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHistorySubMenu.Location = new System.Drawing.Point(0, 53);
            this.btnHistorySubMenu.Name = "btnHistorySubMenu";
            this.btnHistorySubMenu.Size = new System.Drawing.Size(252, 53);
            this.btnHistorySubMenu.TabIndex = 1;
            this.btnHistorySubMenu.Text = "     History";
            this.btnHistorySubMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorySubMenu.UseVisualStyleBackColor = true;
            this.btnHistorySubMenu.Click += new System.EventHandler(this.btnHistorySubMenu_Click);
            // 
            // btnSubMenuPending
            // 
            this.btnSubMenuPending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubMenuPending.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenuPending.FlatAppearance.BorderSize = 0;
            this.btnSubMenuPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenuPending.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenuPending.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubMenuPending.Location = new System.Drawing.Point(0, 0);
            this.btnSubMenuPending.Name = "btnSubMenuPending";
            this.btnSubMenuPending.Size = new System.Drawing.Size(252, 53);
            this.btnSubMenuPending.TabIndex = 0;
            this.btnSubMenuPending.Text = "     Pending";
            this.btnSubMenuPending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMenuPending.UseVisualStyleBackColor = true;
            this.btnSubMenuPending.Click += new System.EventHandler(this.btnSubMenuPending_Click);
            // 
            // btnManageLeaveMain
            // 
            this.btnManageLeaveMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageLeaveMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageLeaveMain.FlatAppearance.BorderSize = 0;
            this.btnManageLeaveMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageLeaveMain.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageLeaveMain.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnManageLeaveMain.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.btnManageLeaveMain.IconColor = System.Drawing.Color.White;
            this.btnManageLeaveMain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManageLeaveMain.IconSize = 20;
            this.btnManageLeaveMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageLeaveMain.Location = new System.Drawing.Point(0, 326);
            this.btnManageLeaveMain.Name = "btnManageLeaveMain";
            this.btnManageLeaveMain.Size = new System.Drawing.Size(252, 74);
            this.btnManageLeaveMain.TabIndex = 4;
            this.btnManageLeaveMain.Text = "    Manage Leave";
            this.btnManageLeaveMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageLeaveMain.UseVisualStyleBackColor = true;
            this.btnManageLeaveMain.Click += new System.EventHandler(this.btnManageLeaveMain_Click);
            // 
            // panelEmpSubMenu
            // 
            this.panelEmpSubMenu.Controls.Add(this.btnManageEmployee);
            this.panelEmpSubMenu.Controls.Add(this.btnAddEmployeeSubMenu);
            this.panelEmpSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmpSubMenu.Location = new System.Drawing.Point(0, 228);
            this.panelEmpSubMenu.Name = "panelEmpSubMenu";
            this.panelEmpSubMenu.Size = new System.Drawing.Size(252, 98);
            this.panelEmpSubMenu.TabIndex = 3;
            // 
            // btnManageEmployee
            // 
            this.btnManageEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageEmployee.FlatAppearance.BorderSize = 0;
            this.btnManageEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageEmployee.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmployee.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnManageEmployee.Location = new System.Drawing.Point(0, 53);
            this.btnManageEmployee.Name = "btnManageEmployee";
            this.btnManageEmployee.Size = new System.Drawing.Size(252, 53);
            this.btnManageEmployee.TabIndex = 1;
            this.btnManageEmployee.Text = "     Manage Employee";
            this.btnManageEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageEmployee.UseVisualStyleBackColor = true;
            this.btnManageEmployee.Click += new System.EventHandler(this.btnManageEmployee_Click);
            // 
            // btnAddEmployeeSubMenu
            // 
            this.btnAddEmployeeSubMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmployeeSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddEmployeeSubMenu.FlatAppearance.BorderSize = 0;
            this.btnAddEmployeeSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployeeSubMenu.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployeeSubMenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddEmployeeSubMenu.Location = new System.Drawing.Point(0, 0);
            this.btnAddEmployeeSubMenu.Name = "btnAddEmployeeSubMenu";
            this.btnAddEmployeeSubMenu.Size = new System.Drawing.Size(252, 53);
            this.btnAddEmployeeSubMenu.TabIndex = 0;
            this.btnAddEmployeeSubMenu.Text = "     Add Employee";
            this.btnAddEmployeeSubMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployeeSubMenu.UseVisualStyleBackColor = true;
            this.btnAddEmployeeSubMenu.Click += new System.EventHandler(this.btnAddEmployeeSubMenu_Click);
            // 
            // iconBtnEmployee
            // 
            this.iconBtnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnEmployee.FlatAppearance.BorderSize = 0;
            this.iconBtnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnEmployee.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnEmployee.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnEmployee.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconBtnEmployee.IconColor = System.Drawing.Color.White;
            this.iconBtnEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnEmployee.IconSize = 25;
            this.iconBtnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnEmployee.Location = new System.Drawing.Point(0, 152);
            this.iconBtnEmployee.Name = "iconBtnEmployee";
            this.iconBtnEmployee.Size = new System.Drawing.Size(252, 76);
            this.iconBtnEmployee.TabIndex = 2;
            this.iconBtnEmployee.Text = "    Employee";
            this.iconBtnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnEmployee.UseVisualStyleBackColor = true;
            this.iconBtnEmployee.Click += new System.EventHandler(this.iconBtnEmployee_Click);
            // 
            // iconBtnDashboard
            // 
            this.iconBtnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnDashboard.FlatAppearance.BorderSize = 0;
            this.iconBtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnDashboard.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnDashboard.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.iconBtnDashboard.IconColor = System.Drawing.Color.White;
            this.iconBtnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnDashboard.IconSize = 25;
            this.iconBtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnDashboard.Location = new System.Drawing.Point(0, 78);
            this.iconBtnDashboard.Name = "iconBtnDashboard";
            this.iconBtnDashboard.Size = new System.Drawing.Size(252, 74);
            this.iconBtnDashboard.TabIndex = 1;
            this.iconBtnDashboard.Text = "    Dashboard";
            this.iconBtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnDashboard.UseVisualStyleBackColor = true;
            this.iconBtnDashboard.Click += new System.EventHandler(this.iconBtnDashboard_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 722);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMainSideBar);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelTop.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMainSideBar.ResumeLayout(false);
            this.panelManageLeaveSub.ResumeLayout(false);
            this.panelEmpSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMainSideBar;
        private FontAwesome.Sharp.IconButton iconBtnDashboard;
        private FontAwesome.Sharp.IconButton iconBtnEmployee;
        private System.Windows.Forms.Panel panelEmpSubMenu;
        private System.Windows.Forms.Button btnManageEmployee;
        private System.Windows.Forms.Button btnAddEmployeeSubMenu;
        private System.Windows.Forms.Panel panelManageLeaveSub;
        private System.Windows.Forms.Button btnHistorySubMenu;
        private System.Windows.Forms.Button btnSubMenuPending;
        private FontAwesome.Sharp.IconButton btnManageLeaveMain;
        private FontAwesome.Sharp.IconButton btnPayroll;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnManageAdmin;
        private FontAwesome.Sharp.IconButton btnReports;
    }
}

