using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//QRCoder 
namespace _04_QR_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath ="Img_" + DateTime.Now.ToString("ddMMyyyyhhmmss") + ".jpg";

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("for more details visit http://www.google.co.in", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);//20 is Pixels per module
            qrCodeImage.Save(filepath, ImageFormat.Png);

            Console.ReadKey();
        }
    }
}
