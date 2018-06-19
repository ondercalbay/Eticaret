using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
