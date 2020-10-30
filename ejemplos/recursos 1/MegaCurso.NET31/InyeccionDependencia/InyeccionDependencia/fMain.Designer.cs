namespace InyeccionDependencia
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.label3 = new System.Windows.Forms.Label();
            this.selDepartment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTeachers = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDepartamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(744, 102);
            this.label3.TabIndex = 22;
            // 
            // selDepartment
            // 
            this.selDepartment.FormattingEnabled = true;
            this.selDepartment.Location = new System.Drawing.Point(92, 125);
            this.selDepartment.Name = "selDepartment";
            this.selDepartment.Size = new System.Drawing.Size(165, 21);
            this.selDepartment.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Departamento";
            // 
            // lstTeachers
            // 
            this.lstTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName,
            this.colLastName,
            this.colAddress,
            this.colDepartamento});
            this.lstTeachers.Location = new System.Drawing.Point(12, 193);
            this.lstTeachers.Name = "lstTeachers";
            this.lstTeachers.Size = new System.Drawing.Size(720, 405);
            this.lstTeachers.TabIndex = 25;
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
            // colDepartamento
            // 
            this.colDepartamento.Text = "Departamento";
            this.colDepartamento.Width = 150;
            // 
            // colAddress
            // 
            this.colAddress.Text = "Dirección";
            this.colAddress.Width = 202;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(639, 123);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(93, 51);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "Buscar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Texto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(519, 20);
            this.textBox1.TabIndex = 28;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 610);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lstTeachers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selDepartment);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inyección de dependencia y CQRS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstTeachers;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.ColumnHeader colDepartamento;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

