namespace Interfaces
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
            this.btnTestInterface = new System.Windows.Forms.Button();
            this.btnTestDynamic = new System.Windows.Forms.Button();
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
            this.label3.Size = new System.Drawing.Size(723, 102);
            this.label3.TabIndex = 20;
            // 
            // btnTestInterface
            // 
            this.btnTestInterface.Location = new System.Drawing.Point(42, 148);
            this.btnTestInterface.Name = "btnTestInterface";
            this.btnTestInterface.Size = new System.Drawing.Size(149, 23);
            this.btnTestInterface.TabIndex = 21;
            this.btnTestInterface.Text = "Test interface";
            this.btnTestInterface.UseVisualStyleBackColor = true;
            this.btnTestInterface.Click += new System.EventHandler(this.btnTestInterface_Click);
            // 
            // btnTestDynamic
            // 
            this.btnTestDynamic.Location = new System.Drawing.Point(42, 205);
            this.btnTestDynamic.Name = "btnTestDynamic";
            this.btnTestDynamic.Size = new System.Drawing.Size(149, 23);
            this.btnTestDynamic.TabIndex = 22;
            this.btnTestDynamic.Text = "Test dynamic";
            this.btnTestDynamic.UseVisualStyleBackColor = true;
            this.btnTestDynamic.Click += new System.EventHandler(this.btnTestDynamic_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 530);
            this.Controls.Add(this.btnTestDynamic);
            this.Controls.Add(this.btnTestInterface);
            this.Controls.Add(this.label3);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaces";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTestInterface;
        private System.Windows.Forms.Button btnTestDynamic;
    }
}

