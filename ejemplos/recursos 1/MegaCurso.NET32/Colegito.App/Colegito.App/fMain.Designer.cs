namespace Colegito.App
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
            this.mainToolbar = new System.Windows.Forms.ToolStrip();
            this.tlbTeachers = new System.Windows.Forms.ToolStripButton();
            this.tlbStudents = new System.Windows.Forms.ToolStripButton();
            this.tlbDepartments = new System.Windows.Forms.ToolStripButton();
            this.tlbCourses = new System.Windows.Forms.ToolStripButton();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolbar.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolbar
            // 
            this.mainToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlbTeachers,
            this.tlbStudents,
            this.tlbDepartments,
            this.tlbCourses});
            this.mainToolbar.Location = new System.Drawing.Point(0, 24);
            this.mainToolbar.Name = "mainToolbar";
            this.mainToolbar.Size = new System.Drawing.Size(757, 25);
            this.mainToolbar.TabIndex = 1;
            this.mainToolbar.Text = "toolStrip1";
            // 
            // tlbTeachers
            // 
            this.tlbTeachers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlbTeachers.Image = ((System.Drawing.Image)(resources.GetObject("tlbTeachers.Image")));
            this.tlbTeachers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbTeachers.Name = "tlbTeachers";
            this.tlbTeachers.Size = new System.Drawing.Size(66, 22);
            this.tlbTeachers.Text = "Profesores";
            this.tlbTeachers.Click += new System.EventHandler(this.tlbTeachers_Click);
            // 
            // tlbStudents
            // 
            this.tlbStudents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlbStudents.Image = ((System.Drawing.Image)(resources.GetObject("tlbStudents.Image")));
            this.tlbStudents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbStudents.Name = "tlbStudents";
            this.tlbStudents.Size = new System.Drawing.Size(71, 22);
            this.tlbStudents.Text = "Estudiantes";
            this.tlbStudents.Click += new System.EventHandler(this.tlbStudents_Click);
            // 
            // tlbDepartments
            // 
            this.tlbDepartments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlbDepartments.Image = ((System.Drawing.Image)(resources.GetObject("tlbDepartments.Image")));
            this.tlbDepartments.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbDepartments.Name = "tlbDepartments";
            this.tlbDepartments.Size = new System.Drawing.Size(92, 22);
            this.tlbDepartments.Text = "Departamentos";
            this.tlbDepartments.Click += new System.EventHandler(this.tlbDepartments_Click);
            // 
            // tlbCourses
            // 
            this.tlbCourses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tlbCourses.Image = ((System.Drawing.Image)(resources.GetObject("tlbCourses.Image")));
            this.tlbCourses.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbCourses.Name = "tlbCourses";
            this.tlbCourses.Size = new System.Drawing.Size(73, 22);
            this.tlbCourses.Text = "Asignaturas";
            this.tlbCourses.Click += new System.EventHandler(this.tlbCourses_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(757, 24);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(60, 20);
            this.mnuFile.Text = "Archivo";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(96, 22);
            this.mnuExit.Text = "Salir";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 634);
            this.Controls.Add(this.mainToolbar);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colegito App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainToolbar.ResumeLayout(false);
            this.mainToolbar.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainToolbar;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripButton tlbTeachers;
        private System.Windows.Forms.ToolStripButton tlbStudents;
        private System.Windows.Forms.ToolStripButton tlbDepartments;
        private System.Windows.Forms.ToolStripButton tlbCourses;
    }
}

