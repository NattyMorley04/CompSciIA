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
    public partial class Settings : Form //initialise a new form called settings
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) //close if the user presses the back button
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e) //when the user is ready to save
        {
            bool validation = true; //validation bool to compare to
            Properties.Settings.Default.showAngles = clbSettings.GetItemChecked(0); //write the check box items to their relevent criteria
            Properties.Settings.Default.radianMode = clbSettings.GetItemChecked(1);
            validation = int.TryParse(txtRepeats.Text, out int repeats); //attempt to parse repeats as an int
            if (validation) 
            {
                Properties.Settings.Default.repeat = txtRepeats.Text; //then write it if it can
            }
            else
            {
                MessageBox.Show("Can not save data in 'Repeats' field. Needs to be a positive non-zero integer!"); //error to display if it can't parse
            }
            validation = float.TryParse(txtSize.Text, out float value) && value > 0; //reuse the previous validation bool
            if (validation) //if its true for the seam allowance
            {
                Properties.Settings.Default.allowanceSize = float.Parse(txtSize.Text); //if it can parse write the seam allowance
            }
            else
            {
                MessageBox.Show("Can not save data in 'Seam Allowance' field. Needs to be a positive non-zero float!"); //if it cant parse
            }
            
            if (txtPyPath.Text != "") //write the path if not empty
            {
                Properties.Settings.Default.PYTHONPATH = txtPyPath.Text;
            }
        }

        private void Settings_Load(object sender, EventArgs e) //open loading, load the default settings into the window so the user can modify them
        {
            clbSettings.SetItemChecked(0, Properties.Settings.Default.showAngles);
            clbSettings.SetItemChecked(1, Properties.Settings.Default.radianMode);
            txtSize.Text = Properties.Settings.Default.allowanceSize.ToString();
            txtRepeats.Text = Properties.Settings.Default.repeat;
        }

        private void btnPyPath_Click(object sender, EventArgs e) //opens a file dialog for a user to define their python path
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) //opens the dialog
            {
                openFileDialog.Filter = "Executables (*.exe)|*.exe|Text files (*.txt)|*.txt|All files (*.*)|*.*"; //filter to .exe
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //start in documents

                if (openFileDialog.ShowDialog() == DialogResult.OK) //if the user has specified a file
                {
                    txtPyPath.Text = openFileDialog.FileName; //write that path.
                }
            }
        }
    }
}
