using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace PdfGenerator.Utils
{
    class Base64Images
    {
        public Dictionary<string, string> images = new Dictionary<string, string>();

        public Base64Images()
        {
            LoadJson();
        }


        public void LoadJson()
        {
            using (StreamReader r = new StreamReader(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\", "") + @"\\Files\\Base64File.json"))
            {
                string json = r.ReadToEnd();
                images = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            }
        }
    }
}
