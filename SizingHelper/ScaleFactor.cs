using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SizingHelper
{
    public partial class ScaleFactor : Form
    {
        public ScaleFactor()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            bool isFloat = float.TryParse(txtSF.Text, out float value) && value > 0;

            if (isFloat)
            {
                Properties.Settings.Default.scaleFactor = float.Parse(txtSF.Text);

                //Set the path to the Python interpreter
                string pythonPath = Properties.Settings.Default.area4;
                string python = pythonPath;
                python = @"C:\Users\Natty\AppData\Local\Programs\Python\Python37-32\python.exe";

                // Set the path to the script to be executed
                string exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string pythonFile = "test.py";
                //string script = Path.Combine(exePath, pythonFile);
                string script = @"C:\Users\Natty\source\repos\SizingHelper\SizingHelper\bin\Debug\net5.0-windows\test.py";
                // Create a new ProcessStartInfo
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = python;  // Set the file name to the Python interpreter
                start.Arguments = $"{script} foo 1 2"; // Set the arguments to the script path
                start.UseShellExecute = true;  // Do use the shell to execute the process
                start.RedirectStandardOutput = false;  // Redirect the standard output stream
                start.CreateNoWindow = false; // Do create a new window for the process
                start.WindowStyle = ProcessWindowStyle.Normal;


                Process process = Process.Start(start);
            }
            else
            {
                MessageBox.Show("Can not save data in 'Scale Factor' field. Needs to be a positive non-zero float!");
            }
        }
    }
}
