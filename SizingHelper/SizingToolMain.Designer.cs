
namespace SizingHelper
{
    partial class SizingToolMain
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
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblSizeby = new System.Windows.Forms.Label();
            this.btnSF = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.lblSizingTool = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(10, 74);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(177, 23);
            this.txtLocation.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(192, 74);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(93, 20);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblSizeby
            // 
            this.lblSizeby.AutoSize = true;
            this.lblSizeby.Location = new System.Drawing.Point(10, 99);
            this.lblSizeby.Name = "lblSizeby";
            this.lblSizeby.Size = new System.Drawing.Size(46, 15);
            this.lblSizeby.TabIndex = 2;
            this.lblSizeby.Text = "Size by:";
            // 
            // btnSF
            // 
            this.btnSF.Location = new System.Drawing.Point(10, 116);
            this.btnSF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSF.Name = "btnSF";
            this.btnSF.Size = new System.Drawing.Size(127, 22);
            this.btnSF.TabIndex = 3;
            this.btnSF.Text = "Scale Factor";
            this.btnSF.UseVisualStyleBackColor = true;
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(158, 116);
            this.btnArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(127, 22);
            this.btnArea.TabIndex = 4;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            // 
            // lblSizingTool
            // 
            this.lblSizingTool.AutoSize = true;
            this.lblSizingTool.Location = new System.Drawing.Point(108, 28);
            this.lblSizingTool.Name = "lblSizingTool";
            this.lblSizingTool.Size = new System.Drawing.Size(63, 15);
            this.lblSizingTool.TabIndex = 5;
            this.lblSizingTool.Text = "Sizing Tool";
            // 
            // SizingToolMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 145);
            this.Controls.Add(this.lblSizingTool);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnSF);
            this.Controls.Add(this.lblSizeby);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtLocation);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SizingToolMain";
            this.Text = "Sizing Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblSizeby;
        private System.Windows.Forms.Button btnSF;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label lblSizingTool;
    }
}