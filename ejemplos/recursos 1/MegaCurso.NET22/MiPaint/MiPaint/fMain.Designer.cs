namespace MiPaint
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
            this.pctCanvas = new System.Windows.Forms.PictureBox();
            this.colorDlg = new System.Windows.Forms.ColorDialog();
            this.lblForeColor = new System.Windows.Forms.Label();
            this.lblBackColor = new System.Windows.Forms.Label();
            this.btnFreePath = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctCanvas)).BeginInit();
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
            this.label3.Size = new System.Drawing.Size(818, 102);
            this.label3.TabIndex = 23;
            // 
            // pctCanvas
            // 
            this.pctCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctCanvas.Location = new System.Drawing.Point(12, 155);
            this.pctCanvas.Name = "pctCanvas";
            this.pctCanvas.Size = new System.Drawing.Size(794, 482);
            this.pctCanvas.TabIndex = 24;
            this.pctCanvas.TabStop = false;
            this.pctCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pctCanvas_Paint);
            this.pctCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctCanvas_MouseDown);
            this.pctCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctCanvas_MouseMove);
            this.pctCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctCanvas_MouseUp);
            // 
            // lblForeColor
            // 
            this.lblForeColor.BackColor = System.Drawing.Color.Black;
            this.lblForeColor.Location = new System.Drawing.Point(38, 122);
            this.lblForeColor.Name = "lblForeColor";
            this.lblForeColor.Size = new System.Drawing.Size(33, 22);
            this.lblForeColor.TabIndex = 25;
            this.lblForeColor.Click += new System.EventHandler(this.lblForeColor_Click);
            // 
            // lblBackColor
            // 
            this.lblBackColor.BackColor = System.Drawing.Color.White;
            this.lblBackColor.Location = new System.Drawing.Point(15, 111);
            this.lblBackColor.Name = "lblBackColor";
            this.lblBackColor.Size = new System.Drawing.Size(33, 22);
            this.lblBackColor.TabIndex = 26;
            // 
            // btnFreePath
            // 
            this.btnFreePath.Location = new System.Drawing.Point(158, 117);
            this.btnFreePath.Name = "btnFreePath";
            this.btnFreePath.Size = new System.Drawing.Size(75, 23);
            this.btnFreePath.TabIndex = 27;
            this.btnFreePath.Text = "Path";
            this.btnFreePath.UseVisualStyleBackColor = true;
            this.btnFreePath.Click += new System.EventHandler(this.btnFreePath_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(252, 117);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(75, 23);
            this.btnRectangle.TabIndex = 28;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 649);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnFreePath);
            this.Controls.Add(this.lblForeColor);
            this.Controls.Add(this.lblBackColor);
            this.Controls.Add(this.pctCanvas);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi pequeño Paint";
            ((System.ComponentModel.ISupportInitialize)(this.pctCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pctCanvas;
        private System.Windows.Forms.ColorDialog colorDlg;
        private System.Windows.Forms.Label lblForeColor;
        private System.Windows.Forms.Label lblBackColor;
        private System.Windows.Forms.Button btnFreePath;
        private System.Windows.Forms.Button btnRectangle;
    }
}

