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
    public partial class SizingToolMain : Form //create a new form called sizing tool main
    {
        public SizingToolMain()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e) //create a file dialog to browse for the path
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Sizing Helper files (*.sht)|*.sht|Text files (*.txt)|*.txt|All files (*.*)|*.*"; //filter to usable file types
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //start in documents

                if (openFileDialog.ShowDialog() == DialogResult.OK) //if the user has selected to go
                {
                    txtLocation.Text = openFileDialog.FileName; //set the path to the file specified
                }
            }
        }

        private void btnSF_Click(object sender, EventArgs e) //open the scale factor window
        {
            if (txtLocation.Text != "") //file path validation
            {
                Properties.Settings.Default.filePath = txtLocation.Text; //set the internal path to the pattern
                new ScaleFactor().Show(); //open a new window
            }
            else
            {
                MessageBox.Show("File Path Invalid!"); //file path validation error
            }
            
        }

        private void btnArea_Click(object sender, EventArgs e) //open the areas window
        {
            if (txtLocation.Text != "") //file path validation
            {
                Properties.Settings.Default.filePath = txtLocation.Text; //set the internal path to the pattern
                new Area().Show(); //open a new window
            }
            else
            {
                MessageBox.Show("File Path Invalid!"); //file path validation error
            }
        }
    }
}
