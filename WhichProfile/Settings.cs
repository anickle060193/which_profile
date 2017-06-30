using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
namespace WhichProfile.Properties
{
    internal sealed partial class Settings
    {
        public List<Redirect> Redirects
        {
            get
            {
                String redirectsString = Settings.Default.RedirectsString ?? "";
                List<Redirect> redirects = null;
                try
                {
                    redirects = JsonConvert.DeserializeObject<List<Redirect>>( redirectsString );
                }
                catch( JsonException e )
                {
                    Console.WriteLine( e );
                }
                return redirects ?? new List<Redirect>();
            }

            set
            {
                try
                {
                    String redirectsString = JsonConvert.SerializeObject( value );
                    Settings.Default.RedirectsString = redirectsString;
                }
                catch( JsonException e )
                {
                    Console.WriteLine( e );
                }
            }
        }

        public List<ChromeProfile> ChromeProfiles
        {
            get
            {
                String chromeProfilesString = Settings.Default.ChromeProfilesString ?? "";
                List<ChromeProfile> chromeProfiles = null;
                try
                {
                    chromeProfiles = JsonConvert.DeserializeObject<List<ChromeProfile>>( chromeProfilesString );
                }
                catch( JsonException e )
                {
                    Console.WriteLine( e );
                }
                return chromeProfiles ?? new List<ChromeProfile>();
            }

            set
            {
                try
                {
                    String chromeProfilesString = JsonConvert.SerializeObject( value );
                    Settings.Default.ChromeProfilesString = chromeProfilesString;
                }
                catch( JsonException e )
                {
                    Console.WriteLine( e );
                }
            }
        }

        public Settings()
        {
            this.SettingsLoaded += Settings_SettingsLoaded;
        }

        private void Settings_SettingsLoaded( object sender, SettingsLoadedEventArgs e )
        {
        }
    }
}
