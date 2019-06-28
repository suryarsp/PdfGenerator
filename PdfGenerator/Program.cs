using System;
using System.IO;
using System.Diagnostics;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using PdfGenerator.Utils;

namespace PdfGenerator
{
    class Program
    {

        List<ItemModel> items  = new List<ItemModel>();
        List<PdfPCell> cells = new List<PdfPCell>();
        public float[] directoryColumnWidths = { 50, 525 };
        PdfPageEventHelper events = new PdfPageEventHelper();
        static void Main(string[] args)
        {
            Program p =  new Program();
            p.printPdf();
            Base64Images img = new Base64Images();
            img.LoadJson();
        }

        public void printPdf()
        {
            Document document = new Document();
            FileStream fs = new FileStream("D:/Chapter1_Example1.pdf", FileMode.Create, FileAccess.Write);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            // Open the document to enable you to write to the document  
            document.Open();
            PdfPTable printedInfoTable = new PdfPTable(1);
            printedInfoTable.WidthPercentage = 109.8f;

            
            PdfPCell printedBy  = new PdfPCell(new Phrase("Printed By : " + "Surya" + "\n\n", FontFactory.GetFont("Helvetica", 11, Font.NORMAL)));
            printedBy.DisableBorderSide( Rectangle.BOTTOM_BORDER);
            printedInfoTable.AddCell(printedBy);

            PdfPCell printedOn = new PdfPCell(new Phrase("Printed On : " + DateTime.Now + "\n", FontFactory.GetFont("Helvetica", 11, Font.NORMAL)));
            printedOn.DisableBorderSide(Rectangle.BOTTOM_BORDER | Rectangle.TOP_BORDER);
            printedInfoTable.AddCell(printedOn);

            PdfPTable directoryTable = new PdfPTable(2);
             
            directoryTable.WidthPercentage = 100f;
            // STEP 2: Set the widths of the table columns
            directoryTable.SetTotalWidth(directoryColumnWidths);
            directoryTable.SetWidths(directoryColumnWidths);
            // STEP 3: Set the table width to not resize    
            directoryTable.LockedWidth = true;

            for (int i = 0; i < 100; i++)
            {
                items.Add(new ItemModel("1." + i, "Folder" + i, 1));
            }
            // we add a cell with colspan 3
            var base64Data = Convert.FromBase64String("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");

            var image = Image.GetInstance(base64Data);
            image.ScaleAbsolute(15f, 15f);
            image.ScalePercent(20.0F);

            Font font1 = new Font(Font.FontFamily.HELVETICA, 11, Font.NORMAL);
            PdfPCell levelHeader = new PdfPCell(new Phrase("#", font1));
            Font font2 = new Font(Font.FontFamily.HELVETICA, 11, Font.NORMAL);
            font2.Color = BaseColor.BLUE;
            PdfPCell titleHeader = new PdfPCell(new Phrase("Title", font2));
            titleHeader.PaddingLeft = 20f;

            directoryTable.AddCell(levelHeader);
            directoryTable.AddCell(titleHeader);
            foreach (var folders in items)
            {
                var level = new PdfPCell(new Phrase(folders.Level, FontFactory.GetFont("Helvetica", 10 , Font.NORMAL)));
                cells.Add(level);
                Paragraph p = new Paragraph();
                Phrase phrase = new Phrase();
                p.Alignment = Element.ALIGN_LEFT;
                p.Add(new Chunk(image, 0, 0));
                p.Add(new Phrase(folders.Text, FontFactory.GetFont("Helvetica", 10, Font.NORMAL)));
                var textAndImage = new PdfPCell();
                textAndImage.AddElement(p);
                textAndImage.PaddingLeft = 20f;
                cells.Add(textAndImage);
            }
            
            foreach(var c in cells)
            {
                directoryTable.AddCell(c);
            }

            printedInfoTable.SpacingAfter = 0f;
            directoryTable.SpacingBefore = 0.6f;

            document.Add(printedInfoTable);
            document.Add(directoryTable);
            document.Close();
            // Close the writer instance  
            writer.Close();
            // Always close open filehandles explicity  
            fs.Close();
        }
    }
}
