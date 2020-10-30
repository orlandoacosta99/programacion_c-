namespace FicherosEstructurados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.lblForeColor = new System.Windows.Forms.Label();
            this.btnSelectForeColor = new System.Windows.Forms.Button();
            this.lblForeColorValue = new System.Windows.Forms.Label();
            this.chkUseHardwareAcceleration = new System.Windows.Forms.CheckBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.lblFolderName = new System.Windows.Forms.Label();
            this.lblFolder = new System.Windows.Forms.Label();
            this.tabPaint = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.selDateFormat = new System.Windows.Forms.ComboBox();
            this.chkShowStatusBar = new System.Windows.Forms.CheckBox();
            this.chkShowCoordinates = new System.Windows.Forms.CheckBox();
            this.lblUnits = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.NumericUpDown();
            this.lblSelZoom = new System.Windows.Forms.Label();
            this.selZoom = new System.Windows.Forms.ComboBox();
            this.folderBrowserDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDlg = new System.Windows.Forms.ColorDialog();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabPaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
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
            this.label3.Size = new System.Drawing.Size(808, 102);
            this.label3.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(515, 522);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabPaint);
            this.tabControl1.Location = new System.Drawing.Point(214, 136);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(380, 380);
            this.tabControl1.TabIndex = 23;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.lblForeColor);
            this.tabGeneral.Controls.Add(this.btnSelectForeColor);
            this.tabGeneral.Controls.Add(this.lblForeColorValue);
            this.tabGeneral.Controls.Add(this.chkUseHardwareAcceleration);
            this.tabGeneral.Controls.Add(this.btnSelectFolder);
            this.tabGeneral.Controls.Add(this.lblFolderName);
            this.tabGeneral.Controls.Add(this.lblFolder);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(372, 354);
            this.tabGeneral.TabIndex = 1;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // lblForeColor
            // 
            this.lblForeColor.AutoSize = true;
            this.lblForeColor.Location = new System.Drawing.Point(21, 145);
            this.lblForeColor.Name = "lblForeColor";
            this.lblForeColor.Size = new System.Drawing.Size(74, 13);
            this.lblForeColor.TabIndex = 8;
            this.lblForeColor.Text = "Color del texto";
            // 
            // btnSelectForeColor
            // 
            this.btnSelectForeColor.Location = new System.Drawing.Point(317, 140);
            this.btnSelectForeColor.Name = "btnSelectForeColor";
            this.btnSelectForeColor.Size = new System.Drawing.Size(34, 23);
            this.btnSelectForeColor.TabIndex = 7;
            this.btnSelectForeColor.Text = "...";
            this.btnSelectForeColor.UseVisualStyleBackColor = true;
            this.btnSelectForeColor.Click += new System.EventHandler(this.btnSelectForeColor_Click);
            // 
            // lblForeColorValue
            // 
            this.lblForeColorValue.BackColor = System.Drawing.Color.Gainsboro;
            this.lblForeColorValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblForeColorValue.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", this.bindingSource, "ForeColor", true));
            this.lblForeColorValue.Location = new System.Drawing.Point(21, 166);
            this.lblForeColorValue.Name = "lblForeColorValue";
            this.lblForeColorValue.Size = new System.Drawing.Size(330, 23);
            this.lblForeColorValue.TabIndex = 6;
            this.lblForeColorValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkUseHardwareAcceleration
            // 
            this.chkUseHardwareAcceleration.AutoSize = true;
            this.chkUseHardwareAcceleration.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "UseHardwareAcceleration", true));
            this.chkUseHardwareAcceleration.Location = new System.Drawing.Point(21, 101);
            this.chkUseHardwareAcceleration.Name = "chkUseHardwareAcceleration";
            this.chkUseHardwareAcceleration.Size = new System.Drawing.Size(153, 17);
            this.chkUseHardwareAcceleration.TabIndex = 5;
            this.chkUseHardwareAcceleration.Text = "Usar aceleración hardware";
            this.chkUseHardwareAcceleration.UseVisualStyleBackColor = true;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(314, 32);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(34, 23);
            this.btnSelectFolder.TabIndex = 4;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // lblFolderName
            // 
            this.lblFolderName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblFolderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFolderName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Folder", true));
            this.lblFolderName.Location = new System.Drawing.Point(18, 56);
            this.lblFolderName.Name = "lblFolderName";
            this.lblFolderName.Size = new System.Drawing.Size(330, 23);
            this.lblFolderName.TabIndex = 3;
            this.lblFolderName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(19, 37);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(44, 13);
            this.lblFolder.TabIndex = 2;
            this.lblFolder.Text = "Carpeta";
            // 
            // tabPaint
            // 
            this.tabPaint.Controls.Add(this.label1);
            this.tabPaint.Controls.Add(this.selDateFormat);
            this.tabPaint.Controls.Add(this.chkShowStatusBar);
            this.tabPaint.Controls.Add(this.chkShowCoordinates);
            this.tabPaint.Controls.Add(this.lblUnits);
            this.tabPaint.Controls.Add(this.txtUnits);
            this.tabPaint.Controls.Add(this.lblSelZoom);
            this.tabPaint.Controls.Add(this.selZoom);
            this.tabPaint.Location = new System.Drawing.Point(4, 22);
            this.tabPaint.Name = "tabPaint";
            this.tabPaint.Padding = new System.Windows.Forms.Padding(3);
            this.tabPaint.Size = new System.Drawing.Size(372, 354);
            this.tabPaint.TabIndex = 0;
            this.tabPaint.Text = "Display";
            this.tabPaint.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Formato de fecha";
            // 
            // selDateFormat
            // 
            this.selDateFormat.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSource, "DateFormat", true));
            this.selDateFormat.FormattingEnabled = true;
            this.selDateFormat.Items.AddRange(new object[] {
            "Corto",
            "Largo"});
            this.selDateFormat.Location = new System.Drawing.Point(123, 163);
            this.selDateFormat.Name = "selDateFormat";
            this.selDateFormat.Size = new System.Drawing.Size(121, 21);
            this.selDateFormat.TabIndex = 6;
            // 
            // chkShowStatusBar
            // 
            this.chkShowStatusBar.AutoSize = true;
            this.chkShowStatusBar.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "ShowStatusBar", true));
            this.chkShowStatusBar.Location = new System.Drawing.Point(123, 128);
            this.chkShowStatusBar.Name = "chkShowStatusBar";
            this.chkShowStatusBar.Size = new System.Drawing.Size(138, 17);
            this.chkShowStatusBar.TabIndex = 5;
            this.chkShowStatusBar.Text = "Mostrar barra de estado";
            this.chkShowStatusBar.UseVisualStyleBackColor = true;
            // 
            // chkShowCoordinates
            // 
            this.chkShowCoordinates.AutoSize = true;
            this.chkShowCoordinates.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "ShowCoordinates", true));
            this.chkShowCoordinates.Location = new System.Drawing.Point(123, 96);
            this.chkShowCoordinates.Name = "chkShowCoordinates";
            this.chkShowCoordinates.Size = new System.Drawing.Size(126, 17);
            this.chkShowCoordinates.TabIndex = 4;
            this.chkShowCoordinates.Text = "Mostrar coordenadas";
            this.chkShowCoordinates.UseVisualStyleBackColor = true;
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Location = new System.Drawing.Point(53, 63);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(52, 13);
            this.lblUnits.TabIndex = 3;
            this.lblUnits.Text = "Unidades";
            // 
            // txtUnits
            // 
            this.txtUnits.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource, "Units", true));
            this.txtUnits.Location = new System.Drawing.Point(123, 61);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(63, 20);
            this.txtUnits.TabIndex = 2;
            // 
            // lblSelZoom
            // 
            this.lblSelZoom.AutoSize = true;
            this.lblSelZoom.Location = new System.Drawing.Point(71, 32);
            this.lblSelZoom.Name = "lblSelZoom";
            this.lblSelZoom.Size = new System.Drawing.Size(34, 13);
            this.lblSelZoom.TabIndex = 1;
            this.lblSelZoom.Text = "Zoom";
            // 
            // selZoom
            // 
            this.selZoom.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSource, "Zoom", true));
            this.selZoom.FormattingEnabled = true;
            this.selZoom.Items.AddRange(new object[] {
            "100%",
            "50%",
            "25%",
            "125%",
            "150%"});
            this.selZoom.Location = new System.Drawing.Point(122, 29);
            this.selZoom.Name = "selZoom";
            this.selZoom.Size = new System.Drawing.Size(121, 21);
            this.selZoom.TabIndex = 0;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(FicherosEstructurados.MasterOptions);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 681);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Name = "fMain";
            this.Text = "27. Espejito espejito";
            this.tabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabPaint.ResumeLayout(false);
            this.tabPaint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.Label lblForeColor;
        private System.Windows.Forms.Button btnSelectForeColor;
        private System.Windows.Forms.Label lblForeColorValue;
        private System.Windows.Forms.CheckBox chkUseHardwareAcceleration;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label lblFolderName;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.TabPage tabPaint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selDateFormat;
        private System.Windows.Forms.CheckBox chkShowStatusBar;
        private System.Windows.Forms.CheckBox chkShowCoordinates;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.NumericUpDown txtUnits;
        private System.Windows.Forms.Label lblSelZoom;
        private System.Windows.Forms.ComboBox selZoom;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDlg;
        private System.Windows.Forms.ColorDialog colorDlg;
    }
}

