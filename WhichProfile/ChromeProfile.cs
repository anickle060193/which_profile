using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhichProfile
{
    class ChromeProfile
    {
        public String Name { get; set; }
        public String DataDirectory { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
