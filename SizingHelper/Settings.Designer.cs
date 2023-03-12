
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPyPath = new System.Windows.Forms.TextBox();
            this.btnPyPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRepeats = new System.Windows.Forms.TextBox();
            this.lblRepeats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(136, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(62, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Settings";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(62, 361);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(155, 361);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 31);
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
            "Radian Mode"});
            this.clbSettings.Location = new System.Drawing.Point(104, 97);
            this.clbSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clbSettings.Name = "clbSettings";
            this.clbSettings.Size = new System.Drawing.Size(137, 70);
            this.clbSettings.TabIndex = 3;
            // 
            // lblSeam
            // 
            this.lblSeam.AutoSize = true;
            this.lblSeam.Location = new System.Drawing.Point(97, 244);
            this.lblSeam.Name = "lblSeam";
            this.lblSeam.Size = new System.Drawing.Size(150, 20);
            this.lblSeam.TabIndex = 4;
            this.lblSeam.Text = "Seam Allowance Size";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(97, 268);
            this.txtSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(87, 27);
            this.txtSize.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 9;
            // 
            // txtPyPath
            // 
            this.txtPyPath.Location = new System.Drawing.Point(59, 324);
            this.txtPyPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPyPath.Name = "txtPyPath";
            this.txtPyPath.Size = new System.Drawing.Size(87, 27);
            this.txtPyPath.TabIndex = 10;
            // 
            // btnPyPath
            // 
            this.btnPyPath.Location = new System.Drawing.Point(155, 323);
            this.btnPyPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPyPath.Name = "btnPyPath";
            this.btnPyPath.Size = new System.Drawing.Size(86, 31);
            this.btnPyPath.TabIndex = 11;
            this.btnPyPath.Text = "Browse";
            this.btnPyPath.UseVisualStyleBackColor = true;
            this.btnPyPath.Click += new System.EventHandler(this.btnPyPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "PYTHONPATH: Use if getting issues";
            // 
            // txtRepeats
            // 
            this.txtRepeats.Location = new System.Drawing.Point(97, 212);
            this.txtRepeats.Name = "txtRepeats";
            this.txtRepeats.Size = new System.Drawing.Size(87, 27);
            this.txtRepeats.TabIndex = 13;
            // 
            // lblRepeats
            // 
            this.lblRepeats.AutoSize = true;
            this.lblRepeats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRepeats.Location = new System.Drawing.Point(97, 189);
            this.lblRepeats.Name = "lblRepeats";
            this.lblRepeats.Size = new System.Drawing.Size(62, 20);
            this.lblRepeats.TabIndex = 14;
            this.lblRepeats.Text = "Repeats";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 416);
            this.Controls.Add(this.lblRepeats);
            this.Controls.Add(this.txtRepeats);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPyPath);
            this.Controls.Add(this.txtPyPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lblSeam);
            this.Controls.Add(this.clbSettings);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Settings";
            this.Text = "7";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPyPath;
        private System.Windows.Forms.Button btnPyPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRepeats;
        private System.Windows.Forms.Label lblRepeats;
    }
}