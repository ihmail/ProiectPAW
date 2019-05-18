namespace ProiectPAW
{
    partial class AddUser
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
            this.btnCheckAval = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grAdd = new System.Windows.Forms.GroupBox();
            this.ctxtTitle = new System.Windows.Forms.ComboBox();
            this.ctxtSpec = new System.Windows.Forms.ComboBox();
            this.grAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctxtType
            // 
            this.ctxtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctxtType.FormattingEnabled = true;
            this.ctxtType.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.ctxtType.Location = new System.Drawing.Point(123, 200);
            this.ctxtType.Name = "ctxtType";
            this.ctxtType.Size = new System.Drawing.Size(100, 21);
            this.ctxtType.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(123, 110);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(123, 80);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(123, 50);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 0;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(45, 203);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(62, 13);
            this.lblType.TabIndex = 17;
            this.lblType.Text = "User Type: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(45, 173);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(53, 13);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Job Title: ";
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.Location = new System.Drawing.Point(45, 143);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(72, 13);
            this.lblSpecialization.TabIndex = 15;
            this.lblSpecialization.Text = "Specialization";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(45, 113);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 13);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name: ";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(45, 83);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(63, 13);
            this.lblFirstName.TabIndex = 13;
            this.lblFirstName.Text = "First Name: ";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(33, 41);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username";
            // 
            // btnCheckAval
            // 
            this.btnCheckAval.Location = new System.Drawing.Point(238, 48);
            this.btnCheckAval.Name = "btnCheckAval";
            this.btnCheckAval.Size = new System.Drawing.Size(115, 23);
            this.btnCheckAval.TabIndex = 1;
            this.btnCheckAval.Text = "Check availability";
            this.btnCheckAval.UseVisualStyleBackColor = true;
            this.btnCheckAval.Click += new System.EventHandler(this.btnCheckAval_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(238, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add user";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(238, 198);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grAdd
            // 
            this.grAdd.Controls.Add(this.lblUsername);
            this.grAdd.Location = new System.Drawing.Point(13, 12);
            this.grAdd.Name = "grAdd";
            this.grAdd.Size = new System.Drawing.Size(386, 239);
            this.grAdd.TabIndex = 27;
            this.grAdd.TabStop = false;
            this.grAdd.Text = "User details";
            // 
            // ctxtTitle
            // 
            this.ctxtTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctxtTitle.FormattingEnabled = true;
            this.ctxtTitle.Items.AddRange(new object[] {
            "Rezident",
            "Specialist",
            "Primar"});
            this.ctxtTitle.Location = new System.Drawing.Point(123, 170);
            this.ctxtTitle.Name = "ctxtTitle";
            this.ctxtTitle.Size = new System.Drawing.Size(100, 21);
            this.ctxtTitle.TabIndex = 5;
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
            this.ctxtSpec.Location = new System.Drawing.Point(123, 140);
            this.ctxtSpec.Name = "ctxtSpec";
            this.ctxtSpec.Size = new System.Drawing.Size(100, 21);
            this.ctxtSpec.TabIndex = 4;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 264);
            this.Controls.Add(this.ctxtTitle);
            this.Controls.Add(this.ctxtSpec);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCheckAval);
            this.Controls.Add(this.ctxtType);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSpecialization);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.grAdd);
            this.MaximizeBox = false;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.grAdd.ResumeLayout(false);
            this.grAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnCheckAval;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grAdd;
        private System.Windows.Forms.ComboBox ctxtTitle;
        private System.Windows.Forms.ComboBox ctxtSpec;
    }
}