using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using PRO.Global;


namespace PRO.Global
{
   public class EImage
    {


        public static Image ResizeImage(Image img, Size size)
        {
            int sourceWidth = img.Width;
            int sourceHeight = img.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            b.SetResolution(img.HorizontalResolution, img.VerticalResolution);

            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(img, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;
        }
        public static byte[] ImageToByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        public static Image ByteToImage(byte[] arr)
        {
            using (MemoryStream ms = new MemoryStream(arr))
            {
                Image img = Image.FromStream(ms);
                return img;
            }
        }

        public static MemoryStream ByteToStream(byte[] buffer)
        {
            return new MemoryStream(buffer);
        }

        public static byte[] StreamToByte(System.IO.MemoryStream MStream)
        {

            byte[] byteArray = new byte[MStream.Length];
            MStream.Read(byteArray, 0, System.Convert.ToInt32(MStream.Length));
            MStream.Close();
            return byteArray;
        }
        public static byte[] FileToByte(string Filename)
        {
            FileStream fs = new FileStream(Filename, FileMode.Open, FileAccess.Read);
            byte[] ImageData = new byte[fs.Length];
            fs.Read(ImageData, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return ImageData;
        }

    }
}
