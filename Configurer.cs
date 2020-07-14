using System;
using System.IO;

namespace Scalac
{
    public class Configurer
    {
        public int ConfigDarkness()
        {
            string textFile = Directory.GetCurrentDirectory() + @"\config.txt"; 
            string[] lines = File.ReadAllLines(textFile);  
            
            int maxDarkness = Convert.ToInt32(lines[0].Replace("maxDarkness=", ""));

            return maxDarkness;
        }
        public string ConfigPathIn()
        {
            string textFile = Directory.GetCurrentDirectory() + @"\config.txt"; 
            string[] lines = File.ReadAllLines(textFile);  
            
            string dirPathIn = lines[1].Replace("dirPathIn=", "");

            return dirPathIn;
        }
        public string ConfigPathOut()
        {
            string textFile = Directory.GetCurrentDirectory() + @"\config.txt"; 
            string[] lines = File.ReadAllLines(textFile);  
            
            string dirPathOut = lines[2].Replace("dirPathOut=", "");

            return dirPathOut;
        }
    }
}