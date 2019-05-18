namespace ProiectPAW
{
    partial class EditUser
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
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.ctxtTitle = new System.Windows.Forms.ComboBox();
            this.ctxtSpec = new System.Windows.Forms.ComboBox();
            this.ctxtType = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.ctxtTitle);
            this.gbEdit.Controls.Add(this.ctxtSpec);
            this.gbEdit.Controls.Add(this.ctxtType);
            this.gbEdit.Controls.Add(this.txtLastName);
            this.gbEdit.Controls.Add(this.txtFirstName);
            this.gbEdit.Controls.Add(this.txtUser);
            this.gbEdit.Controls.Add(this.lblType);
            this.gbEdit.Controls.Add(this.lblTitle);
            this.gbEdit.Controls.Add(this.lblSpecialization);
            this.gbEdit.Controls.Add(this.lblLastName);
            this.gbEdit.Controls.Add(this.lblFirstName);
            this.gbEdit.Controls.Add(this.lblUsername);
            this.gbEdit.Location = new System.Drawing.Point(6, 7);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(248, 286);
            this.gbEdit.TabIndex = 0;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Edit User Details";
            // 
            // ctxtTitle
            // 
            this.ctxtTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctxtTitle.FormattingEnabled = true;
            this.ctxtTitle.Items.AddRange(new object[] {
            "Rezident",
            "Specialist",
            "Primar"});
            this.ctxtTitle.Location = new System.Drawing.Point(107, 181);
            this.ctxtTitle.Name = "ctxtTitle";
            this.ctxtTitle.Size = new System.Drawing.Size(100, 21);
            this.ctxtTitle.TabIndex = 12;
            // 
            // ctxtSpec
            // 
            this.ctxtSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctxtSpec.FormattingEnabled = true;
            this.ctxtSpec.Items.AddRange(new object[] {
            "Alergologie si imunologie clinica",
            "Anatomie patologica",
            "Anestezie si terapie intensiva",
            "Boli infectioase",
            "Cardiologie",
            "Chirurgie cardiovasculara",
            "Chirurgie dento alveolara",
            "Chirurgie generala",
            "Chirurgie orala si maxilo faciala",
            "Chirurgie pediatrica",
            "Chirurgie plastica estetica si microchirurgie reconstructiva",
            "Chirurgie toracica",
            "Chirurgie vasculara",
            "Dermatovenerologie",
            "Diabet zaharat si boli metabolice",
            "Endocrinologie",
            "Endodontie",
            "Epidemiologie",
            "Expertiza medicala a capacitatii de munca",
            "Farmacie clinica",
            "Farmacologie clinica",
            "Gastroenterologie",
            "Genetica medicala",
            "Geriatrie si gerontologie",
            "Hematologie",
            "Igiena",
            "Laborator farmaceutic",
            "Medicina de familie",
            "Medicina de laborator",
            "Medicina de urgenta",
            "Medicina de urgenta 2013",
            "Medicina interna",
            "Medicina legala",
            "Medicina muncii",
            "Medicina nucleara",
            "Medicina sportiva",
            "Nefrologie",
            "Neonatologie",
            "Neurochirurgie",
            "Neurologie",
            "Neurologie pediatrica",
            "Obstetrica ginecologie",
            "Oftalmologie",
            "Oncologie medicala",
            "Ortodontie si ortopedie dento faciala",
            "Ortopedie pediatrica",
            "Ortopedie si traumatologie",
            "Otorinolaringologie",
            "Parodontologie",
            "Pediatrie",
            "Pneumologie",
            "Protetica dentara",
            "Psihiatrie",
            "Psihiatrie pediatrica",
            "Radiologie imagistica medicala",
            "Radioterapie",
            "Reabilitare medicala",
            "Reumatologie",
            "Sanatate publica si management",
            "Urologie"});
            this.ctxtSpec.Location = new System.Drawing.Point(107, 151);
            this.ctxtSpec.Name = "ctxtSpec";
            this.ctxtSpec.Size = new System.Drawing.Size(100, 21);
            this.ctxtSpec.TabIndex = 5;
            // 
            // ctxtType
            // 
            this.ctxtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctxtType.FormattingEnabled = true;
            this.ctxtType.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.ctxtType.Location = new System.Drawing.Point(107, 211);
            this.ctxtType.Name = "ctxtType";
            this.ctxtType.Size = new System.Drawing.Size(100, 21);
            this.ctxtType.TabIndex = 11;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(107, 121);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 8;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(107, 91);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 7;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(107, 61);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 6;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(29, 214);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(62, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "User Type: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(29, 184);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(53, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Job Title: ";
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.Location = new System.Drawing.Point(29, 154);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(72, 13);
            this.lblSpecialization.TabIndex = 3;
            this.lblSpecialization.Text = "Specialization";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(29, 124);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name: ";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(29, 94);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(63, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name: ";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(29, 64);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 317);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(133, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Back";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 355);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbEdit);
            this.MaximizeBox = false;
            this.Name = "EditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditUser";
            this.Load += new System.EventHandler(this.EditUser_Load);
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.ComboBox ctxtType;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox ctxtSpec;
        private System.Windows.Forms.ComboBox ctxtTitle;
    }
}