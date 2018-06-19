using System.Configuration;

namespace Eticaret.CommonLibrary.Helpers
{
    public static class ConfigHelper
    {
        public static string Read(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
