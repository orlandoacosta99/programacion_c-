namespace MegaCurso.NET19
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.myTmr = new System.Windows.Forms.Timer(this.components);
            this.btnEnableTimer = new System.Windows.Forms.Button();
            this.btnTimerThread = new System.Windows.Forms.Button();
            this.btnParse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Image = global::MegaCurso.NET19.Properties.Resources.los_megacursos;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(823, 102);
            this.label3.TabIndex = 17;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(25, 139);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(403, 20);
            this.txtResult.TabIndex = 18;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(25, 197);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 23);
            this.btnAction.TabIndex = 19;
            this.btnAction.Text = "Test";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // myTmr
            // 
            this.myTmr.Interval = 1000;
            this.myTmr.Tick += new System.EventHandler(this.myTmr_Tick);
            // 
            // btnEnableTimer
            // 
            this.btnEnableTimer.Location = new System.Drawing.Point(25, 253);
            this.btnEnableTimer.Name = "btnEnableTimer";
            this.btnEnableTimer.Size = new System.Drawing.Size(142, 23);
            this.btnEnableTimer.TabIndex = 20;
            this.btnEnableTimer.Text = "Activate timer";
            this.btnEnableTimer.UseVisualStyleBackColor = true;
            this.btnEnableTimer.Click += new System.EventHandler(this.btnEnableTimer_Click);
            // 
            // btnTimerThread
            // 
            this.btnTimerThread.Location = new System.Drawing.Point(25, 317);
            this.btnTimerThread.Name = "btnTimerThread";
            this.btnTimerThread.Size = new System.Drawing.Size(142, 23);
            this.btnTimerThread.TabIndex = 21;
            this.btnTimerThread.Text = "Timer thread";
            this.btnTimerThread.UseVisualStyleBackColor = true;
            this.btnTimerThread.Click += new System.EventHandler(this.btnTimerThread_Click);
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(353, 197);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 23);
            this.btnParse.TabIndex = 22;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 611);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.btnTimerThread);
            this.Controls.Add(this.btnEnableTimer);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaCurso.NET19 - El tiempo sobre todas las cosas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Timer myTmr;
        private System.Windows.Forms.Button btnEnableTimer;
        private System.Windows.Forms.Button btnTimerThread;
        private System.Windows.Forms.Button btnParse;
    }
}

