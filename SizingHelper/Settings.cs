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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.showAngles = clbSettings.GetItemChecked(0);
            Properties.Settings.Default.radianMode = clbSettings.GetItemChecked(1);
            Properties.Settings.Default.seamAllowance = clbSettings.GetItemChecked(2);
            bool isFloat = float.TryParse(txtSize.Text, out float value) && value > 0;

            if (isFloat)
            {
                Properties.Settings.Default.allowanceSize = float.Parse(txtSize.Text);
            }
            else
            {
                MessageBox.Show("Can not save data in 'Seam Allowance' field. Needs to be a positive non-zero float!");
            }
            Properties.Settings.Default.allowanceUnit = cmbSeam.Text;
            Properties.Settings.Default.genericUnit = cmbgenericunit.Text;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            clbSettings.SetItemChecked(0, Properties.Settings.Default.showAngles);
            clbSettings.SetItemChecked(1, Properties.Settings.Default.radianMode);
            clbSettings.SetItemChecked(2, Properties.Settings.Default.seamAllowance);
            txtSize.Text = Properties.Settings.Default.allowanceSize.ToString();
            cmbSeam.Text = Properties.Settings.Default.allowanceUnit;
            cmbgenericunit.Text = Properties.Settings.Default.genericUnit;
        }

        private void btnPyPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Executables (*.exe)|*.exe|Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPyPath.Text = openFileDialog.FileName;
                }
            }
        }
    }
}
