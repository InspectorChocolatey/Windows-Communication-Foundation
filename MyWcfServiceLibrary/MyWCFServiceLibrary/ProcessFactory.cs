using System;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace MyWCFServiceLibrary
{
    class ProcessFactory
    {
        public string Output;
        public string Computername { get; set; }

        public ProcessFactory(string computername)
        {
            this.Computername = computername;
            this.Output = StartLocalProcess(this.Computername);

        }



        /// <summary>
        ///     Example: StartServerProcess("localhost", "ipconfig", "/?");
        /// </summary>
        /// <param name="computername"></param>
        /// <param name="program"></param>
        /// <param name="arguments"></param>
        /// <returns></returns>
        public string StartServerProcess(string computername, string program, string arguments)
        {
            string argument = arguments;
            string output, format_output;

            Process proc = new Process();
            proc.StartInfo.FileName = program;
            proc.StartInfo.Arguments = argument;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();

            StreamReader reader = proc.StandardOutput;
            output = reader.ReadToEnd();
            proc.WaitForExit();
            proc.Close();

            format_output = Regex.Replace(output, @"\s+", "").Split('\\').Last();
            return format_output;
        }



        public string StartLocalProcess(string computername)
        {
            string argument = "/node:" + computername + " computersystem get username";
            string output, format_output;

            Process proc = new Process();
            proc.StartInfo.FileName = "wmic.exe";
            proc.StartInfo.Arguments = argument;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();

            StreamReader reader = proc.StandardOutput;
            output = reader.ReadToEnd();
            proc.WaitForExit();
            proc.Close();

            format_output = Regex.Replace(output, @"\s+", "").Split('\\').Last();
            return format_output;
        }






        public string CurrentUsers(string computername)
        {
            string argument = "/node:" + computername + " computersystem get username";
            string output, format_output;

            Process proc = new Process();
            proc.StartInfo.FileName = "wmic.exe";
            proc.StartInfo.Arguments = argument;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();

            StreamReader reader = proc.StandardOutput;
            output = reader.ReadToEnd();
            proc.WaitForExit();
            proc.Close();

            format_output = Regex.Replace(output, @"\s+", "").Split('\\').Last();
            return format_output;
        }
    }
}
