namespace Validaciones
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
            this.txtCifDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnExtractGroup = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
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
            this.label3.Size = new System.Drawing.Size(769, 102);
            this.label3.TabIndex = 20;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(38, 144);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(176, 20);
            this.txtInput.TabIndex = 21;
            this.txtInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyUp);
            // 
            // txtCifDni
            // 
            this.txtCifDni.Location = new System.Drawing.Point(38, 238);
            this.txtCifDni.Name = "txtCifDni";
            this.txtCifDni.Size = new System.Drawing.Size(100, 20);
            this.txtCifDni.TabIndex = 22;
            this.txtCifDni.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCifDni_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cif / Nif";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Password strength";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.MistyRose;
            this.txtPassword.Location = new System.Drawing.Point(38, 330);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 25;
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
            // 
            // btnExtractGroup
            // 
            this.btnExtractGroup.Location = new System.Drawing.Point(466, 140);
            this.btnExtractGroup.Name = "btnExtractGroup";
            this.btnExtractGroup.Size = new System.Drawing.Size(121, 23);
            this.btnExtractGroup.TabIndex = 26;
            this.btnExtractGroup.Text = "Extract group";
            this.btnExtractGroup.UseVisualStyleBackColor = true;
            this.btnExtractGroup.Click += new System.EventHandler(this.btnExtractGroup_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(466, 195);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(121, 23);
            this.btnReplace.TabIndex = 27;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 615);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnExtractGroup);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCifDni);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtCifDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnExtractGroup;
        private System.Windows.Forms.Button btnReplace;
    }
}

