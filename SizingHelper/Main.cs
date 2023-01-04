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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnGeneralSettings_Click(object sender, EventArgs e)
        {
            new Settings().Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form currentForm = Form.ActiveForm;

            if (currentForm != null)
            {
                Application.OpenForms.OfType<Form>().Where(f => f != currentForm).ToList().ForEach(f => f.Close());
            }
            Close();
        }

        private void btnPatternImport_Click(object sender, EventArgs e)
        {
            new PatternImport().Show();
        }

        private void btnPatternViewer_Click(object sender, EventArgs e)
        {
            new PatternViewer().Show();
        }

        private void btnSizingTool_Click(object sender, EventArgs e)
        {
            new SizingToolMain().Show();
        }
    }
}
