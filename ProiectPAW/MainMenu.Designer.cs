namespace ProiectPAW
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnDbSettings = new System.Windows.Forms.Button();
            this.grMenu = new System.Windows.Forms.GroupBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnSearchPatients = new System.Windows.Forms.Button();
            this.btnListPatients = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPopTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPopSpec = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPopName = new System.Windows.Forms.Label();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbPatientDetails = new System.Windows.Forms.GroupBox();
            this.btnViewPatientDetails = new System.Windows.Forms.Button();
            this.lblPAHC = new System.Windows.Forms.Label();
            this.lblPAPF = new System.Windows.Forms.Label();
            this.lblPAPP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPBirthdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPGender = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.lblPName = new System.Windows.Forms.Label();
            this.txtCnp = new System.Windows.Forms.TextBox();
            this.lblPDCnp = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.grPatients = new System.Windows.Forms.GroupBox();
            this.btnDischarge = new System.Windows.Forms.Button();
            this.lblTotalPatients = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnViewGateo = new System.Windows.Forms.Button();
            this.lvPatients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmViewGateo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewGATEOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnTest = new System.Windows.Forms.Panel();
            this.grGateo = new System.Windows.Forms.GroupBox();
            this.lblTotalGateo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalG = new System.Windows.Forms.Label();
            this.btnEditGateo = new System.Windows.Forms.Button();
            this.btnBackGateo = new System.Windows.Forms.Button();
            this.lvGateo = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddGateo = new System.Windows.Forms.Button();
            this.grMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbPatientDetails.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.grPatients.SuspendLayout();
            this.cmViewGateo.SuspendLayout();
            this.pnTest.SuspendLayout();
            this.grGateo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDbSettings
            // 
            this.btnDbSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnDbSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbSettings.ForeColor = System.Drawing.Color.White;
            this.btnDbSettings.Location = new System.Drawing.Point(33, 376);
            this.btnDbSettings.Name = "btnDbSettings";
            this.btnDbSettings.Size = new System.Drawing.Size(147, 38);
            this.btnDbSettings.TabIndex = 6;
            this.btnDbSettings.Text = "Database settings";
            this.btnDbSettings.UseVisualStyleBackColor = false;
            this.btnDbSettings.Click += new System.EventHandler(this.btnDbSettings_Click);
            // 
            // grMenu
            // 
            this.grMenu.Controls.Add(this.btnChangePass);
            this.grMenu.Controls.Add(this.btnUserManagement);
            this.grMenu.Controls.Add(this.btnAccount);
            this.grMenu.Controls.Add(this.btnAddPatient);
            this.grMenu.Controls.Add(this.btnSearchPatients);
            this.grMenu.Controls.Add(this.btnListPatients);
            this.grMenu.Controls.Add(this.btnDbSettings);
            this.grMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grMenu.ForeColor = System.Drawing.Color.White;
            this.grMenu.Location = new System.Drawing.Point(18, 223);
            this.grMenu.Name = "grMenu";
            this.grMenu.Size = new System.Drawing.Size(229, 452);
            this.grMenu.TabIndex = 7;
            this.grMenu.TabStop = false;
            this.grMenu.Text = "Menu";
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Location = new System.Drawing.Point(33, 218);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(147, 38);
            this.btnChangePass.TabIndex = 12;
            this.btnChangePass.Text = "Change password";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.ForeColor = System.Drawing.Color.White;
            this.btnUserManagement.Location = new System.Drawing.Point(33, 332);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(147, 38);
            this.btnUserManagement.TabIndex = 11;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = false;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(33, 174);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(147, 38);
            this.btnAccount.TabIndex = 10;
            this.btnAccount.Text = "Change account details";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.ForeColor = System.Drawing.Color.White;
            this.btnAddPatient.Location = new System.Drawing.Point(33, 130);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(147, 38);
            this.btnAddPatient.TabIndex = 9;
            this.btnAddPatient.Text = "Add patient to database";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnSearchPatients
            // 
            this.btnSearchPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnSearchPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPatients.ForeColor = System.Drawing.Color.White;
            this.btnSearchPatients.Location = new System.Drawing.Point(33, 86);
            this.btnSearchPatients.Name = "btnSearchPatients";
            this.btnSearchPatients.Size = new System.Drawing.Size(147, 38);
            this.btnSearchPatients.TabIndex = 8;
            this.btnSearchPatients.Text = "Search patient";
            this.btnSearchPatients.UseVisualStyleBackColor = false;
            this.btnSearchPatients.Click += new System.EventHandler(this.btnSearchPatients_Click);
            // 
            // btnListPatients
            // 
            this.btnListPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnListPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListPatients.ForeColor = System.Drawing.Color.White;
            this.btnListPatients.Location = new System.Drawing.Point(33, 42);
            this.btnListPatients.Name = "btnListPatients";
            this.btnListPatients.Size = new System.Drawing.Size(147, 38);
            this.btnListPatients.TabIndex = 7;
            this.btnListPatients.Text = "My patients";
            this.btnListPatients.UseVisualStyleBackColor = false;
            this.btnListPatients.Click += new System.EventHandler(this.btnListPatients_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPopTitle);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.lblPopSpec);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblPopName);
            this.groupBox1.Controls.Add(this.lblSpecialization);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 145);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User details";
            // 
            // lblPopTitle
            // 
            this.lblPopTitle.ForeColor = System.Drawing.Color.White;
            this.lblPopTitle.Location = new System.Drawing.Point(97, 96);
            this.lblPopTitle.Name = "lblPopTitle";
            this.lblPopTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPopTitle.Size = new System.Drawing.Size(120, 13);
            this.lblPopTitle.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(6, 96);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(60, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Job Title:";
            // 
            // lblPopSpec
            // 
            this.lblPopSpec.ForeColor = System.Drawing.Color.White;
            this.lblPopSpec.Location = new System.Drawing.Point(97, 65);
            this.lblPopSpec.Name = "lblPopSpec";
            this.lblPopSpec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPopSpec.Size = new System.Drawing.Size(120, 13);
            this.lblPopSpec.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(6, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblPopName
            // 
            this.lblPopName.ForeColor = System.Drawing.Color.White;
            this.lblPopName.Location = new System.Drawing.Point(97, 33);
            this.lblPopName.Name = "lblPopName";
            this.lblPopName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPopName.Size = new System.Drawing.Size(120, 13);
            this.lblPopName.TabIndex = 3;
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.ForeColor = System.Drawing.Color.White;
            this.lblSpecialization.Location = new System.Drawing.Point(6, 65);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(90, 13);
            this.lblSpecialization.TabIndex = 1;
            this.lblSpecialization.Text = "Specialization:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.grMenu);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 688);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.panel2.Controls.Add(this.gbPatientDetails);
            this.panel2.Location = new System.Drawing.Point(297, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 182);
            this.panel2.TabIndex = 12;
            // 
            // gbPatientDetails
            // 
            this.gbPatientDetails.Controls.Add(this.btnViewPatientDetails);
            this.gbPatientDetails.Controls.Add(this.lblPAHC);
            this.gbPatientDetails.Controls.Add(this.lblPAPF);
            this.gbPatientDetails.Controls.Add(this.lblPAPP);
            this.gbPatientDetails.Controls.Add(this.label6);
            this.gbPatientDetails.Controls.Add(this.label5);
            this.gbPatientDetails.Controls.Add(this.label4);
            this.gbPatientDetails.Controls.Add(this.txtPBirthdate);
            this.gbPatientDetails.Controls.Add(this.label3);
            this.gbPatientDetails.Controls.Add(this.txtPGender);
            this.gbPatientDetails.Controls.Add(this.label2);
            this.gbPatientDetails.Controls.Add(this.txtPName);
            this.gbPatientDetails.Controls.Add(this.lblPName);
            this.gbPatientDetails.Controls.Add(this.txtCnp);
            this.gbPatientDetails.Controls.Add(this.lblPDCnp);
            this.gbPatientDetails.Controls.Add(this.btnExit);
            this.gbPatientDetails.Controls.Add(this.btnMinimize);
            this.gbPatientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPatientDetails.ForeColor = System.Drawing.Color.White;
            this.gbPatientDetails.Location = new System.Drawing.Point(16, 16);
            this.gbPatientDetails.Name = "gbPatientDetails";
            this.gbPatientDetails.Size = new System.Drawing.Size(868, 145);
            this.gbPatientDetails.TabIndex = 10;
            this.gbPatientDetails.TabStop = false;
            this.gbPatientDetails.Text = "Patient Details";
            // 
            // btnViewPatientDetails
            // 
            this.btnViewPatientDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnViewPatientDetails.Enabled = false;
            this.btnViewPatientDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPatientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPatientDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewPatientDetails.Location = new System.Drawing.Point(715, 101);
            this.btnViewPatientDetails.Name = "btnViewPatientDetails";
            this.btnViewPatientDetails.Size = new System.Drawing.Size(147, 38);
            this.btnViewPatientDetails.TabIndex = 16;
            this.btnViewPatientDetails.Text = "View details";
            this.btnViewPatientDetails.UseVisualStyleBackColor = false;
            this.btnViewPatientDetails.Click += new System.EventHandler(this.btnViewPatientDetails_Click);
            // 
            // lblPAHC
            // 
            this.lblPAHC.ForeColor = System.Drawing.Color.White;
            this.lblPAHC.Location = new System.Drawing.Point(53, 123);
            this.lblPAHC.Name = "lblPAHC";
            this.lblPAHC.Size = new System.Drawing.Size(605, 13);
            this.lblPAHC.TabIndex = 22;
            // 
            // lblPAPF
            // 
            this.lblPAPF.ForeColor = System.Drawing.Color.White;
            this.lblPAPF.Location = new System.Drawing.Point(52, 96);
            this.lblPAPF.Name = "lblPAPF";
            this.lblPAPF.Size = new System.Drawing.Size(605, 13);
            this.lblPAPF.TabIndex = 21;
            // 
            // lblPAPP
            // 
            this.lblPAPP.ForeColor = System.Drawing.Color.White;
            this.lblPAPP.Location = new System.Drawing.Point(52, 65);
            this.lblPAPP.Name = "lblPAPP";
            this.lblPAPP.Size = new System.Drawing.Size(605, 13);
            this.lblPAPP.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "AHC: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "APF: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "APP: ";
            // 
            // txtPBirthdate
            // 
            this.txtPBirthdate.Location = new System.Drawing.Point(556, 30);
            this.txtPBirthdate.Name = "txtPBirthdate";
            this.txtPBirthdate.ReadOnly = true;
            this.txtPBirthdate.Size = new System.Drawing.Size(101, 20);
            this.txtPBirthdate.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(480, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Birth date: ";
            // 
            // txtPGender
            // 
            this.txtPGender.Location = new System.Drawing.Point(407, 30);
            this.txtPGender.Name = "txtPGender";
            this.txtPGender.ReadOnly = true;
            this.txtPGender.Size = new System.Drawing.Size(69, 20);
            this.txtPGender.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(354, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Gender: ";
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(213, 30);
            this.txtPName.Name = "txtPName";
            this.txtPName.ReadOnly = true;
            this.txtPName.Size = new System.Drawing.Size(135, 20);
            this.txtPName.TabIndex = 12;
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.ForeColor = System.Drawing.Color.White;
            this.lblPName.Location = new System.Drawing.Point(160, 33);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(47, 13);
            this.lblPName.TabIndex = 11;
            this.lblPName.Text = "Name: ";
            // 
            // txtCnp
            // 
            this.txtCnp.Location = new System.Drawing.Point(53, 30);
            this.txtCnp.Name = "txtCnp";
            this.txtCnp.ReadOnly = true;
            this.txtCnp.Size = new System.Drawing.Size(101, 20);
            this.txtCnp.TabIndex = 10;
            // 
            // lblPDCnp
            // 
            this.lblPDCnp.AutoSize = true;
            this.lblPDCnp.ForeColor = System.Drawing.Color.White;
            this.lblPDCnp.Location = new System.Drawing.Point(7, 33);
            this.lblPDCnp.Name = "lblPDCnp";
            this.lblPDCnp.Size = new System.Drawing.Size(40, 13);
            this.lblPDCnp.TabIndex = 6;
            this.lblPDCnp.Text = "CNP: ";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::ProiectPAW.Properties.Resources.btnExit;
            this.btnExit.Location = new System.Drawing.Point(809, 17);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 49);
            this.btnExit.TabIndex = 8;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(749, 17);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(53, 49);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.pnMain.Controls.Add(this.grPatients);
            this.pnMain.Location = new System.Drawing.Point(297, 220);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(897, 480);
            this.pnMain.TabIndex = 13;
            // 
            // grPatients
            // 
            this.grPatients.Controls.Add(this.btnDischarge);
            this.grPatients.Controls.Add(this.lblTotalPatients);
            this.grPatients.Controls.Add(this.lblTotal);
            this.grPatients.Controls.Add(this.btnViewGateo);
            this.grPatients.Controls.Add(this.lvPatients);
            this.grPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grPatients.ForeColor = System.Drawing.Color.White;
            this.grPatients.Location = new System.Drawing.Point(16, 15);
            this.grPatients.Name = "grPatients";
            this.grPatients.Size = new System.Drawing.Size(868, 452);
            this.grPatients.TabIndex = 0;
            this.grPatients.TabStop = false;
            this.grPatients.Text = "My Patients";
            // 
            // btnDischarge
            // 
            this.btnDischarge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnDischarge.Enabled = false;
            this.btnDischarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDischarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDischarge.ForeColor = System.Drawing.Color.White;
            this.btnDischarge.Location = new System.Drawing.Point(562, 408);
            this.btnDischarge.Name = "btnDischarge";
            this.btnDischarge.Size = new System.Drawing.Size(147, 38);
            this.btnDischarge.TabIndex = 16;
            this.btnDischarge.Text = "Discharge patient";
            this.btnDischarge.UseVisualStyleBackColor = false;
            this.btnDischarge.Click += new System.EventHandler(this.btnDischarge_Click);
            // 
            // lblTotalPatients
            // 
            this.lblTotalPatients.AutoSize = true;
            this.lblTotalPatients.Location = new System.Drawing.Point(106, 421);
            this.lblTotalPatients.Name = "lblTotalPatients";
            this.lblTotalPatients.Size = new System.Drawing.Size(0, 13);
            this.lblTotalPatients.TabIndex = 15;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(7, 421);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(93, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total patients: ";
            // 
            // btnViewGateo
            // 
            this.btnViewGateo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnViewGateo.Enabled = false;
            this.btnViewGateo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewGateo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewGateo.ForeColor = System.Drawing.Color.White;
            this.btnViewGateo.Location = new System.Drawing.Point(715, 408);
            this.btnViewGateo.Name = "btnViewGateo";
            this.btnViewGateo.Size = new System.Drawing.Size(147, 38);
            this.btnViewGateo.TabIndex = 13;
            this.btnViewGateo.Text = "View GATE-O";
            this.btnViewGateo.UseVisualStyleBackColor = false;
            this.btnViewGateo.Click += new System.EventHandler(this.btnViewGateo_Click);
            // 
            // lvPatients
            // 
            this.lvPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.lvPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.lvPatients.ContextMenuStrip = this.cmViewGateo;
            this.lvPatients.ForeColor = System.Drawing.Color.White;
            this.lvPatients.FullRowSelect = true;
            this.lvPatients.GridLines = true;
            this.lvPatients.HideSelection = false;
            this.lvPatients.Location = new System.Drawing.Point(6, 42);
            this.lvPatients.MultiSelect = false;
            this.lvPatients.Name = "lvPatients";
            this.lvPatients.Size = new System.Drawing.Size(856, 360);
            this.lvPatients.TabIndex = 3;
            this.lvPatients.TileSize = new System.Drawing.Size(188, 30);
            this.lvPatients.UseCompatibleStateImageBehavior = false;
            this.lvPatients.View = System.Windows.Forms.View.Details;
            this.lvPatients.SelectedIndexChanged += new System.EventHandler(this.lvPatients_SelectedIndexChanged);
            this.lvPatients.Click += new System.EventHandler(this.lvPatients_Click);
            this.lvPatients.DoubleClick += new System.EventHandler(this.btnViewGateo_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Patient name";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hospitalization reason";
            this.columnHeader3.Width = 574;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Admission date";
            this.columnHeader4.Width = 151;
            // 
            // cmViewGateo
            // 
            this.cmViewGateo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewGATEOToolStripMenuItem});
            this.cmViewGateo.Name = "cmViewGateo";
            this.cmViewGateo.Size = new System.Drawing.Size(146, 26);
            // 
            // viewGATEOToolStripMenuItem
            // 
            this.viewGATEOToolStripMenuItem.Name = "viewGATEOToolStripMenuItem";
            this.viewGATEOToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.viewGATEOToolStripMenuItem.Text = "View GATE-O";
            this.viewGATEOToolStripMenuItem.Click += new System.EventHandler(this.viewGATEOToolStripMenuItem_Click);
            // 
            // pnTest
            // 
            this.pnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.pnTest.Controls.Add(this.grGateo);
            this.pnTest.Location = new System.Drawing.Point(297, 722);
            this.pnTest.Name = "pnTest";
            this.pnTest.Size = new System.Drawing.Size(897, 480);
            this.pnTest.TabIndex = 14;
            // 
            // grGateo
            // 
            this.grGateo.Controls.Add(this.lblTotalGateo);
            this.grGateo.Controls.Add(this.label1);
            this.grGateo.Controls.Add(this.lblTotalG);
            this.grGateo.Controls.Add(this.btnEditGateo);
            this.grGateo.Controls.Add(this.btnBackGateo);
            this.grGateo.Controls.Add(this.lvGateo);
            this.grGateo.Controls.Add(this.btnAddGateo);
            this.grGateo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grGateo.ForeColor = System.Drawing.Color.White;
            this.grGateo.Location = new System.Drawing.Point(16, 16);
            this.grGateo.Name = "grGateo";
            this.grGateo.Size = new System.Drawing.Size(868, 452);
            this.grGateo.TabIndex = 0;
            this.grGateo.TabStop = false;
            this.grGateo.Text = "GATE-O";
            // 
            // lblTotalGateo
            // 
            this.lblTotalGateo.AutoSize = true;
            this.lblTotalGateo.Location = new System.Drawing.Point(96, 421);
            this.lblTotalGateo.Name = "lblTotalGateo";
            this.lblTotalGateo.Size = new System.Drawing.Size(0, 13);
            this.lblTotalGateo.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // lblTotalG
            // 
            this.lblTotalG.AutoSize = true;
            this.lblTotalG.Location = new System.Drawing.Point(6, 421);
            this.lblTotalG.Name = "lblTotalG";
            this.lblTotalG.Size = new System.Drawing.Size(94, 13);
            this.lblTotalG.TabIndex = 17;
            this.lblTotalG.Text = "Total GATE-O: ";
            // 
            // btnEditGateo
            // 
            this.btnEditGateo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnEditGateo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditGateo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGateo.ForeColor = System.Drawing.Color.White;
            this.btnEditGateo.Location = new System.Drawing.Point(562, 408);
            this.btnEditGateo.Name = "btnEditGateo";
            this.btnEditGateo.Size = new System.Drawing.Size(147, 38);
            this.btnEditGateo.TabIndex = 16;
            this.btnEditGateo.Text = "Edit GATE-O";
            this.btnEditGateo.UseVisualStyleBackColor = false;
            this.btnEditGateo.Click += new System.EventHandler(this.btnEditGateo_Click);
            // 
            // btnBackGateo
            // 
            this.btnBackGateo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnBackGateo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackGateo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackGateo.ForeColor = System.Drawing.Color.White;
            this.btnBackGateo.Location = new System.Drawing.Point(409, 408);
            this.btnBackGateo.Name = "btnBackGateo";
            this.btnBackGateo.Size = new System.Drawing.Size(147, 38);
            this.btnBackGateo.TabIndex = 15;
            this.btnBackGateo.Text = "Back";
            this.btnBackGateo.UseVisualStyleBackColor = false;
            this.btnBackGateo.Click += new System.EventHandler(this.btnBackGateo_Click);
            // 
            // lvGateo
            // 
            this.lvGateo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.lvGateo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvGateo.ForeColor = System.Drawing.Color.White;
            this.lvGateo.FullRowSelect = true;
            this.lvGateo.GridLines = true;
            this.lvGateo.HideSelection = false;
            this.lvGateo.Location = new System.Drawing.Point(6, 44);
            this.lvGateo.MultiSelect = false;
            this.lvGateo.Name = "lvGateo";
            this.lvGateo.Size = new System.Drawing.Size(856, 360);
            this.lvGateo.TabIndex = 4;
            this.lvGateo.TileSize = new System.Drawing.Size(188, 30);
            this.lvGateo.UseCompatibleStateImageBehavior = false;
            this.lvGateo.View = System.Windows.Forms.View.Details;
            this.lvGateo.DoubleClick += new System.EventHandler(this.btnEditGateo_Click);
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 93;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gandeste";
            this.columnHeader2.Width = 145;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Analize";
            this.columnHeader5.Width = 155;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tratament";
            this.columnHeader6.Width = 143;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Evolutie";
            this.columnHeader7.Width = 152;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Observatii";
            this.columnHeader8.Width = 151;
            // 
            // btnAddGateo
            // 
            this.btnAddGateo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnAddGateo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGateo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGateo.ForeColor = System.Drawing.Color.White;
            this.btnAddGateo.Location = new System.Drawing.Point(715, 408);
            this.btnAddGateo.Name = "btnAddGateo";
            this.btnAddGateo.Size = new System.Drawing.Size(147, 38);
            this.btnAddGateo.TabIndex = 14;
            this.btnAddGateo.Text = "Add GATE-O";
            this.btnAddGateo.UseVisualStyleBackColor = false;
            this.btnAddGateo.Click += new System.EventHandler(this.btnAddGateo_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1206, 1223);
            this.Controls.Add(this.pnTest);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GETA v.0.1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.grMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbPatientDetails.ResumeLayout(false);
            this.gbPatientDetails.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.grPatients.ResumeLayout(false);
            this.grPatients.PerformLayout();
            this.cmViewGateo.ResumeLayout(false);
            this.pnTest.ResumeLayout(false);
            this.grGateo.ResumeLayout(false);
            this.grGateo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDbSettings;
        private System.Windows.Forms.GroupBox grMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPopName;
        private System.Windows.Forms.Label lblPopTitle;
        private System.Windows.Forms.Label lblPopSpec;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnSearchPatients;
        private System.Windows.Forms.Button btnListPatients;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbPatientDetails;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.GroupBox grPatients;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.ListView lvPatients;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel pnTest;
        private System.Windows.Forms.GroupBox grGateo;
        private System.Windows.Forms.ListView lvGateo;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnViewGateo;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Button btnBackGateo;
        private System.Windows.Forms.Button btnAddGateo;
        private System.Windows.Forms.Button btnEditGateo;
        private System.Windows.Forms.Label lblTotalPatients;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalG;
        private System.Windows.Forms.Label lblTotalGateo;
        private System.Windows.Forms.Button btnViewPatientDetails;
        private System.Windows.Forms.Label lblPAHC;
        private System.Windows.Forms.Label lblPAPF;
        private System.Windows.Forms.Label lblPAPP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPBirthdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.TextBox txtCnp;
        private System.Windows.Forms.Label lblPDCnp;
        private System.Windows.Forms.Button btnDischarge;
        private System.Windows.Forms.ContextMenuStrip cmViewGateo;
        private System.Windows.Forms.ToolStripMenuItem viewGATEOToolStripMenuItem;
    }
}

