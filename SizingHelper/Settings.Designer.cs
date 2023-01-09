
namespace SizingHelper
{
    partial class Settings
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.clbSettings = new System.Windows.Forms.CheckedListBox();
            this.lblSeam = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.cmbSeam = new System.Windows.Forms.ComboBox();
            this.cmbgenericunit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPyPath = new System.Windows.Forms.TextBox();
            this.btnPyPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(119, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(49, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Settings";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(79, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(160, 307);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // clbSettings
            // 
            this.clbSettings.FormattingEnabled = true;
            this.clbSettings.Items.AddRange(new object[] {
            "Show Angles",
            "Radian Mode",
            "Seam Allowance"});
            this.clbSettings.Location = new System.Drawing.Point(91, 73);
            this.clbSettings.Name = "clbSettings";
            this.clbSettings.Size = new System.Drawing.Size(120, 58);
            this.clbSettings.TabIndex = 3;
            // 
            // lblSeam
            // 
            this.lblSeam.AutoSize = true;
            this.lblSeam.Location = new System.Drawing.Point(91, 134);
            this.lblSeam.Name = "lblSeam";
            this.lblSeam.Size = new System.Drawing.Size(117, 15);
            this.lblSeam.TabIndex = 4;
            this.lblSeam.Text = "Seam Allowance Size";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(91, 152);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(77, 23);
            this.txtSize.TabIndex = 5;
            // 
            // cmbSeam
            // 
            this.cmbSeam.FormattingEnabled = true;
            this.cmbSeam.Items.AddRange(new object[] {
            "cm",
            "in"});
            this.cmbSeam.Location = new System.Drawing.Point(174, 152);
            this.cmbSeam.Name = "cmbSeam";
            this.cmbSeam.Size = new System.Drawing.Size(42, 23);
            this.cmbSeam.TabIndex = 6;
            // 
            // cmbgenericunit
            // 
            this.cmbgenericunit.FormattingEnabled = true;
            this.cmbgenericunit.Items.AddRange(new object[] {
            "cm",
            "in"});
            this.cmbgenericunit.Location = new System.Drawing.Point(91, 202);
            this.cmbgenericunit.Name = "cmbgenericunit";
            this.cmbgenericunit.Size = new System.Drawing.Size(63, 23);
            this.cmbgenericunit.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "General Unit (feature not needed!)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ensure that you are consistantly using metric/imperial units";
            // 
            // txtPyPath
            // 
            this.txtPyPath.Location = new System.Drawing.Point(76, 279);
            this.txtPyPath.Name = "txtPyPath";
            this.txtPyPath.Size = new System.Drawing.Size(77, 23);
            this.txtPyPath.TabIndex = 10;
            // 
            // btnPyPath
            // 
            this.btnPyPath.Location = new System.Drawing.Point(160, 278);
            this.btnPyPath.Name = "btnPyPath";
            this.btnPyPath.Size = new System.Drawing.Size(75, 23);
            this.btnPyPath.TabIndex = 11;
            this.btnPyPath.Text = "Browse";
            this.btnPyPath.UseVisualStyleBackColor = true;
            this.btnPyPath.Click += new System.EventHandler(this.btnPyPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "PYTHONPATH: Use if getting issues";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 399);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPyPath);
            this.Controls.Add(this.txtPyPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbgenericunit);
            this.Controls.Add(this.cmbSeam);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lblSeam);
            this.Controls.Add(this.clbSettings);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckedListBox clbSettings;
        private System.Windows.Forms.Label lblSeam;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.ComboBox cmbSeam;
        private System.Windows.Forms.ComboBox cmbgenericunit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPyPath;
        private System.Windows.Forms.Button btnPyPath;
        private System.Windows.Forms.Label label3;
    }
}