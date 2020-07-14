using System;


namespace Scalac
{
    public class ScaleConverter
    {
        public int ConvertToZeroHundretScale(double Y)
        {
            Y = Y/255 * 100;
            int Y1 = Convert.ToInt32(Y);
            Y1 = 100 - Y1;

            return Y1;
        }
    }
}