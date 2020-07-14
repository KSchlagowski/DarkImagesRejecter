using System;
using System.Collections.Generic;

namespace Scalac
{
    class Program
    {

        static void Main(string[] args)
        {
            FileProcesser fileProcesser = new FileProcesser();
            var errors = new List<string>();
            
            try
            {
            fileProcesser.FileProcessing(".jpg");
            fileProcesser.FileProcessing(".jpeg");
            fileProcesser.FileProcessing(".png");
            }
            catch(FormatException ex) 
            { 
                errors.Add(ex.Message);
            }

            System.Console.WriteLine(errors);
        }
    }
}