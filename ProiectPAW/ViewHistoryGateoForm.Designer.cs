namespace ProiectPAW
{
    partial class ViewHistoryGateoForm
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
            this.lvGateo = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvGateo
            // 
            this.lvGateo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.lvGateo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvGateo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.lvGateo.FullRowSelect = true;
            this.lvGateo.GridLines = true;
            this.lvGateo.HideSelection = false;
            this.lvGateo.Location = new System.Drawing.Point(12, 12);
            this.lvGateo.MultiSelect = false;
            this.lvGateo.Name = "lvGateo";
            this.lvGateo.Size = new System.Drawing.Size(856, 360);
            this.lvGateo.TabIndex = 5;
            this.lvGateo.TileSize = new System.Drawing.Size(188, 30);
            this.lvGateo.UseCompatibleStateImageBehavior = false;
            this.lvGateo.View = System.Windows.Forms.View.Details;
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
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 378);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 38);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewHistoryGateoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(881, 428);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lvGateo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewHistoryGateoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewHistoryGateoForm";
            this.Load += new System.EventHandler(this.ViewHistoryGateoForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewHistoryGateoForm_Paint_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvGateo;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnBack;
    }
}