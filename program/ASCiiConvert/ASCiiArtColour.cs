using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;

namespace ASCiiConvert
{
    public class ASCiiArtColour
    {
        // call where your image location is
        private string imageLocation = @"C:\Users\Jason\Desktop\image";
        public ASCiiArtColour(string ImageLocation)
        {
            this.imageLocation = ImageLocation;
        }
        private string pixels = " .-+*wGHM#&%";
        // Name and call your method here
        public void Go(string saveLocation = @"C:\Users\Jason\Desktop\thisTime.txt")
        {
            // Remember to call where your's is located!!!
            var img = new Bitmap(imageLocation = @"C:\Users\Jason\Desktop\image\SD.jpg");
            using(var wrtr = new StreamWriter(saveLocation))
            {
                for(var y = 0; y < img.Height; y++)
                {
                    for(var x = 0; x <img.Width; x++)
                    {
                        var color = img.GetPixel(x, y);
                        var brightness = Brightness(color);
                        var id = brightness / 255 * (pixels.Length-1);
                        var px = pixels[pixels.Length - (int)Math.Round(id) -1];
                        wrtr.Write(px);
                      
                    }
                    wrtr.WriteLine();
                }
            }
        }
        // I found this on the Internet and it works for the brightness
        private static double Brightness(Color c)
        {
            return Math.Sqrt(
                c.R * c.R * .241 +
                c.G * c.G * .691 +
                c.B * c.B * .068);
        }
    }
}
