using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhichProfile
{
    static class Chrome
    {
        public static String GetDataPath()
        {
            return Path.Combine( Environment.GetFolderPath( Environment.SpecialFolder.LocalApplicationData ), "Google", "Chrome" );
        }

        public static void StartChrome( String url )
        {
            Process.Start( @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", url );
        }

        public static void StartChrome( String url, String profile )
        {
            Process.Start( @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", String.Format( "\"{0}\" --profile-directroy=\"{1}\"", url, profile ) );
        }
    }
}
