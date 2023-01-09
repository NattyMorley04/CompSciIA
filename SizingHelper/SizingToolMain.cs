using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SizingHelper
{
    public partial class SizingToolMain : Form
    {
        public SizingToolMain()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Sizing Helper files (*.sht)|*.sht|Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtLocation.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnSF_Click(object sender, EventArgs e)
        {
            if (txtLocation.Text != "")
            {
                Properties.Settings.Default.filePath = txtLocation.Text;
                new ScaleFactor().Show();
            }
            else
            {
                MessageBox.Show("File Path Invalid!");
            }
            
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            if (txtLocation.Text != "")
            {
                Properties.Settings.Default.filePath = txtLocation.Text;
                new ScaleFactor().Show();
            }
            else
            {
                MessageBox.Show("File Path Invalid!");
            }
        }
    }
}
