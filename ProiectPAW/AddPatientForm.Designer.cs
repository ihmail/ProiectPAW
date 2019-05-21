namespace ProiectPAW
{
    partial class AddPatientForm
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
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtAHC = new System.Windows.Forms.TextBox();
            this.txtAPF = new System.Windows.Forms.TextBox();
            this.txtAPP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblPName = new System.Windows.Forms.Label();
            this.txtCnp = new System.Windows.Forms.TextBox();
            this.lblPDCnp = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastN = new System.Windows.Forms.Label();
            this.ctxtSex = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtpBirth
            // 
            this.dtpBirth.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.dtpBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Location = new System.Drawing.Point(215, 88);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(101, 20);
            this.dtpBirth.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(518, 460);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 38);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add patient";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(19, 460);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 38);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtAHC
            // 
            this.txtAHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAHC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtAHC.Location = new System.Drawing.Point(19, 363);
            this.txtAHC.Multiline = true;
            this.txtAHC.Name = "txtAHC";
            this.txtAHC.Size = new System.Drawing.Size(648, 90);
            this.txtAHC.TabIndex = 6;
            // 
            // txtAPF
            // 
            this.txtAPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtAPF.Location = new System.Drawing.Point(19, 254);
            this.txtAPF.Multiline = true;
            this.txtAPF.Name = "txtAPF";
            this.txtAPF.Size = new System.Drawing.Size(648, 90);
            this.txtAPF.TabIndex = 5;
            // 
            // txtAPP
            // 
            this.txtAPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtAPP.Location = new System.Drawing.Point(18, 145);
            this.txtAPP.Multiline = true;
            this.txtAPP.Name = "txtAPP";
            this.txtAPP.Size = new System.Drawing.Size(648, 90);
            this.txtAPP.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.label6.Location = new System.Drawing.Point(16, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Antecedente heredo-colaterale: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.label5.Location = new System.Drawing.Point(16, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Antecedente personale fiziologice:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.label4.Location = new System.Drawing.Point(16, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Antecedente personale patologice:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.label3.Location = new System.Drawing.Point(149, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Birth date: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Gender: ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtFirstName.Location = new System.Drawing.Point(91, 53);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(115, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.lblPName.Location = new System.Drawing.Point(16, 56);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(69, 13);
            this.lblPName.TabIndex = 39;
            this.lblPName.Text = "First name:";
            // 
            // txtCnp
            // 
            this.txtCnp.Enabled = false;
            this.txtCnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtCnp.Location = new System.Drawing.Point(62, 15);
            this.txtCnp.Name = "txtCnp";
            this.txtCnp.Size = new System.Drawing.Size(101, 20);
            this.txtCnp.TabIndex = 38;
            // 
            // lblPDCnp
            // 
            this.lblPDCnp.AutoSize = true;
            this.lblPDCnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDCnp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.lblPDCnp.Location = new System.Drawing.Point(16, 18);
            this.lblPDCnp.Name = "lblPDCnp";
            this.lblPDCnp.Size = new System.Drawing.Size(40, 13);
            this.lblPDCnp.TabIndex = 37;
            this.lblPDCnp.Text = "CNP: ";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.txtLastName.Location = new System.Drawing.Point(287, 53);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(115, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // lblLastN
            // 
            this.lblLastN.AutoSize = true;
            this.lblLastN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.lblLastN.Location = new System.Drawing.Point(212, 56);
            this.lblLastN.Name = "lblLastN";
            this.lblLastN.Size = new System.Drawing.Size(69, 13);
            this.lblLastN.TabIndex = 57;
            this.lblLastN.Text = "Last name:";
            // 
            // ctxtSex
            // 
            this.ctxtSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctxtSex.FormattingEnabled = true;
            this.ctxtSex.Items.AddRange(new object[] {
            "male",
            "female"});
            this.ctxtSex.Location = new System.Drawing.Point(67, 87);
            this.ctxtSex.Name = "ctxtSex";
            this.ctxtSex.Size = new System.Drawing.Size(69, 21);
            this.ctxtSex.TabIndex = 2;
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(689, 516);
            this.Controls.Add(this.ctxtSex);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastN);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtAHC);
            this.Controls.Add(this.txtAPF);
            this.Controls.Add(this.txtAPP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblPName);
            this.Controls.Add(this.txtCnp);
            this.Controls.Add(this.lblPDCnp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPatientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtAHC;
        private System.Windows.Forms.TextBox txtAPF;
        private System.Windows.Forms.TextBox txtAPP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.TextBox txtCnp;
        private System.Windows.Forms.Label lblPDCnp;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastN;
        private System.Windows.Forms.ComboBox ctxtSex;
    }
}