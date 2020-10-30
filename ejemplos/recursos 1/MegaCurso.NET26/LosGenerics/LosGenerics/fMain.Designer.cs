namespace LosGenerics
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
            this.btnTestGenerics = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTypeInfo = new System.Windows.Forms.TextBox();
            this.btnTestActivator = new System.Windows.Forms.Button();
            this.btnTestGenericNew = new System.Windows.Forms.Button();
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
            this.label3.Size = new System.Drawing.Size(803, 102);
            this.label3.TabIndex = 21;
            // 
            // btnTestGenerics
            // 
            this.btnTestGenerics.Location = new System.Drawing.Point(67, 184);
            this.btnTestGenerics.Name = "btnTestGenerics";
            this.btnTestGenerics.Size = new System.Drawing.Size(163, 23);
            this.btnTestGenerics.TabIndex = 22;
            this.btnTestGenerics.Text = "Test generics";
            this.btnTestGenerics.UseVisualStyleBackColor = true;
            this.btnTestGenerics.Click += new System.EventHandler(this.btnTestGenerics_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Test reflection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTypeInfo
            // 
            this.txtTypeInfo.Location = new System.Drawing.Point(300, 184);
            this.txtTypeInfo.Multiline = true;
            this.txtTypeInfo.Name = "txtTypeInfo";
            this.txtTypeInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTypeInfo.Size = new System.Drawing.Size(332, 263);
            this.txtTypeInfo.TabIndex = 24;
            // 
            // btnTestActivator
            // 
            this.btnTestActivator.Location = new System.Drawing.Point(67, 313);
            this.btnTestActivator.Name = "btnTestActivator";
            this.btnTestActivator.Size = new System.Drawing.Size(163, 23);
            this.btnTestActivator.TabIndex = 25;
            this.btnTestActivator.Text = "Test activator";
            this.btnTestActivator.UseVisualStyleBackColor = true;
            this.btnTestActivator.Click += new System.EventHandler(this.btnTestActivator_Click);
            // 
            // btnTestGenericNew
            // 
            this.btnTestGenericNew.Location = new System.Drawing.Point(67, 393);
            this.btnTestGenericNew.Name = "btnTestGenericNew";
            this.btnTestGenericNew.Size = new System.Drawing.Size(163, 23);
            this.btnTestGenericNew.TabIndex = 26;
            this.btnTestGenericNew.Text = "Test generic new";
            this.btnTestGenericNew.UseVisualStyleBackColor = true;
            this.btnTestGenericNew.Click += new System.EventHandler(this.btnTestGenericNew_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 621);
            this.Controls.Add(this.btnTestGenericNew);
            this.Controls.Add(this.btnTestActivator);
            this.Controls.Add(this.txtTypeInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTestGenerics);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clase 26. Introducción a reflection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTestGenerics;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTypeInfo;
        private System.Windows.Forms.Button btnTestActivator;
        private System.Windows.Forms.Button btnTestGenericNew;
    }
}

