using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace SteribaseImporter
{
    public enum ConfigValues
    {
        newFolder,
        processedFolder,
        failedFolder,
        order
    }

    class ConfigHandler
    {
        public static string GetConfigValue(ConfigValues configValue) => ConfigurationManager.AppSettings[configValue.ToString()];
    }
}
