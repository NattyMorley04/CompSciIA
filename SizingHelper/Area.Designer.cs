
namespace SizingHelper
{
    partial class Area
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
            this.txtfab1 = new System.Windows.Forms.TextBox();
            this.lblArea1 = new System.Windows.Forms.Label();
            this.lblFab2 = new System.Windows.Forms.Label();
            this.txtFab2 = new System.Windows.Forms.TextBox();
            this.lblfab3 = new System.Windows.Forms.Label();
            this.txtfab3 = new System.Windows.Forms.TextBox();
            this.chbfab3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.lblrepeat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(90, 118);
            this.btnGo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(72, 41);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // txtfab1
            // 
            this.txtfab1.Location = new System.Drawing.Point(112, 25);
            this.txtfab1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfab1.Name = "txtfab1";
            this.txtfab1.Size = new System.Drawing.Size(104, 23);
            this.txtfab1.TabIndex = 1;
            // 
            // lblArea1
            // 
            this.lblArea1.AutoSize = true;
            this.lblArea1.Location = new System.Drawing.Point(27, 28);
            this.lblArea1.Name = "lblArea1";
            this.lblArea1.Size = new System.Drawing.Size(79, 15);
            this.lblArea1.TabIndex = 2;
            this.lblArea1.Text = "Area of Fab 1:";
            // 
            // lblFab2
            // 
            this.lblFab2.AutoSize = true;
            this.lblFab2.Location = new System.Drawing.Point(27, 55);
            this.lblFab2.Name = "lblFab2";
            this.lblFab2.Size = new System.Drawing.Size(79, 15);
            this.lblFab2.TabIndex = 4;
            this.lblFab2.Text = "Area of Fab 2:";
            // 
            // txtFab2
            // 
            this.txtFab2.Location = new System.Drawing.Point(112, 52);
            this.txtFab2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFab2.Name = "txtFab2";
            this.txtFab2.Size = new System.Drawing.Size(104, 23);
            this.txtFab2.TabIndex = 3;
            // 
            // lblfab3
            // 
            this.lblfab3.AutoSize = true;
            this.lblfab3.Location = new System.Drawing.Point(27, 82);
            this.lblfab3.Name = "lblfab3";
            this.lblfab3.Size = new System.Drawing.Size(79, 15);
            this.lblfab3.TabIndex = 6;
            this.lblfab3.Text = "Area of Fab 3:";
            // 
            // txtfab3
            // 
            this.txtfab3.Location = new System.Drawing.Point(112, 79);
            this.txtfab3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfab3.Name = "txtfab3";
            this.txtfab3.Size = new System.Drawing.Size(104, 23);
            this.txtfab3.TabIndex = 5;
            // 
            // chbfab3
            // 
            this.chbfab3.AutoSize = true;
            this.chbfab3.Location = new System.Drawing.Point(222, 83);
            this.chbfab3.Name = "chbfab3";
            this.chbfab3.Size = new System.Drawing.Size(15, 14);
            this.chbfab3.TabIndex = 7;
            this.chbfab3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(222, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(222, 29);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // lblrepeat
            // 
            this.lblrepeat.AutoSize = true;
            this.lblrepeat.Location = new System.Drawing.Point(205, 8);
            this.lblrepeat.Name = "lblrepeat";
            this.lblrepeat.Size = new System.Drawing.Size(48, 15);
            this.lblrepeat.TabIndex = 10;
            this.lblrepeat.Text = "Repeat?";
            // 
            // Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 180);
            this.Controls.Add(this.lblrepeat);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chbfab3);
            this.Controls.Add(this.lblfab3);
            this.Controls.Add(this.txtfab3);
            this.Controls.Add(this.lblFab2);
            this.Controls.Add(this.txtFab2);
            this.Controls.Add(this.lblArea1);
            this.Controls.Add(this.txtfab1);
            this.Controls.Add(this.btnGo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Area";
            this.Text = "Area";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtfab1;
        private System.Windows.Forms.Label lblArea1;
        private System.Windows.Forms.Label lblFab2;
        private System.Windows.Forms.TextBox txtFab2;
        private System.Windows.Forms.Label lblfab3;
        private System.Windows.Forms.TextBox txtfab3;
        private System.Windows.Forms.CheckBox chbfab3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label lblrepeat;
    }
}