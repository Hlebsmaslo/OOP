using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Lab3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imgp = @"D:\контент\";

            Func<Bitmap, Bitmap> gr = Grayscale;
            Func<Bitmap, Bitmap> f = Rotate90;

            Func<Bitmap, Bitmap> prf = gr;
            prf += f;

            Action<Bitmap> d = Display;

            string[] img = Directory.GetFiles(imgp);
            foreach (string imgf in img)
            {
                Bitmap oimg = new Bitmap(imgf);
                Bitmap pimg = prf(oimg);
                d(pimg);
            }
        }

        static Bitmap Grayscale(Bitmap oimg)
        {
            Bitmap pimg = new Bitmap(oimg.Width, oimg.Height);

            for (int x = 0; x < oimg.Width; x++)
            {
                for (int y = 0; y < oimg.Height; y++)
                {
                    Color px = oimg.GetPixel(x, y);
                    int grscale = (int)((px.R * 0.3) + (px.G * 0.59) + (px.B * 0.11));
                    Color grcolor = Color.FromArgb(grscale, grscale, grscale);
                    pimg.SetPixel(x, y, grcolor);
                }
            }

            return pimg;
        }

        static Bitmap Rotate90(Bitmap oimg)
        {
            Bitmap pimg = new Bitmap(oimg.Height, oimg.Width);

            for (int x = 0; x < oimg.Width; x++)
            {
                for (int y = 0; y < oimg.Height; y++)
                {
                    Color px = oimg.GetPixel(x, y);
                    pimg.SetPixel(y, oimg.Width - x - 1, px);
                }
            }

            return pimg;
        }

        static void Display(Bitmap img)
        {
            int w = img.Width;
            int h = img.Height;

            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    Color pcolor = img.GetPixel(x, y);

                    if (pcolor.GetBrightness() < 0.5)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write(",");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
