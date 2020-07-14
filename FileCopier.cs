using System;
using System.IO;

namespace Scalac
{
    public class FileCopier
    {
        public void CopyFile(string Source, string Destin, string SourceName, string DestinName)
        {
            File.Copy(Source + SourceName, Destin + DestinName);

            Console.WriteLine("Done");
            System.Console.WriteLine();
        }
    }
}