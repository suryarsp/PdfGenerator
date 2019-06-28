using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfGenerator.Utils
{
    class Utilities
    {

        public int calculateLevel(string Level)
        {
            int originalLevel = 0;
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


        public string getImageByFileName(string fileName)
        {
            string extension = "";
            Base64Images base64 = new Base64Images();
            base64.LoadJson();
            var fileExtension = base64.images;
            string currentfileExtension;
            return extension;
        }
            //    if (name.indexOf(".") !== -1)
            //    {
            //        const lastIndex = name.lastIndexOf(".");
            //        extension = name.substr(lastIndex + 1, name.length - 1).toLowerCase();
            //    }
            //    else
            //    {
            //        currentfileExtension = fileExtension.FirstOrDefault(p => p.Key == "Default").Value;
            //    }
            //    switch (extension)
            //    {
            //        case "pdf":
            //            currentfileExtension = fileExtension.pdf;
            //            break;

            //        case "folder":
            //            currentfileExtension = fileExtension.folder;
            //            break;

            //        case "ppt":
            //            currentfileExtension = fileExtension.ppt;
            //            break;

            //        case "doc":
            //            currentfileExtension = fileExtension.doc;
            //            break;

            //        case "png":
            //            currentfileExtension = fileExtension.png;
            //            break;

            //        case "docx":
            //            currentfileExtension = fileExtension.docx;
            //            break;

            //        case "jpg":
            //            currentfileExtension = fileExtension.jpg;
            //            break;


            //        case "xlsx":
            //            currentfileExtension = fileExtension.xlsx;
            //            break;

            //        case "csv":
            //            currentfileExtension = fileExtension.csv;
            //            break;

            //        case "pptx":
            //            currentfileExtension = fileExtension.pptx;
            //            break;

            //        default:
            //            currentfileExtension = fileExtension.default;
            //    }
            //    return currentfileExtension;
            //}
        }
    }