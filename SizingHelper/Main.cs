using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

        private void Main_Load(object sender, EventArgs e)
        {

            OperatingSystem os = Environment.OSVersion;
            string pythonPath = "";
            string command = "";

            if (os.Platform == PlatformID.Unix || os.Platform == PlatformID.MacOSX)
            {
                // Use the "which" command on Unix-like systems (e.g., Linux, macOS)
                command = "which python";
                Debug.WriteLine("User is currently running a Unix/Mac OS");
                // Use the "where" command on Windows
                // string command = "where python";

                // Start a new process to execute the command
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "bash";
                    process.StartInfo.Arguments = "-c " + command;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();


                    // Read the output of the command
                    pythonPath = process.StandardOutput.ReadToEnd();
                }
            }
            else if (os.Platform == PlatformID.Win32NT || os.Platform == PlatformID.Other)
            {
                command = "where python";
                Debug.WriteLine("User is currently running a Win32NT or alternative OS");
                // Start a new process to execute the command
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd";
                    process.StartInfo.Arguments = "/c where python > python_path.txt";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = false;
                    process.Start();

                    // Wait for the process to finish
                    process.WaitForExit();

                    // Read the contents of the output file
                    string[] paths = File.ReadAllLines("python_path.txt");
                    pythonPath = string.Join(";", paths);
                }

                // Use the "where" command to find the path to the Python interpreter on Windows

                Debug.WriteLine("Python Path found successfully at " + pythonPath);
            }

            Properties.Settings.Default.area4 = pythonPath;
        }
    }
}
