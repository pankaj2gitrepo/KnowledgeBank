using Aspose.BarCode;
using BarcodeLib.BarcodeReader;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace QrCodeReaderWriter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string qrCodeImageFilePath = "D:/Pankaj/StudyP/HelpCode/QrCodeRead/QrCodeReaderWriter/Library/QR.jpg";
            string qrCroppedCodeImageFilePath = "D:/Pankaj/StudyP/HelpCode/QrCodeRead/QrCodeReaderWriter/Library/QR_Cropped.jpg";
            // Write QR Code
            BarCodeBuilder b = new BarCodeBuilder();
            b.SymbologyType = Symbology.QR;
            b.CodeText = "filler1234567890";
            b.Save(qrCodeImageFilePath, BarCodeImageFormat.Png);
            // Resize the image and save again
            Rectangle cropRect = new Rectangle(10, 14, 52, 50);
            Bitmap src = Image.FromFile(qrCodeImageFilePath) as Bitmap;
            Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

            using (Graphics graphics = Graphics.FromImage(target))
            {
                graphics.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height),
                                 cropRect,
                                 GraphicsUnit.Pixel);
            }
            target.Save(qrCroppedCodeImageFilePath);

            // Read QR Code
            string[] results = BarcodeReader.read(qrCroppedCodeImageFilePath, BarcodeReader.QRCODE);
        }
    }
}
