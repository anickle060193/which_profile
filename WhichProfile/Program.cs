using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhichProfile
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main( String[] args )
        {
            CommandLineOptions options = new CommandLineOptions();
            if( CommandLine.Parser.Default.ParseArguments( args, options ) )
            {
                Redirector.Direct( options.Url );
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault( false );
                Application.Run( new WhichProfileForm() );
            }
        }
    }
}
