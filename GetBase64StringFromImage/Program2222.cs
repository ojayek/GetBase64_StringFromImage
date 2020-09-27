using System;
using System.Xml;

namespace GetBase64StringFromImage
{
    class Program
    {
        static void Main(string[] args)
        {
            string imagePath = @"E:\sample.png";
            string imgBase64String = GetBase64StringForImage(imagePath);
            Console.WriteLine(imgBase64String);
        }
        protected static string GetBase64StringForImage(string imgPath)
        {
            byte[] imageBytes = System.IO.File.ReadAllBytes(imgPath);
            string base64String = Convert.ToBase64String(imageBytes);
            string lines =  base64String ;
            System.IO.File.WriteAllText(@"E:\_MIS_Moalemi\ECE\GetBase64StringFromImage\GetBase64StringFromImage\WriteLines2.txt", lines);
            // Create a new file in C:\\ dir  
            XmlTextWriter ECEWriter = new XmlTextWriter("E:\\myXmFile.xml", null);
            // Opens the document  
            ECEWriter.WriteStartDocument();
            // Write comments  
            ECEWriter.WriteComment("First Comment XmlTextWriter ECE Example");
            ECEWriter.WriteComment("myXmlFile.xml in E root dir");
            // Write first element  
            ECEWriter.WriteStartElement(".PNG ImageAttach");
            ECEWriter.WriteStartElement("r", "RECORD", "record");
            // Write next element  
            ECEWriter.WriteStartElement("Name", "");
            ECEWriter.WriteString(base64String);
            ECEWriter.WriteEndElement();
            // Write one more element  
            ECEWriter.WriteStartElement("Address", "");
            ECEWriter.WriteString("ece-@moshanir.co");
            ECEWriter.WriteEndElement();
            // WriteChars  
            char[] ch = new char[4];
            ch[0] = 'M';
            ch[1] = 'A';
            ch[2] = 'I';
            ch[3] = 'L';
            ECEWriter.WriteStartElement("Char");
            ECEWriter.WriteChars(ch, 0, ch.Length);
            ECEWriter.WriteEndElement();
            // Ends the document.  
            ECEWriter.WriteEndDocument();
            // close writer  
            ECEWriter.Close();

            return lines;
        }
    }
}
