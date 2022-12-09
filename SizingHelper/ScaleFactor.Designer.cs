
namespace SizingHelper
{
    partial class ScaleFactor
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
            this.btnGo = new System.Windows.Forms.Button();
            this.txtSF = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(80, 111);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(82, 55);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // txtSF
            // 
            this.txtSF.Location = new System.Drawing.Point(100, 34);
            this.txtSF.Name = "txtSF";
            this.txtSF.Size = new System.Drawing.Size(118, 27);
            this.txtSF.TabIndex = 1;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(3, 37);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(91, 20);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Scale Factor:";
            // 
            // ScaleFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 206);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtSF);
            this.Controls.Add(this.btnGo);
            this.Name = "ScaleFactor";
            this.Text = "Scale Factor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtSF;
        private System.Windows.Forms.Label lblArea;
    }
}