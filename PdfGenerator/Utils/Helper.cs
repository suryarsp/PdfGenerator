using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfGenerator.Utils
{
    class Helper
    {
        public float calculateLevel(string Level)
        {
            float originalLevel = 0f;
            // Start folder
            if (Level.Split('.')[1] == "0" && Level.Split('.').Length == 2)
            {
                return originalLevel;
            }

            // start folder files
            if (Level.Split('.')[1] == "0" && Level.Split('.').Length > 2)
            {
                return Level.Split('.').Length - 2;
            }

            originalLevel = Level.Split('.').Length - 1;
            return originalLevel;
        }


        public string getBase64ImageByFileName(string fileName)
        {
            String extension = "";
            Base64Images base64 = new Base64Images();
            var fileExtension = base64.images;
            String currentfileExtension;
            if (fileName.IndexOf(".") != -1)
            {
                int lastIndex = fileName.LastIndexOf(".");
                extension = fileName.Substring(lastIndex + 1).ToLower();
            }
            else
            {
                currentfileExtension = fileExtension.FirstOrDefault(p => p.Key == "default").Value;
            }
            switch (extension)
            {
                case "pdf":
                    currentfileExtension = fileExtension.FirstOrDefault(p => p.Key == "pdf").Value;
                    break;

                case "folder":
                    currentfileExtension = fileExtension.FirstOrDefault(p => p.Key == "folder").Value;
                    break;

                case "ppt":
                    currentfileExtension = fileExtension.FirstOrDefault(p => p.Key == "ppt").Value;
                    break;

                case "doc":
                    currentfileExtension = fileExtension.FirstOrDefault(p => p.Key == "doc").Value;
                    break;

                case "png":
                    currentfileExtension = fileExtension.FirstOrDefault(p => p.Key == "png").Value;
                    break;

                case "docx":
                    currentfileExtension = fileExtension.FirstOrDefault(p => p.Key == "docx").Value;
                    break;

                case "jpg":
                    currentfileExtension = fileExtension.FirstOrDefault(p => p.Key == "jpg").Value;
                    break;

                case "xlsx":
                    currentfileExtension = fileExtension.FirstOrDefault(p => p.Key == "xlsx").Value;
                    break;

                case "csv":
                    currentfileExtension = fileExtension.FirstOrDefault(p => p.Key == "csv").Value;
                    break;

                case "pptx":
                    currentfileExtension = fileExtension.FirstOrDefault(p => p.Key == "pptx").Value;
                    break;

                default:
                    currentfileExtension = fileExtension.FirstOrDefault(p => p.Key == "default").Value;
                    break;
            }
            return currentfileExtension;
        }

        //public string convertCurrentDate()
        //{
        //    string dateString = DateTime.Today.ToString();
        //    string convertedDateString = dateString.Split(' ').(1, 4);
        //    string timezone = dateString.replace(/^.* GMT.*\(/, "").replace(/\)$/, "");
        //    string timeString = new Date().toLocaleTimeString();
        //    string time = timeString.slice(0, timeString.lastIndexOf(':'));
        //    string returnDateString = '';
        //    convertedDateString.forEach((s, index) =>
        //    {
        //        returnDateString += (index === 0) ? s : (index === convertedDateString.length - 2) ? ', ' + s : ' ' + s;
        //    });
        //    returnDateString += ' ' + time + ' ' + '(' + timezone + ')';
        //    return returnDateString;
        //}
    }
}

