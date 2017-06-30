using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhichProfile
{
    static class Redirector
    {
        public static void Direct( String url )
        {
            Chrome.StartChrome( url );
        }
    }
}
