using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public static class Classecor
    {
        public static Color SecundaryColor { get; set; }
        public static Color PrimaryColor { get; set; }


        public static List<string> ColorList = new List<string>()
       {
         "#D8BFD8",
         "#FF1493",
         "#FF69B4",

        };

        public static Color ChangeColorBrightness(Color Color, double correctionFactor)
        {
            double red = Color.R;
            double green = Color.G;
            double blue = Color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }

            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(Color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
