namespace TecladoRaton
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowHidePass = new System.Windows.Forms.Button();
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
            this.label3.Size = new System.Drawing.Size(833, 102);
            this.label3.TabIndex = 23;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(40, 176);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(195, 20);
            this.txtInput.TabIndex = 24;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            this.txtInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyUp);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(441, 176);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(327, 231);
            this.txtLog.TabIndex = 25;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(40, 244);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(195, 20);
            this.txtPassword.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Password";
            // 
            // btnShowHidePass
            // 
            this.btnShowHidePass.Location = new System.Drawing.Point(40, 281);
            this.btnShowHidePass.Name = "btnShowHidePass";
            this.btnShowHidePass.Size = new System.Drawing.Size(171, 23);
            this.btnShowHidePass.TabIndex = 28;
            this.btnShowHidePass.Text = "Mostrar/Ocultar pass";
            this.btnShowHidePass.UseVisualStyleBackColor = true;
            this.btnShowHidePass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowHidePass_MouseDown);
            this.btnShowHidePass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowHidePass_MouseUp);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 620);
            this.Controls.Add(this.btnShowHidePass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label3);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teclado y ratón";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fMain_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fMain_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fMain_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowHidePass;
    }
}

