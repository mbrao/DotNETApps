using SelectPdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//selectpdf
namespace _03_HtmlToPdf
{
    class Program
    {
        static void PreparePDF(string url)
        {
            string AppLocation = "";
            AppLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            AppLocation = AppLocation.Replace("file:\\", "");
            string date = DateTime.Now.ToShortDateString();
            date = date.Replace("/", "_");
            string filepath = AppLocation + "\\PDFFiles\\" + "URL_to_PDF_" + date + ".pdf";

            // instantiate the html to pdf converter 
            HtmlToPdf converter = new HtmlToPdf();

            // convert the url to pdf 
            PdfDocument doc = converter.ConvertUrl(url);

            // save pdf document 
            doc.Save(filepath);

            // close pdf document 
            doc.Close();
        }
        static void Main(string[] args)
        {
            PreparePDF("https://code.cognizant.com/");
            Console.ReadKey();
        }
    }
}
