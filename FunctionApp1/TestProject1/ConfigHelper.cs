using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1
{
    class ConfigHelper
    {
        private static Settings settings;

        public static Settings Settings
        {
            get
            {
                if(settings != null)
                {
                    return settings;
                }
                var config = new ConfigurationBuilder()
                    .AddJsonFile("local.settings.json")
                    .AddEnvironmentVariables()
                    .build();
                settings = new Settings();
                config.Bind(settings);
                return settings;
            }
        }
    }
}
