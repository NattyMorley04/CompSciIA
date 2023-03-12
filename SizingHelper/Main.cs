using System; //import all libs needed
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
    public partial class Main : Form //new instance of a form called main
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnGeneralSettings_Click(object sender, EventArgs e) 
        {
            new Settings().Show(); //open a settings window when the button is pressed
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form currentForm = Form.ActiveForm; //define which form to exit

            if (currentForm != null)
            {
                Application.OpenForms.OfType<Form>().Where(f => f != currentForm).ToList().ForEach(f => f.Close()); //close all forms except this
            }
            Close(); //close this form
        }
        private void btnPatternViewer_Click(object sender, EventArgs e)
        {
            new PatternViewer().Show(); //open a pattern viewer window on click
        }

        private void btnSizingTool_Click(object sender, EventArgs e)
        {
            new SizingToolMain().Show(); //open a sizing tool helper on click
        }

        private void Main_Load(object sender, EventArgs e)
        {

            OperatingSystem os = Environment.OSVersion; //find the operating system
            string pythonPath = ""; //initialise the python path
            string command = "";

            if (os.Platform == PlatformID.Unix || os.Platform == PlatformID.MacOSX) //find the python path for unix and macosx 
            {
                // Use the "which" command on Unix-like systems (e.g., Linux, macOS)
                command = "which python";
                Debug.WriteLine("User is currently running a Unix/Mac OS");
                // Use the "where" command on Windows
                // string command = "where python";

                // Start a new process to execute the command
                using (Process process = new Process()) //create a new process
                {
                    process.StartInfo.FileName = "bash"; //open a cmd
                    process.StartInfo.Arguments = "-c " + command; //define the command to be typed
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start(); //star the process


                    // Read the output of the command
                    pythonPath = process.StandardOutput.ReadToEnd(); //and set to to the python path
                }
            }
            else if (os.Platform == PlatformID.Win32NT || os.Platform == PlatformID.Other) //find the python path for win32nt or other os
            {
                command = "where python"; //define the command to use
                Debug.WriteLine("User is currently running a Win32NT or alternative OS"); //debug 
                // Start a new process to execute the command
                using (Process process = new Process()) //start a new cmd process
                {
                    process.StartInfo.FileName = "cmd"; //open a command prompt
                    process.StartInfo.Arguments = "/c where python > python_path.txt"; //arguments of hte path, and write to the python_path file
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = false;
                    process.Start(); //start the process

                    // Wait for the process to finish
                    process.WaitForExit();

                    // Read the contents of the output file
                    string[] paths = File.ReadAllLines("python_path.txt"); //read all lines of the file
                    pythonPath = string.Join(";", paths); //now we know where the python path is
                }

                // Use the "where" command to find the path to the Python interpreter on Windows

                Debug.WriteLine("Python Path found successfully at " + pythonPath); //debug if it is found
            }

            Properties.Settings.Default.PYTHONPATH = pythonPath; //set it to the properties
        }
    }
}
