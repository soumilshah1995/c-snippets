using System;
using System.IO; 
using System.Diagnostics; 

namespace pycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName = "pyscripts.py"; 
            ProcessStartInfo ProcessInfo = new ProcessStartInfo("python3"); 

            // make sure we can read the output from stdout 
            ProcessInfo.UseShellExecute = false; 
            ProcessInfo.RedirectStandardOutput = true; 

            ProcessInfo.Arguments = FileName;
            Process myProcess = new Process(); 

            // assign start information to the process 
            myProcess.StartInfo = ProcessInfo; 

            // start the process 
            myProcess.Start(); 

            StreamReader myStreamReader = myProcess.StandardOutput; 
            string myString = myStreamReader.ReadLine(); 
            myProcess.WaitForExit(); 
            myProcess.Close();
            Console.WriteLine("Value received from script: " + myString); 
        

        }
    }
}
