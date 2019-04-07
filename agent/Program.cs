using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace agent
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c DIR"; // Note the /c command (*)
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start();
            //* Read the output (or the error)
            string output = process.StandardOutput.ReadToEnd();
            Console.WriteLine(output);
            string err = process.StandardError.ReadToEnd();
            Console.WriteLine(err);
            process.WaitForExit();
            Console.ReadKey();
            */

            String hostName = string.Empty;
            hostName = Dns.GetHostName();

            IPHostEntry myIP = Dns.GetHostEntry(hostName);
            IPAddress[] address = myIP.AddressList;

            for (int i = 0; i < address.Length; i++)
            {
                //string s = String.Format(address[i]);
                Console.WriteLine("IP Address {0} : ", address[i].ToString());
                Console.WriteLine(Environment.MachineName);
            }
            Console.ReadLine();
        }
    }
}




