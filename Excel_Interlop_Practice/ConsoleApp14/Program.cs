using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\Ameer Hamza\Desktop\New folder\sheet.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRng = xlWorksheet.UsedRange;

            xlRng.Cells[2, 10] = Console.ReadLine();
            xlWorkbook.SaveAs(@"C:\Users\Ameer Hamza\Desktop\New folder\sheet.xlsx");
            //xlWorkbook.Close();


            //Excel.Application xlApp1 = new Excel.Application();
            //Excel.Workbook xlWorkbook1 = xlApp1.Workbooks.Open(@"C:\Users\Ameer Hamza\Desktop\New folder\oldsheet.xlsx");
            //Excel._Worksheet xlWorksheet1 = xlWorkbook1.Sheets[1];
            //Excel.Range xlRange1 = xlWorksheet1.UsedRange;

            if (xlRng.Cells[4,9] != null && xlRng.Cells[4,9].Value2 != null)
            Console.Write(xlRng.Cells[4,9].Value2.ToString() + "\t");
            xlWorkbook.Close();

        }
    }
}
