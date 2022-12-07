namespace LPMS.Forms.Admin_Forms
{
    partial class Payroll
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payroll));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panelPayroll = new System.Windows.Forms.Panel();
            this.txtTotalSalary = new TextBoxCustom();
            this.txtTotalDeduction = new TextBoxCustom();
            this.txtTotalAmountLate = new TextBoxCustom();
            this.txtTotalAmountOT = new TextBoxCustom();
            this.txttotalSalaryPerDay = new TextBoxCustom();
            this.btnClear = new LPMS.Class.CustomButton();
            this.btnCompute = new LPMS.Class.CustomButton();
            this.btnPrint = new LPMS.Class.CustomButton();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAbsent = new TextBoxCustom();
            this.txtNoOfWork = new TextBoxCustom();
            this.txtLate = new TextBoxCustom();
            this.txtSalaryPerDay = new TextBoxCustom();
            this.txtRegularOT = new TextBoxCustom();
            this.lbl_dash = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.dgviewEmpPayroll = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbladdEmpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lPMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lPMSDataSet = new LPMS.LPMSDataSet();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tbl_addEmpTableAdapter = new LPMS.LPMSDataSetTableAdapters.tbl_addEmpTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panelPayroll.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewEmpPayroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbladdEmpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPMSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Payroll";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Income:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "No. of Working Day(s):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Salary per day:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Total salary per day:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Overtime:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Regular OT (hr/s):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Total amount of OT:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(79, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 23);
            this.label9.TabIndex = 27;
            this.label9.Text = "Deduction:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Late (hr/s):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(99, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Total amount of late:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(100, 431);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Absent:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(100, 470);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Total deduction:";
            // 
            // panelPayroll
            // 
            this.panelPayroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.panelPayroll.Controls.Add(this.txtTotalSalary);
            this.panelPayroll.Controls.Add(this.txtTotalDeduction);
            this.panelPayroll.Controls.Add(this.txtTotalAmountLate);
            this.panelPayroll.Controls.Add(this.txtTotalAmountOT);
            this.panelPayroll.Controls.Add(this.txttotalSalaryPerDay);
            this.panelPayroll.Controls.Add(this.btnClear);
            this.panelPayroll.Controls.Add(this.btnCompute);
            this.panelPayroll.Controls.Add(this.btnPrint);
            this.panelPayroll.Controls.Add(this.label14);
            this.panelPayroll.Controls.Add(this.label3);
            this.panelPayroll.Controls.Add(this.label2);
            this.panelPayroll.Controls.Add(this.txtAbsent);
            this.panelPayroll.Controls.Add(this.label1);
            this.panelPayroll.Controls.Add(this.txtNoOfWork);
            this.panelPayroll.Controls.Add(this.txtLate);
            this.panelPayroll.Controls.Add(this.label4);
            this.panelPayroll.Controls.Add(this.label13);
            this.panelPayroll.Controls.Add(this.label5);
            this.panelPayroll.Controls.Add(this.label12);
            this.panelPayroll.Controls.Add(this.label6);
            this.panelPayroll.Controls.Add(this.label11);
            this.panelPayroll.Controls.Add(this.label7);
            this.panelPayroll.Controls.Add(this.label10);
            this.panelPayroll.Controls.Add(this.label8);
            this.panelPayroll.Controls.Add(this.label9);
            this.panelPayroll.Controls.Add(this.txtSalaryPerDay);
            this.panelPayroll.Controls.Add(this.txtRegularOT);
            this.panelPayroll.Controls.Add(this.lbl_dash);
            this.panelPayroll.Location = new System.Drawing.Point(573, 19);
            this.panelPayroll.Name = "panelPayroll";
            this.panelPayroll.Size = new System.Drawing.Size(555, 613);
            this.panelPayroll.TabIndex = 36;
            this.panelPayroll.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPayroll_Paint);
            // 
            // txtTotalSalary
            // 
            this.txtTotalSalary.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTotalSalary.Location = new System.Drawing.Point(232, 507);
            this.txtTotalSalary.Multiline = true;
            this.txtTotalSalary.Name = "txtTotalSalary";
            this.txtTotalSalary.Size = new System.Drawing.Size(192, 27);
            this.txtTotalSalary.TabIndex = 55;
            this.txtTotalSalary.Text = "0";
            // 
            // txtTotalDeduction
            // 
            this.txtTotalDeduction.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTotalDeduction.Location = new System.Drawing.Point(304, 467);
            this.txtTotalDeduction.Multiline = true;
            this.txtTotalDeduction.Name = "txtTotalDeduction";
            this.txtTotalDeduction.Size = new System.Drawing.Size(121, 27);
            this.txtTotalDeduction.TabIndex = 54;
            this.txtTotalDeduction.Text = "0";
            // 
            // txtTotalAmountLate
            // 
            this.txtTotalAmountLate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTotalAmountLate.Location = new System.Drawing.Point(304, 385);
            this.txtTotalAmountLate.Multiline = true;
            this.txtTotalAmountLate.Name = "txtTotalAmountLate";
            this.txtTotalAmountLate.Size = new System.Drawing.Size(121, 27);
            this.txtTotalAmountLate.TabIndex = 53;
            this.txtTotalAmountLate.Text = "0";
            // 
            // txtTotalAmountOT
            // 
            this.txtTotalAmountOT.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTotalAmountOT.Location = new System.Drawing.Point(304, 260);
            this.txtTotalAmountOT.Multiline = true;
            this.txtTotalAmountOT.Name = "txtTotalAmountOT";
            this.txtTotalAmountOT.Size = new System.Drawing.Size(121, 27);
            this.txtTotalAmountOT.TabIndex = 52;
            this.txtTotalAmountOT.Text = "0";
            // 
            // txttotalSalaryPerDay
            // 
            this.txttotalSalaryPerDay.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txttotalSalaryPerDay.Location = new System.Drawing.Point(304, 147);
            this.txttotalSalaryPerDay.Multiline = true;
            this.txttotalSalaryPerDay.Name = "txttotalSalaryPerDay";
            this.txttotalSalaryPerDay.Size = new System.Drawing.Size(121, 27);
            this.txttotalSalaryPerDay.TabIndex = 51;
            this.txttotalSalaryPerDay.Text = "0";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(78)))), ((int)(((byte)(59)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(222, 554);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 37);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(78)))), ((int)(((byte)(59)))));
            this.btnCompute.FlatAppearance.BorderSize = 0;
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompute.ForeColor = System.Drawing.Color.White;
            this.btnCompute.Location = new System.Drawing.Point(321, 554);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(93, 37);
            this.btnCompute.TabIndex = 41;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(78)))), ((int)(((byte)(59)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(123, 554);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 37);
            this.btnPrint.TabIndex = 40;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(100, 510);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 20);
            this.label14.TabIndex = 36;
            this.label14.Text = "Total Salary:";
            // 
            // txtAbsent
            // 
            this.txtAbsent.BackColor = System.Drawing.SystemColors.Window;
            this.txtAbsent.Location = new System.Drawing.Point(304, 425);
            this.txtAbsent.Multiline = true;
            this.txtAbsent.Name = "txtAbsent";
            this.txtAbsent.Size = new System.Drawing.Size(121, 27);
            this.txtAbsent.TabIndex = 34;
            // 
            // txtNoOfWork
            // 
            this.txtNoOfWork.BackColor = System.Drawing.SystemColors.Window;
            this.txtNoOfWork.Location = new System.Drawing.Point(303, 67);
            this.txtNoOfWork.Multiline = true;
            this.txtNoOfWork.Name = "txtNoOfWork";
            this.txtNoOfWork.Size = new System.Drawing.Size(121, 27);
            this.txtNoOfWork.TabIndex = 17;
            // 
            // txtLate
            // 
            this.txtLate.BackColor = System.Drawing.SystemColors.Window;
            this.txtLate.Location = new System.Drawing.Point(303, 339);
            this.txtLate.Multiline = true;
            this.txtLate.Name = "txtLate";
            this.txtLate.Size = new System.Drawing.Size(121, 27);
            this.txtLate.TabIndex = 32;
            // 
            // txtSalaryPerDay
            // 
            this.txtSalaryPerDay.BackColor = System.Drawing.SystemColors.Window;
            this.txtSalaryPerDay.Location = new System.Drawing.Point(303, 107);
            this.txtSalaryPerDay.Multiline = true;
            this.txtSalaryPerDay.Name = "txtSalaryPerDay";
            this.txtSalaryPerDay.Size = new System.Drawing.Size(121, 27);
            this.txtSalaryPerDay.TabIndex = 23;
            // 
            // txtRegularOT
            // 
            this.txtRegularOT.BackColor = System.Drawing.SystemColors.Window;
            this.txtRegularOT.Location = new System.Drawing.Point(303, 220);
            this.txtRegularOT.Multiline = true;
            this.txtRegularOT.Name = "txtRegularOT";
            this.txtRegularOT.Size = new System.Drawing.Size(121, 27);
            this.txtRegularOT.TabIndex = 25;
            // 
            // lbl_dash
            // 
            this.lbl_dash.AutoSize = true;
            this.lbl_dash.Location = new System.Drawing.Point(3, 686);
            this.lbl_dash.Name = "lbl_dash";
            this.lbl_dash.Size = new System.Drawing.Size(1206, 20);
            this.lbl_dash.TabIndex = 48;
            this.lbl_dash.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------------\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.dgviewEmpPayroll);
            this.panel1.Controls.Add(this.lblLastname);
            this.panel1.Controls.Add(this.lblFirstname);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Location = new System.Drawing.Point(12, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 613);
            this.panel1.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(203, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 23);
            this.label15.TabIndex = 47;
            this.label15.Text = "Employee";
            // 
            // dgviewEmpPayroll
            // 
            this.dgviewEmpPayroll.AutoGenerateColumns = false;
            this.dgviewEmpPayroll.BackgroundColor = System.Drawing.Color.White;
            this.dgviewEmpPayroll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgviewEmpPayroll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgviewEmpPayroll.ColumnHeadersHeight = 29;
            this.dgviewEmpPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgviewEmpPayroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn});
            this.dgviewEmpPayroll.DataSource = this.tbladdEmpBindingSource;
            this.dgviewEmpPayroll.EnableHeadersVisualStyles = false;
            this.dgviewEmpPayroll.GridColor = System.Drawing.Color.White;
            this.dgviewEmpPayroll.Location = new System.Drawing.Point(42, 107);
            this.dgviewEmpPayroll.Name = "dgviewEmpPayroll";
            this.dgviewEmpPayroll.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgviewEmpPayroll.RowHeadersVisible = false;
            this.dgviewEmpPayroll.RowHeadersWidth = 51;
            this.dgviewEmpPayroll.RowTemplate.Height = 24;
            this.dgviewEmpPayroll.Size = new System.Drawing.Size(472, 467);
            this.dgviewEmpPayroll.TabIndex = 46;
            this.dgviewEmpPayroll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewEmpPayroll_CellContentClick);
            this.dgviewEmpPayroll.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // tbladdEmpBindingSource
            // 
            this.tbladdEmpBindingSource.DataMember = "tbl_addEmp";
            this.tbladdEmpBindingSource.DataSource = this.lPMSDataSetBindingSource;
            // 
            // lPMSDataSetBindingSource
            // 
            this.lPMSDataSetBindingSource.DataSource = this.lPMSDataSet;
            this.lPMSDataSetBindingSource.Position = 0;
            // 
            // lPMSDataSet
            // 
            this.lPMSDataSet.DataSetName = "LPMSDataSet";
            this.lPMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(305, 84);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(81, 20);
            this.lblLastname.TabIndex = 45;
            this.lblLastname.Text = "Lastname";
            this.lblLastname.Click += new System.EventHandler(this.lblLastname_Click);
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(100, 84);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(81, 20);
            this.lblFirstname.TabIndex = 44;
            this.lblFirstname.Text = "Firstame";
            this.lblFirstname.Click += new System.EventHandler(this.lblFirstname_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(305, 54);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 20);
            this.lblDate.TabIndex = 43;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(100, 54);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(45, 20);
            this.lblTime.TabIndex = 42;
            this.lblTime.Text = "Time";
            // 
            // tbl_addEmpTableAdapter
            // 
            this.tbl_addEmpTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1137, 644);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPayroll);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Payroll";
            this.Text = "Payroll";
            this.Load += new System.EventHandler(this.Payroll_Load);
            this.panelPayroll.ResumeLayout(false);
            this.panelPayroll.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewEmpPayroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbladdEmpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPMSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPMSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private TextBoxCustom txtNoOfWork;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private TextBoxCustom txtSalaryPerDay;
        private TextBoxCustom txtRegularOT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private TextBoxCustom txtLate;
        private TextBoxCustom txtAbsent;
        private System.Windows.Forms.Panel panelPayroll;
        private System.Windows.Forms.Label label14;
        private Class.CustomButton btnCompute;
        private Class.CustomButton btnPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.DataGridView dgviewEmpPayroll;
        private System.Windows.Forms.BindingSource lPMSDataSetBindingSource;
        private LPMSDataSet lPMSDataSet;
        private System.Windows.Forms.BindingSource tbladdEmpBindingSource;
        private LPMSDataSetTableAdapters.tbl_addEmpTableAdapter tbl_addEmpTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label15;
        private Class.CustomButton btnClear;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lbl_dash;
        private TextBoxCustom txttotalSalaryPerDay;
        private TextBoxCustom txtTotalAmountOT;
        private TextBoxCustom txtTotalAmountLate;
        private TextBoxCustom txtTotalDeduction;
        private TextBoxCustom txtTotalSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
    }
}