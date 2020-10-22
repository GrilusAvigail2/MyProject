using ExcelDataReader;
using Newtonsoft.Json;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
namespace TryExcel

namespace ReadAndWriteData
{
    class ConnectToExcel
    {

        static void Main(string[] args)
        {

            //epplus
            // קריאה מאקסל גרסה ב

            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            using (var package = new ExcelPackage(new FileInfo("..\\..\\..\\..\\excel1.xlsx")))
            {
                var firstSheet = package.Workbook.Worksheets["aaa"];

                Console.WriteLine("Sheet 1 Data");
                Console.WriteLine($"Cell A2 Value   : {firstSheet.Cells["A2"].Text}");
                Console.WriteLine($"Cell A2 Color   : {firstSheet.Cells["A2"].Style.Font.Color.LookupColor()}");
                Console.WriteLine($"Cell B2 Formula : {firstSheet.Cells["B2"].Formula}");
                Console.WriteLine($"Cell B2 Value   : {firstSheet.Cells["B2"].Text}");
                Console.WriteLine($"Cell B2 Border  : {firstSheet.Cells["B2"].Style.Border.Top.Style}");
                Console.WriteLine("");


            }

            List<string> names = new List<string>() { "apple", "orange", "banana" };
            // כתיבה לאקסל 
            using (var excelPack = new ExcelPackage(new FileInfo("..\\..\\..\\..\\excel1.xlsx")))
            {
                var ws = excelPack.Workbook.Worksheets["aaa"];
                ws.Cells.LoadFromText("asdfasd");
                ws.Cells.LoadFromCollection(names);
                excelPack.Save();

            }

            Console.WriteLine("Hello World!");
        }
    }
}

