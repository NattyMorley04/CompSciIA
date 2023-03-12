using System; //imports 
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
    public partial class ScaleFactor : Form //initialise a new form called scale factor
    {
        public ScaleFactor()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e) //if the button go is clicked run the code
        {
            // Validate the input value in the txtSF textbox
            if (!float.TryParse(txtSF.Text, out float value))
            {
                MessageBox.Show("Scale factor needs to be a valid number.");
                return; // exit the function if validation fails
            }

            if (value <= 0.01 || value >= 1000)
            {
                MessageBox.Show("Scale factor needs to be a positive non-zero number between 0.01 and 1000.");
                return; // exit the function if validation fails
            }
            string exePath = AppDomain.CurrentDomain.BaseDirectory; //find this .exe
            //delete the old parameter files and create new ones
            string paramsPath = Path.Combine(exePath, "params.cfg"); //find the path for the param.cfg
            if (System.IO.File.Exists(paramsPath)) //if it already exists delete it 
            {
                System.IO.File.Delete(paramsPath);
            }
            System.IO.File.Create(paramsPath).Close(); //close that file that was just created
            //write the relevant parameters to the files
            using (StreamWriter sw = new StreamWriter(Path.Combine(exePath, "params.cfg"))) //new stream writer to write the parameters
            {
                sw.WriteLine(Properties.Settings.Default.filePath); //write the path
                sw.WriteLine(txtSF.Text); //write the scale factor
                sw.WriteLine(Properties.Settings.Default.allowanceSize); //write the allowance size
                sw.WriteLine(Properties.Settings.Default.showAngles); //write if to show angles
                sw.WriteLine(Properties.Settings.Default.radianMode); //write if to use radians
                sw.WriteLine(Properties.Settings.Default.repeat); //write how many repeats to perform
            }
            // Set the path to the script to be executed
            string pythonFile = "scalefactor.py"; //define what file to execute
            string script = Path.Combine(exePath, pythonFile); //find that path to that file

            // Create a new ProcessStartInfo
            ProcessStartInfo start = new ProcessStartInfo(); //create a new process
            start.FileName = Properties.Settings.Default.PYTHONPATH;  // Set the file name to the Python interpreter
            start.Arguments = pythonFile; // Set the arguments to the script path
            start.UseShellExecute = true;  // Do use the shell to execute the process
            start.WorkingDirectory = Environment.CurrentDirectory;
            start.RedirectStandardOutput = false;  // Redirect the standard output stream
            start.CreateNoWindow = false; // Do create a new window for the process
            start.WindowStyle = ProcessWindowStyle.Normal;

            Debug.WriteLine("Starting Python script at " + script);

            Process process = Process.Start(start); //start the process     
        }
    }
}
