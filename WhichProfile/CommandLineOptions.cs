using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhichProfile
{
    class CommandLineOptions
    {
        [Option( Required = true, HelpText = "The URL to direct to the correct Chrome profile." )]
        public String Url { get; set; }
    }
}
