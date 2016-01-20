using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;

namespace TheBest.Utils
{
    public class ImageConverter
    {
        public Image GetImageFromFile(HttpPostedFileBase file)
        {
            return Image.FromStream(file.InputStream, true, true);
        }

        public Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public void SaveImage(Bitmap image, string fileName, bool icon = true)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                using (FileStream fs = new FileStream(BuildFilePath(fileName, icon), FileMode.Create, FileAccess.ReadWrite))
                {
                    image.Save(memory, ImageFormat.Jpeg);
                    byte[] bytes = memory.ToArray();
                    fs.Write(bytes, 0, bytes.Length);
                }
            }
        }

        public string BuildFilePath(string fileName, bool icon = true)
        {
            string virtualPath = string.Empty;

            string folder = string.Empty;

            if (icon)
            {
                folder = "Icons";
            }
            else
            {
                folder = "Thumbnails";
            }

            virtualPath = string.Format("~/Content/Images/Students/{0}/{1}.jpg", folder, fileName);

            return System.Web.HttpContext.Current.Server.MapPath(virtualPath);
        }

        public string BuildVirtualPath(string fileName, bool icon)
        {
            var folder = icon ? "Icons" : "Thumbnails";

            return string.Format("Content/Images/Students/{0}/{1}.jpg", folder, fileName);
        }
    }
}