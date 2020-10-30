namespace ArchivosImagenesParte1
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnReadAllFile = new System.Windows.Forms.Button();
            this.btnReadFolders = new System.Windows.Forms.Button();
            this.btnGetFileInfo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Image = global::ArchivosImagenesParte1.Properties.Resources.los_megacursos;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(949, 102);
            this.label3.TabIndex = 16;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(35, 179);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 17;
            this.btnRead.Text = "Leer";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(129, 179);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 18;
            this.btnWrite.Text = "Escribir";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(35, 233);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(889, 285);
            this.txtResult.TabIndex = 19;
            // 
            // btnReadAllFile
            // 
            this.btnReadAllFile.Location = new System.Drawing.Point(35, 124);
            this.btnReadAllFile.Name = "btnReadAllFile";
            this.btnReadAllFile.Size = new System.Drawing.Size(137, 23);
            this.btnReadAllFile.TabIndex = 20;
            this.btnReadAllFile.Text = "Leer todo el contenido";
            this.btnReadAllFile.UseVisualStyleBackColor = true;
            this.btnReadAllFile.Click += new System.EventHandler(this.btnReadAllFile_Click);
            // 
            // btnReadFolders
            // 
            this.btnReadFolders.Location = new System.Drawing.Point(331, 124);
            this.btnReadFolders.Name = "btnReadFolders";
            this.btnReadFolders.Size = new System.Drawing.Size(137, 23);
            this.btnReadFolders.TabIndex = 21;
            this.btnReadFolders.Text = "Listar carpetas";
            this.btnReadFolders.UseVisualStyleBackColor = true;
            this.btnReadFolders.Click += new System.EventHandler(this.btnReadFolders_Click);
            // 
            // btnGetFileInfo
            // 
            this.btnGetFileInfo.Location = new System.Drawing.Point(331, 179);
            this.btnGetFileInfo.Name = "btnGetFileInfo";
            this.btnGetFileInfo.Size = new System.Drawing.Size(216, 23);
            this.btnGetFileInfo.TabIndex = 22;
            this.btnGetFileInfo.Text = "Obtener información del archivo";
            this.btnGetFileInfo.UseVisualStyleBackColor = true;
            this.btnGetFileInfo.Click += new System.EventHandler(this.btnGetFileInfo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(225, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 713);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnGetFileInfo);
            this.Controls.Add(this.btnReadFolders);
            this.Controls.Add(this.btnReadAllFile);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.Text = "Archivos e imágenes parte 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnReadAllFile;
        private System.Windows.Forms.Button btnReadFolders;
        private System.Windows.Forms.Button btnGetFileInfo;
        private System.Windows.Forms.Button btnDelete;
    }
}

