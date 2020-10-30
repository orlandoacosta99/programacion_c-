namespace MegaCurso.NET20
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
            this.btnTest = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblFlag = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSalut = new System.Windows.Forms.Label();
            this.lblFlagExtProject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            resources.ApplyResources(this.btnTest, "btnTest");
            this.btnTest.Name = "btnTest";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblTest
            // 
            resources.ApplyResources(this.lblTest, "lblTest");
            this.lblTest.Name = "lblTest";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.Name = "lblDate";
            // 
            // lblFlag
            // 
            this.lblFlag.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.lblFlag, "lblFlag");
            this.lblFlag.Name = "lblFlag";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lblSalut
            // 
            resources.ApplyResources(this.lblSalut, "lblSalut");
            this.lblSalut.Name = "lblSalut";
            // 
            // lblFlagExtProject
            // 
            this.lblFlagExtProject.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.lblFlagExtProject, "lblFlagExtProject");
            this.lblFlagExtProject.Name = "lblFlagExtProject";
            // 
            // fMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFlagExtProject);
            this.Controls.Add(this.lblSalut);
            this.Controls.Add(this.lblFlag);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblFlag;
        private System.Windows.Forms.Label lblSalut;
        private System.Windows.Forms.Label lblFlagExtProject;
    }
}

