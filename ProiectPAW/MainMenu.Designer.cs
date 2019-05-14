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
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnSearchPatients = new System.Windows.Forms.Button();
            this.btnListPatients = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPopTitle = new System.Windows.Forms.Label();
            this.lblPopSpec = new System.Windows.Forms.Label();
            this.lblPopName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1189, 24);
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
            this.tsAdminDatabase.Click += new System.EventHandler(this.tsAdminDatabase_Click);
            // 
            // btnDbSettings
            // 
            this.btnDbSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.btnDbSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbSettings.ForeColor = System.Drawing.Color.White;
            this.btnDbSettings.Location = new System.Drawing.Point(33, 421);
            this.btnDbSettings.Name = "btnDbSettings";
            this.btnDbSettings.Size = new System.Drawing.Size(147, 38);
            this.btnDbSettings.TabIndex = 6;
            this.btnDbSettings.Text = "Database settings";
            this.btnDbSettings.UseVisualStyleBackColor = false;
            // 
            // grMenu
            // 
            this.grMenu.Controls.Add(this.btnUserManagement);
            this.grMenu.Controls.Add(this.btnAccount);
            this.grMenu.Controls.Add(this.btnAddPatient);
            this.grMenu.Controls.Add(this.btnSearchPatients);
            this.grMenu.Controls.Add(this.btnListPatients);
            this.grMenu.Controls.Add(this.btnDbSettings);
            this.grMenu.Location = new System.Drawing.Point(12, 189);
            this.grMenu.Name = "grMenu";
            this.grMenu.Size = new System.Drawing.Size(229, 498);
            this.grMenu.TabIndex = 7;
            this.grMenu.TabStop = false;
            this.grMenu.Text = "Menu";
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManagement.ForeColor = System.Drawing.Color.White;
            this.btnUserManagement.Location = new System.Drawing.Point(33, 377);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(147, 38);
            this.btnUserManagement.TabIndex = 11;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = false;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(33, 178);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(147, 38);
            this.btnAccount.TabIndex = 10;
            this.btnAccount.Text = "Change account details";
            this.btnAccount.UseVisualStyleBackColor = false;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatient.ForeColor = System.Drawing.Color.White;
            this.btnAddPatient.Location = new System.Drawing.Point(33, 134);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(147, 38);
            this.btnAddPatient.TabIndex = 9;
            this.btnAddPatient.Text = "Add patient";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            // 
            // btnSearchPatients
            // 
            this.btnSearchPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.btnSearchPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPatients.ForeColor = System.Drawing.Color.White;
            this.btnSearchPatients.Location = new System.Drawing.Point(33, 90);
            this.btnSearchPatients.Name = "btnSearchPatients";
            this.btnSearchPatients.Size = new System.Drawing.Size(147, 38);
            this.btnSearchPatients.TabIndex = 8;
            this.btnSearchPatients.Text = "Search patient";
            this.btnSearchPatients.UseVisualStyleBackColor = false;
            // 
            // btnListPatients
            // 
            this.btnListPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.btnListPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListPatients.ForeColor = System.Drawing.Color.White;
            this.btnListPatients.Location = new System.Drawing.Point(33, 46);
            this.btnListPatients.Name = "btnListPatients";
            this.btnListPatients.Size = new System.Drawing.Size(147, 38);
            this.btnListPatients.TabIndex = 7;
            this.btnListPatients.Text = "List patients";
            this.btnListPatients.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 145);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.lblPopTitle);
            this.panel1.Controls.Add(this.lblPopSpec);
            this.panel1.Controls.Add(this.lblPopName);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblSpecialization);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 108);
            this.panel1.TabIndex = 11;
            // 
            // lblPopTitle
            // 
            this.lblPopTitle.ForeColor = System.Drawing.Color.White;
            this.lblPopTitle.Location = new System.Drawing.Point(94, 72);
            this.lblPopTitle.Name = "lblPopTitle";
            this.lblPopTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPopTitle.Size = new System.Drawing.Size(120, 13);
            this.lblPopTitle.TabIndex = 5;
            // 
            // lblPopSpec
            // 
            this.lblPopSpec.ForeColor = System.Drawing.Color.White;
            this.lblPopSpec.Location = new System.Drawing.Point(94, 46);
            this.lblPopSpec.Name = "lblPopSpec";
            this.lblPopSpec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPopSpec.Size = new System.Drawing.Size(120, 13);
            this.lblPopSpec.TabIndex = 4;
            // 
            // lblPopName
            // 
            this.lblPopName.ForeColor = System.Drawing.Color.White;
            this.lblPopName.Location = new System.Drawing.Point(96, 20);
            this.lblPopName.Name = "lblPopName";
            this.lblPopName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPopName.Size = new System.Drawing.Size(120, 13);
            this.lblPopName.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 72);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(50, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Job Title:";
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.ForeColor = System.Drawing.Color.White;
            this.lblSpecialization.Location = new System.Drawing.Point(3, 46);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(75, 13);
            this.lblSpecialization.TabIndex = 1;
            this.lblSpecialization.Text = "Specialization:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(3, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1065, 27);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(53, 49);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::ProiectPAW.Properties.Resources.btnExit;
            this.button1.Location = new System.Drawing.Point(1124, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 49);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1189, 699);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grMenu);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GETA v.0.1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button button1;
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
    }
}

