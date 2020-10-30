namespace BasesDatos
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
            this.lstStudents = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReadStudents = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnWriteStudent = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
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
            this.label3.Size = new System.Drawing.Size(753, 102);
            this.label3.TabIndex = 22;
            // 
            // lstStudents
            // 
            this.lstStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName,
            this.colLastName,
            this.colAddress});
            this.lstStudents.Location = new System.Drawing.Point(12, 147);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(480, 286);
            this.lstStudents.TabIndex = 23;
            this.lstStudents.UseCompatibleStateImageBehavior = false;
            this.lstStudents.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 131;
            // 
            // colLastName
            // 
            this.colLastName.Text = "Last name";
            this.colLastName.Width = 114;
            // 
            // colAddress
            // 
            this.colAddress.Text = "Address";
            this.colAddress.Width = 145;
            // 
            // btnReadStudents
            // 
            this.btnReadStudents.Location = new System.Drawing.Point(13, 116);
            this.btnReadStudents.Name = "btnReadStudents";
            this.btnReadStudents.Size = new System.Drawing.Size(121, 23);
            this.btnReadStudents.TabIndex = 24;
            this.btnReadStudents.Text = "Read students";
            this.btnReadStudents.UseVisualStyleBackColor = true;
            this.btnReadStudents.Click += new System.EventHandler(this.btnReadStudents_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(24, 479);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 20);
            this.txtName.TabIndex = 25;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(24, 505);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(170, 20);
            this.txtLastName.TabIndex = 26;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(24, 531);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(170, 20);
            this.txtAddress.TabIndex = 27;
            // 
            // btnWriteStudent
            // 
            this.btnWriteStudent.Location = new System.Drawing.Point(24, 566);
            this.btnWriteStudent.Name = "btnWriteStudent";
            this.btnWriteStudent.Size = new System.Drawing.Size(121, 23);
            this.btnWriteStudent.TabIndex = 28;
            this.btnWriteStudent.Text = "Write student";
            this.btnWriteStudent.UseVisualStyleBackColor = true;
            this.btnWriteStudent.Click += new System.EventHandler(this.btnWriteStudent_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(24, 453);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(96, 20);
            this.txtID.TabIndex = 29;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(168, 566);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 23);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update student";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(320, 566);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 23);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 626);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnWriteStudent);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnReadStudents);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bases de datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstStudents;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.Button btnReadStudents;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnWriteStudent;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

