using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eticaret.WebUI.Helpers
{
    public static class FileHelper
    {
        public static string SaveFile(HttpPostedFileBase FilePost)
        {
            if (FilePost != null)
            {
                //string pic = Path.GetFileName(file.FileName);
                string yer = string.Format("/images/{0}/{1}", DateTime.Now.Year, DateTime.Now.Month);
                string path = HttpContext.Current.Server.MapPath(yer);
                // file is uploaded
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                string dosyaAdi = Guid.NewGuid().ToString() + Path.GetExtension(FilePost.FileName);
                path = Path.Combine(path, dosyaAdi);
                FilePost.SaveAs(path);

                // save the image path path to the database or you can send image 
                // directly to database
                // in-case if you want to store byte[] ie. for DB
                using (MemoryStream ms = new MemoryStream())
                {
                    FilePost.InputStream.CopyTo(ms);
                    byte[] array = ms.GetBuffer();
                }

                return yer + "/" + dosyaAdi;
            }
            else
            {
                return null;
            }            
        }
    }
}