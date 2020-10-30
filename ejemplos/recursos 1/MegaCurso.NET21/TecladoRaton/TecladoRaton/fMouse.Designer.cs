namespace TecladoRaton
{
    partial class fMouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMouse));
            this.label3 = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.TextBox();
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
            this.label3.Size = new System.Drawing.Size(801, 102);
            this.label3.TabIndex = 24;
            // 
            // lblPosition
            // 
            this.lblPosition.BackColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(12, 121);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(162, 23);
            this.lblPosition.TabIndex = 25;
            this.lblPosition.Text = "Posición del ratón";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Location = new System.Drawing.Point(381, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 246);
            this.panel1.TabIndex = 26;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(381, 391);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(394, 231);
            this.txtLog.TabIndex = 27;
            // 
            // fMouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 634);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "fMouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ratón";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fMouse_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fMouse_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fMouse_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLog;
    }
}