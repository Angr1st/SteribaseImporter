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
        public static readonly string newFolder = "newFolder";
        public static readonly string processedFolder = "processedFolder";
        public static readonly string failedFolder = "failedFolder";
        public static readonly string order = "order";

        public static string GetConfigValue(ConfigValues configValue) => ConfigurationManager.AppSettings[configValue.ToString()];
    }
}
