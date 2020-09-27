using System;

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


            return base64String;
        }
    }
}
