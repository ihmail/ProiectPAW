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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.tsAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAdminUserManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAdminDatabase = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.grPatients = new System.Windows.Forms.GroupBox();
            this.btnViewGateo = new System.Windows.Forms.Button();
            this.lvPatients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnTest = new System.Windows.Forms.Panel();
            this.grGateo = new System.Windows.Forms.GroupBox();
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
            this.menuStrip1.SuspendLayout();
            this.grMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbPatientDetails.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.grPatients.SuspendLayout();
            this.pnTest.SuspendLayout();
            this.grGateo.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSearch,
            this.tsAdmin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1206, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // tsSearch
            // 
            this.tsSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.tsSearch.Name = "tsSearch";
            this.tsSearch.Size = new System.Drawing.Size(54, 20);
            this.tsSearch.Text = "&Search";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // tsAdmin
            // 
            this.tsAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdminUserManagement,
            this.tsAdminDatabase});
            this.tsAdmin.Name = "tsAdmin";
            this.tsAdmin.Size = new System.Drawing.Size(55, 20);
            this.tsAdmin.Text = "A&dmin";
            // 
            // tsAdminUserManagement
            // 
            this.tsAdminUserManagement.Name = "tsAdminUserManagement";
            this.tsAdminUserManagement.Size = new System.Drawing.Size(171, 22);
            this.tsAdminUserManagement.Text = "User Management";
            // 
            // tsAdminDatabase
            // 
            this.tsAdminDatabase.Name = "tsAdminDatabase";
            this.tsAdminDatabase.Size = new System.Drawing.Size(171, 22);
            this.tsAdminDatabase.Text = "Database settings";
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
            this.btnAddPatient.Text = "Add patient";
            this.btnAddPatient.UseVisualStyleBackColor = false;
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
            this.lblPopSpec.Location = new System.Drawing.Point(97, 63);
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
            this.lblSpecialization.Location = new System.Drawing.Point(6, 63);
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
            this.lvGateo.Sorting = System.Windows.Forms.SortOrder.Descending;
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
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GETA v.0.1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbPatientDetails.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            this.grPatients.ResumeLayout(false);
            this.pnTest.ResumeLayout(false);
            this.grGateo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem tsAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsAdminUserManagement;
        private System.Windows.Forms.ToolStripMenuItem tsAdminDatabase;
        public System.Windows.Forms.ToolStripMenuItem tsSearch;
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
    }
}

