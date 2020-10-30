namespace MultiThreading
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
            this.btnTestCounter = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.lblThread = new System.Windows.Forms.Label();
            this.btnTestThread = new System.Windows.Forms.Button();
            this.btnStopThread = new System.Windows.Forms.Button();
            this.btnStopAsync = new System.Windows.Forms.Button();
            this.btnTestAsync = new System.Windows.Forms.Button();
            this.lblCounterAsync = new System.Windows.Forms.Label();
            this.btnStopFileAsync = new System.Windows.Forms.Button();
            this.btnFileAsync = new System.Windows.Forms.Button();
            this.lblFileAsync = new System.Windows.Forms.Label();
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
            this.label3.Size = new System.Drawing.Size(760, 102);
            this.label3.TabIndex = 22;
            // 
            // btnTestCounter
            // 
            this.btnTestCounter.Location = new System.Drawing.Point(39, 186);
            this.btnTestCounter.Name = "btnTestCounter";
            this.btnTestCounter.Size = new System.Drawing.Size(121, 23);
            this.btnTestCounter.TabIndex = 23;
            this.btnTestCounter.Text = "Test contador";
            this.btnTestCounter.UseVisualStyleBackColor = true;
            this.btnTestCounter.Click += new System.EventHandler(this.btnTestCounter_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.BackColor = System.Drawing.Color.White;
            this.lblCounter.Location = new System.Drawing.Point(36, 157);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(157, 26);
            this.lblCounter.TabIndex = 24;
            this.lblCounter.Text = "label1";
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThread
            // 
            this.lblThread.BackColor = System.Drawing.Color.White;
            this.lblThread.Location = new System.Drawing.Point(259, 157);
            this.lblThread.Name = "lblThread";
            this.lblThread.Size = new System.Drawing.Size(157, 26);
            this.lblThread.TabIndex = 25;
            this.lblThread.Text = "label1";
            this.lblThread.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTestThread
            // 
            this.btnTestThread.Location = new System.Drawing.Point(262, 186);
            this.btnTestThread.Name = "btnTestThread";
            this.btnTestThread.Size = new System.Drawing.Size(121, 23);
            this.btnTestThread.TabIndex = 26;
            this.btnTestThread.Text = "Test thread";
            this.btnTestThread.UseVisualStyleBackColor = true;
            this.btnTestThread.Click += new System.EventHandler(this.btnTestThread_Click);
            // 
            // btnStopThread
            // 
            this.btnStopThread.Location = new System.Drawing.Point(262, 225);
            this.btnStopThread.Name = "btnStopThread";
            this.btnStopThread.Size = new System.Drawing.Size(121, 23);
            this.btnStopThread.TabIndex = 27;
            this.btnStopThread.Text = "Parar thread";
            this.btnStopThread.UseVisualStyleBackColor = true;
            this.btnStopThread.Click += new System.EventHandler(this.btnStopThread_Click);
            // 
            // btnStopAsync
            // 
            this.btnStopAsync.Location = new System.Drawing.Point(506, 225);
            this.btnStopAsync.Name = "btnStopAsync";
            this.btnStopAsync.Size = new System.Drawing.Size(121, 23);
            this.btnStopAsync.TabIndex = 30;
            this.btnStopAsync.Text = "Parar async";
            this.btnStopAsync.UseVisualStyleBackColor = true;
            // 
            // btnTestAsync
            // 
            this.btnTestAsync.Location = new System.Drawing.Point(506, 186);
            this.btnTestAsync.Name = "btnTestAsync";
            this.btnTestAsync.Size = new System.Drawing.Size(121, 23);
            this.btnTestAsync.TabIndex = 29;
            this.btnTestAsync.Text = "Test async";
            this.btnTestAsync.UseVisualStyleBackColor = true;
            this.btnTestAsync.Click += new System.EventHandler(this.btnTestAsync_Click);
            // 
            // lblCounterAsync
            // 
            this.lblCounterAsync.BackColor = System.Drawing.Color.White;
            this.lblCounterAsync.Location = new System.Drawing.Point(503, 157);
            this.lblCounterAsync.Name = "lblCounterAsync";
            this.lblCounterAsync.Size = new System.Drawing.Size(157, 26);
            this.lblCounterAsync.TabIndex = 28;
            this.lblCounterAsync.Text = "label1";
            this.lblCounterAsync.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStopFileAsync
            // 
            this.btnStopFileAsync.Location = new System.Drawing.Point(262, 415);
            this.btnStopFileAsync.Name = "btnStopFileAsync";
            this.btnStopFileAsync.Size = new System.Drawing.Size(121, 23);
            this.btnStopFileAsync.TabIndex = 33;
            this.btnStopFileAsync.Text = "Parar async";
            this.btnStopFileAsync.UseVisualStyleBackColor = true;
            this.btnStopFileAsync.Click += new System.EventHandler(this.btnStopFileAsync_Click);
            // 
            // btnFileAsync
            // 
            this.btnFileAsync.Location = new System.Drawing.Point(262, 376);
            this.btnFileAsync.Name = "btnFileAsync";
            this.btnFileAsync.Size = new System.Drawing.Size(121, 23);
            this.btnFileAsync.TabIndex = 32;
            this.btnFileAsync.Text = "Test async";
            this.btnFileAsync.UseVisualStyleBackColor = true;
            this.btnFileAsync.Click += new System.EventHandler(this.btnFileAsync_Click);
            // 
            // lblFileAsync
            // 
            this.lblFileAsync.BackColor = System.Drawing.Color.White;
            this.lblFileAsync.Location = new System.Drawing.Point(259, 347);
            this.lblFileAsync.Name = "lblFileAsync";
            this.lblFileAsync.Size = new System.Drawing.Size(157, 26);
            this.lblFileAsync.TabIndex = 31;
            this.lblFileAsync.Text = "label1";
            this.lblFileAsync.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 621);
            this.Controls.Add(this.btnStopFileAsync);
            this.Controls.Add(this.btnFileAsync);
            this.Controls.Add(this.lblFileAsync);
            this.Controls.Add(this.btnStopAsync);
            this.Controls.Add(this.btnTestAsync);
            this.Controls.Add(this.lblCounterAsync);
            this.Controls.Add(this.btnStopThread);
            this.Controls.Add(this.btnTestThread);
            this.Controls.Add(this.lblThread);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnTestCounter);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "33. MultiThreading";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTestCounter;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Label lblThread;
        private System.Windows.Forms.Button btnTestThread;
        private System.Windows.Forms.Button btnStopThread;
        private System.Windows.Forms.Button btnStopAsync;
        private System.Windows.Forms.Button btnTestAsync;
        private System.Windows.Forms.Label lblCounterAsync;
        private System.Windows.Forms.Button btnStopFileAsync;
        private System.Windows.Forms.Button btnFileAsync;
        private System.Windows.Forms.Label lblFileAsync;
    }
}

