namespace Colegito.App
{
    partial class fTeachers
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
            this.lstTeachers = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDepartamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstTeachers
            // 
            this.lstTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName,
            this.colLastName,
            this.colAddress,
            this.colDepartamento});
            this.lstTeachers.Location = new System.Drawing.Point(12, 114);
            this.lstTeachers.Name = "lstTeachers";
            this.lstTeachers.Size = new System.Drawing.Size(720, 405);
            this.lstTeachers.TabIndex = 26;
            this.lstTeachers.UseCompatibleStateImageBehavior = false;
            this.lstTeachers.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            // 
            // colName
            // 
            this.colName.Text = "Nombre";
            this.colName.Width = 121;
            // 
            // colLastName
            // 
            this.colLastName.Text = "Apellidos";
            this.colLastName.Width = 140;
            // 
            // colAddress
            // 
            this.colAddress.Text = "Dirección";
            this.colAddress.Width = 202;
            // 
            // colDepartamento
            // 
            this.colDepartamento.Text = "Departamento";
            this.colDepartamento.Width = 150;
            // 
            // fTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 532);
            this.Controls.Add(this.lstTeachers);
            this.Name = "fTeachers";
            this.Text = "Profesores";
            this.Activated += new System.EventHandler(this.fTeachers_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstTeachers;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.ColumnHeader colDepartamento;
    }
}