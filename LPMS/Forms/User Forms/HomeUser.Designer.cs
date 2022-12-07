namespace LPMS.Forms.User_Forms
{
    partial class HomeUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUser));
            this.UserSidePanel = new System.Windows.Forms.Panel();
            this.btnUserRequestView = new FontAwesome.Sharp.IconButton();
            this.btnUserRequestLeave = new FontAwesome.Sharp.IconButton();
            this.btnUserDashboardSidePanel = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.UserSidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserSidePanel
            // 
            this.UserSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(26)))));
            this.UserSidePanel.Controls.Add(this.btnUserRequestView);
            this.UserSidePanel.Controls.Add(this.btnUserRequestLeave);
            this.UserSidePanel.Controls.Add(this.btnUserDashboardSidePanel);
            this.UserSidePanel.Controls.Add(this.panel1);
            this.UserSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.UserSidePanel.Location = new System.Drawing.Point(0, 0);
            this.UserSidePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserSidePanel.Name = "UserSidePanel";
            this.UserSidePanel.Size = new System.Drawing.Size(252, 722);
            this.UserSidePanel.TabIndex = 0;
            this.UserSidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UserSidePanel_Paint);
            // 
            // btnUserRequestView
            // 
            this.btnUserRequestView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserRequestView.FlatAppearance.BorderSize = 0;
            this.btnUserRequestView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserRequestView.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserRequestView.ForeColor = System.Drawing.Color.White;
            this.btnUserRequestView.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnUserRequestView.IconColor = System.Drawing.Color.White;
            this.btnUserRequestView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserRequestView.IconSize = 30;
            this.btnUserRequestView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserRequestView.Location = new System.Drawing.Point(0, 214);
            this.btnUserRequestView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUserRequestView.Name = "btnUserRequestView";
            this.btnUserRequestView.Size = new System.Drawing.Size(252, 70);
            this.btnUserRequestView.TabIndex = 3;
            this.btnUserRequestView.Text = "    My Request";
            this.btnUserRequestView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserRequestView.UseVisualStyleBackColor = true;
            this.btnUserRequestView.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnUserRequestLeave
            // 
            this.btnUserRequestLeave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserRequestLeave.FlatAppearance.BorderSize = 0;
            this.btnUserRequestLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserRequestLeave.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserRequestLeave.ForeColor = System.Drawing.Color.White;
            this.btnUserRequestLeave.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnUserRequestLeave.IconColor = System.Drawing.Color.White;
            this.btnUserRequestLeave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserRequestLeave.IconSize = 25;
            this.btnUserRequestLeave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserRequestLeave.Location = new System.Drawing.Point(0, 144);
            this.btnUserRequestLeave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUserRequestLeave.Name = "btnUserRequestLeave";
            this.btnUserRequestLeave.Size = new System.Drawing.Size(252, 70);
            this.btnUserRequestLeave.TabIndex = 2;
            this.btnUserRequestLeave.Text = "    Request Leave";
            this.btnUserRequestLeave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserRequestLeave.UseVisualStyleBackColor = true;
            this.btnUserRequestLeave.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnUserDashboardSidePanel
            // 
            this.btnUserDashboardSidePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserDashboardSidePanel.FlatAppearance.BorderSize = 0;
            this.btnUserDashboardSidePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserDashboardSidePanel.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDashboardSidePanel.ForeColor = System.Drawing.Color.White;
            this.btnUserDashboardSidePanel.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnUserDashboardSidePanel.IconColor = System.Drawing.Color.White;
            this.btnUserDashboardSidePanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserDashboardSidePanel.IconSize = 25;
            this.btnUserDashboardSidePanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserDashboardSidePanel.Location = new System.Drawing.Point(0, 74);
            this.btnUserDashboardSidePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUserDashboardSidePanel.Name = "btnUserDashboardSidePanel";
            this.btnUserDashboardSidePanel.Size = new System.Drawing.Size(252, 70);
            this.btnUserDashboardSidePanel.TabIndex = 1;
            this.btnUserDashboardSidePanel.Text = "    Dashboard";
            this.btnUserDashboardSidePanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserDashboardSidePanel.UseVisualStyleBackColor = true;
            this.btnUserDashboardSidePanel.Click += new System.EventHandler(this.btnUserDashboardSidePanel_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 74);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(252, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1137, 74);
            this.panel2.TabIndex = 1;
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
            this.iconButton1.Size = new System.Drawing.Size(114, 74);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "User";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(252, 74);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1137, 648);
            this.panelChildForm.TabIndex = 6;
            // 
            // HomeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1389, 722);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UserSidePanel);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomeUser";
            this.Load += new System.EventHandler(this.HomeUser_Load);
            this.UserSidePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UserSidePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnUserDashboardSidePanel;
        private FontAwesome.Sharp.IconButton btnUserRequestView;
        private FontAwesome.Sharp.IconButton btnUserRequestLeave;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelChildForm;
    }
}