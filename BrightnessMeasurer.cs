using System.Drawing;

namespace Scalac
{
    public class BrightnessMeasurer
    {
        public double GetLumaChannel(Bitmap bmp)
        {
            int r = 0;
            int g = 0;
            int b = 0;

            int total = 0;

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color clr = bmp.GetPixel(x, y);

                    r += clr.R;
                    g += clr.G;
                    b += clr.B;

                    total++;
                }
            }

            //Calculate average
            r /= total;
            g /= total;
            b /= total;

            System.Console.WriteLine("r " + r + " g " + g + " b " + b);

            double Y = 0.299*r + 0.587*g + 0.1114*b;

            return (Y);
        }
    }
}