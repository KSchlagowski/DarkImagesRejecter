using System;
using System.Drawing;
using System.IO;

namespace Scalac
{
    public class FileProcesser
    {
        Configurer configurer = new Configurer();
        ScaleConverter scaleConverter = new ScaleConverter();
        FileCopier fileCopier = new FileCopier();
        BrightnessMeasurer brightnessMeasurer = new BrightnessMeasurer();
        public void FileProcessing(string fileFormat)
        {
            int maxDarkness = configurer.ConfigDarkness();
            string dirPathIn = configurer.ConfigPathIn();
            string dirPathOut = configurer.ConfigPathOut();

            System.Console.WriteLine(fileFormat);
            string[] fileEntries = Directory.GetFiles(dirPathIn, "*" + fileFormat);
            foreach(string filePath in fileEntries)
            {
                System.Console.WriteLine(filePath);

                string fileName = filePath.Replace(dirPathIn, "");
                System.Console.WriteLine(fileName);
                var image = new Bitmap(filePath, true);               
                
                int Y = scaleConverter.ConvertToZeroHundretScale(brightnessMeasurer.GetLumaChannel(image));
                System.Console.WriteLine(Y);

                if (maxDarkness >= Y)
                {
                    string DestinName = fileName.Replace(fileFormat, "") + "_bright_" + Y + fileFormat;
                    fileCopier.CopyFile(dirPathIn, dirPathOut, fileName, DestinName);
                }
                else if (maxDarkness < Y)
                {
                    string DestinName = fileName.Replace(fileFormat, "") + "_dark_" + Y + fileFormat;
                    fileCopier.CopyFile(dirPathIn, dirPathOut, fileName, DestinName);
                }
                else
                {
                    throw new ArgumentException("Unexpected error");
                }  
            } 
        }
    }
}