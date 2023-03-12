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
    public partial class PatternViewer : Form //initialise a new form called the pattern viewer
    {
        public PatternViewer()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e) //open a file dialog when the browse button is clicked
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) //open a new file dialog
            {
                openFileDialog.Filter = "Sizing Helper files (*.sht)|*.sht|Text files (*.txt)|*.txt|All files (*.*)|*.*"; //set the filter to files usable
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //start in my documents

                if (openFileDialog.ShowDialog() == DialogResult.OK) //when a file is found
                {
                    txtPath.Text = openFileDialog.FileName; //set the path to this file
                }
            }
        }

        private void btnGo_Click(object sender, EventArgs e) //when the button go is clicked load the pattern
        {
            if (txtPath.Text != "") //if the path is not empty
            {
                if (new FileInfo(txtPath.Text).Length != 0) //if the path is empty then do not try running the python script
                {
                    Properties.Settings.Default.filePath = txtPath.Text; //the path is already define from the previous text box
                    string exePath = Environment.CurrentDirectory; //find this exe's path
                    //delete the old parameter files and create new ones
                    string paramsPath = Path.Combine(exePath, "params.cfg");
                    if (System.IO.File.Exists(paramsPath))
                    {
                        System.IO.File.Delete(paramsPath);
                    }
                    System.IO.File.Create(paramsPath).Close(); //close the path
                    //write the relevant parameters to the files
                    using (StreamWriter sw = new StreamWriter(Path.Combine(exePath, "params.cfg"))) //write to the parameters file
                    {
                        sw.WriteLine(Properties.Settings.Default.filePath); //write path
                        sw.WriteLine("1"); //write the scale factor of (1)
                        sw.WriteLine(Properties.Settings.Default.allowanceSize); //write the allowance size
                        sw.WriteLine(Properties.Settings.Default.showAngles); //write if to show angles
                        sw.WriteLine(Properties.Settings.Default.radianMode); //write if to show radians
                        sw.WriteLine("1"); //write the amounts of repeats
                    }
                    // Set the path to the script to be executed
                    string pythonFile = "scalefactor.py"; //find the file
                    string script = Path.GetFullPath(Path.Combine(exePath, pythonFile)); //find the path to that file

                    // Create a new ProcessStartInfo
                    ProcessStartInfo start = new ProcessStartInfo();
                    start.FileName = Properties.Settings.Default.PYTHONPATH;  // Set the file name to the Python interpreter
                    start.WorkingDirectory = Environment.CurrentDirectory;
                    start.Arguments = pythonFile; // Set the arguments to the script path
                    start.UseShellExecute = true;  // Do use the shell to execute the process
                    start.RedirectStandardOutput = false;  // Redirect the standard output stream
                    start.CreateNoWindow = false; // Do create a new window for the process
                    start.WindowStyle = ProcessWindowStyle.Normal;

                    Debug.WriteLine("Starting Python script at " + script); //debug

                    Process process = Process.Start(start); //start the process
                }
                else if (new FileInfo(txtPath.Text).Length == 0) //if the file is empty
                {
                    MessageBox.Show("File is empty!"); //error
                }
                else
                {
                    MessageBox.Show("An unknown error occured"); //if something else went wrong
                }
            }
            else if (txtPath.Text != "") //if the path is empty
            {
                MessageBox.Show("File Path Invalid!");
            }

            else
            {
                MessageBox.Show("An unknown error occured"); //if something else went wrong
            }
        }
    }
}
