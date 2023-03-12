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
    public partial class Area : Form //instantiate a form called Area.
    {
        public Area() //whenever area is called initalize
        {
            InitializeComponent();
        }
        private void btnGo_Click(object sender, EventArgs e) //open button go
        {
            bool check_good = true; //this will be compared against at the end to see if all the validations are correct
            bool validation_error = false;
            string exePath = AppDomain.CurrentDomain.BaseDirectory; //find where the .exe is currently located
            string areasPath = Path.Combine(exePath, "areas.txt"); //find areas.txt
            string paramsPath = Path.Combine(exePath, "params.cfg"); //find params.cfg
            if (System.IO.File.Exists(areasPath)) //if areas exists delete it
            {
                System.IO.File.Delete(areasPath);
            }
            if (System.IO.File.Exists(paramsPath)) //if params exists delte it 
            {
                System.IO.File.Delete(paramsPath);
            }
            System.IO.File.Create(areasPath).Close(); //close the files so we can write ot them
            System.IO.File.Create(paramsPath).Close();
            //write the relevant parameters to the files
            using (StreamWriter sw = new StreamWriter(areasPath)) //initialise a writer
            {
                int counter = 0;
                foreach (string item in txtAreas.Lines)
                {
                    if (item != "" && float.TryParse(item, out float parsed) && parsed > 0)
                    {
                        if (parsed < 10 || parsed > 100000)
                        {
                            check_good = false;
                            validation_error = true;
                            break; //exit the loop since there is an error
                        }
                        sw.WriteLine(counter.ToString() + "," + item);
                        counter += 1;
                    }
                    else
                    {
                        MessageBox.Show("Error in areas validation. Cannot parse item as float!");
                        check_good = false;
                        break; //exit the loop since there is an error
                    }
                }
            }

            using (StreamWriter sw = new StreamWriter(Path.Combine(exePath, "params.cfg"))) //write to params.cfg
            {
                sw.WriteLine(Properties.Settings.Default.filePath); //write the file path
                sw.WriteLine("1"); //write the scale factor (1)
                sw.WriteLine(Properties.Settings.Default.allowanceSize); //write the seam allowance
                sw.WriteLine(Properties.Settings.Default.showAngles); //write if to show angles
                sw.WriteLine(Properties.Settings.Default.radianMode); //if if to use radians
                sw.WriteLine(Properties.Settings.Default.repeat); //write the number of repeats
            }
            if (check_good) //if it is all working
            {
                // Set the path to the script to be executed
                string pythonFile = "Area.py"; //python file is area.py
                string script = Path.Combine(exePath, pythonFile); //find the actual path of the python file

                // Create a new ProcessStartInfo
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = Properties.Settings.Default.PYTHONPATH;  // Set the file name to the Python interpreter
                start.Arguments = pythonFile; // Set the arguments to the script path
                start.WorkingDirectory = Environment.CurrentDirectory;
                start.UseShellExecute = true;  // Do use the shell to execute the process
                start.RedirectStandardOutput = false;  // Redirect the standard output stream
                start.CreateNoWindow = false; // Do create a new window for the process
                start.WindowStyle = ProcessWindowStyle.Normal;

                Process process = Process.Start(start); //execute the area.py!
            }
            else if (validation_error)
            {
                MessageBox.Show("Error in validation! Area is too extreme! (areas must be between 10 and 100000");
            }
        }
    }
}
