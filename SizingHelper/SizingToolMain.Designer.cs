
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
            this.txtLocation.Location = new System.Drawing.Point(11, 99);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(202, 27);
            this.txtLocation.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(219, 99);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(106, 27);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblSizeby
            // 
            this.lblSizeby.AutoSize = true;
            this.lblSizeby.Location = new System.Drawing.Point(11, 132);
            this.lblSizeby.Name = "lblSizeby";
            this.lblSizeby.Size = new System.Drawing.Size(59, 20);
            this.lblSizeby.TabIndex = 2;
            this.lblSizeby.Text = "Size by:";
            // 
            // btnSF
            // 
            this.btnSF.Location = new System.Drawing.Point(11, 155);
            this.btnSF.Name = "btnSF";
            this.btnSF.Size = new System.Drawing.Size(145, 29);
            this.btnSF.TabIndex = 3;
            this.btnSF.Text = "Scale Factor";
            this.btnSF.UseVisualStyleBackColor = true;
            this.btnSF.Click += new System.EventHandler(this.btnSF_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(181, 155);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(145, 29);
            this.btnArea.TabIndex = 4;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // lblSizingTool
            // 
            this.lblSizingTool.AutoSize = true;
            this.lblSizingTool.Location = new System.Drawing.Point(123, 37);
            this.lblSizingTool.Name = "lblSizingTool";
            this.lblSizingTool.Size = new System.Drawing.Size(82, 20);
            this.lblSizingTool.TabIndex = 5;
            this.lblSizingTool.Text = "Sizing Tool";
            // 
            // SizingToolMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 193);
            this.Controls.Add(this.lblSizingTool);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnSF);
            this.Controls.Add(this.lblSizeby);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtLocation);
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