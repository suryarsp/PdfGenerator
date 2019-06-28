using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfGenerator
{
    class ItemModel
    {
        public string Level { get; set; }
        public string Text { get; set; }
        public int Type { get; set; }


        public ItemModel(string level, string text, int type)
        {
            Level = level;
            Text = text;
            Type = type;
        }
    }
}
