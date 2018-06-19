using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.CommonLibrary.Helpers
{
    public class FileHelper
    {
        public static string MapPath(string path)
        {
            return HttpContext.Current.Server.MapPath(path);
        }

        public static string ReadFile(string path)
        {
            return File.ReadAllText(MapPath(path));
        }
    }
}
