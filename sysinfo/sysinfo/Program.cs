using Microsoft.Win32;
using System;
using static System.Console;

namespace sysinfo
{
    class Program
    {
        static void Main(string[] args)
        {
            String TITLE = "System Information:";
            String SPACER = "";
            String OS_NAME = String.Format("Operating System: {0}", Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName", "Unknown").ToString());
            String OS_BUILD = String.Format("Build Number: {0}", Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentBuild", "Unknown").ToString());
            String OS_BRANCH = String.Format("Build Branch: {0}", Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "BuildBranch", "Unknown").ToString());
            String OS_KERNEL_VERSION = String.Format("Kernel Version: {0}", Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentVersion", "Unknown").ToString());
            String OS_ROOT = String.Format("System Root: {0}", Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "SystemRoot", "Unknown").ToString());

            String[] values = { SPACER, TITLE, SPACER, OS_NAME, OS_BUILD, OS_BRANCH, OS_KERNEL_VERSION, OS_ROOT };

            foreach (String s in values)
            {
                if (s != null)
                    WriteLine(s);
            }
        }
    }
}
