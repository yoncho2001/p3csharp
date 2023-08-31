using System;
using System.Net;
using System.IO;


using functions;

namespace task4
{
    public class FileDownloader
    {
        public static void Result()
        {
            string path;

            try
            {
                path = Functions.CanString();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Null input is not allowed");
                return;
            }

            FileDownloader downloader = new FileDownloader();
            Task<String> extension =  downloader.GetFileExtention(path);

            using (WebClient client = new WebClient())
            {
                client.DownloadFile(path, "image" + extension.Result);
            }           
        }

        public async Task<String> GetFileExtention(string url)
        {
            string ext = "";
            try
            {
                if (Path.HasExtension(url))
                {
                    ext = Path.GetExtension(url);
                    ext = ext.Contains('?') || ext.Contains('=') ? ext.Substring(0, ext.LastIndexOf("?")) : ext;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            return ext;
        }
    }
}
