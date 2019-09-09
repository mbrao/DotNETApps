using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//DocumentFormat.OpenXml
//ClosedXML
namespace _02_ClosedXML
{
    class Program
    {
        public static void ExportDataSetToExcel(DataSet ds)
        {
            string AppLocation = "";
            AppLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            AppLocation = AppLocation.Replace("file:\\", "");
            string date = DateTime.Now.ToShortDateString();
            date = date.Replace("/", "_");
            string filepath = AppLocation + "\\ExcelFiles\\" + "RECEIPTS_COMPARISON_" + date + ".xlsx";

            using (XLWorkbook wb = new XLWorkbook())
            {
                for (int i = 0; i < ds.Tables.Count; i++)
                {
                    wb.Worksheets.Add(ds.Tables[i], ds.Tables[i].TableName);
                }
                wb.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                wb.Style.Font.Bold = true;
                wb.SaveAs(filepath);
            }
        }
        static void Main(string[] args)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Country");
            dt.Rows.Add("Venkatesh", "India");
            dt.Rows.Add("Santhosh", "USA");
            dt.Rows.Add("Venkat Sai", "Dubai");
            dt.Rows.Add("Venkat Teja", "Pakistan");
            ds.Tables.Add(dt);
            ExportDataSetToExcel(ds);

            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}
