using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace OpenTabletWrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Process daemon = new Process();
            daemon.StartInfo.FileName = "OpenTabletDriver.Daemon.exe";
            //daemon.StartInfo.WorkingDirectory = Assembly.GetExecutingAssembly().Location;
            daemon.StartInfo.UseShellExecute = false;
            daemon.StartInfo.CreateNoWindow = true;
            daemon.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            daemon.Start();
        }
    }
}
