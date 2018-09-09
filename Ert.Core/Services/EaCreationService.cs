using System;
using System.Collections.Generic;
using System.IO;
using OfficeOpenXml;

namespace Ert.Core.Services
{
    public class EaCreationService
    {

        public EaCreationService()
        {


        }

        Dictionary<string, IEnumerable<string>> ButtonRemoveList = new Dictionary<string, IEnumerable<string>>();

        Dictionary<string, IEnumerable<string>> WorksheetHiddeList = new Dictionary<string, IEnumerable<string>>();

        /// <summary>
        /// Abfrage aus der Datenbank? 
        /// </summary>
        private void LoadButtonRemoveList() {

        }

        /// <summary>
        /// Abfrage aus der Datenbank
        /// </summary>
        private void LoadSheetHiddeList(){

        }

        private void LoadTemplate(){

        }

        public void RemoveButtons(IEnumerable<string> buttonNames, ExcelWorksheet ws)
        {
                foreach (var b in buttonNames)
                {

                    try
                    {
                        ws.Drawings.Remove(b);
                    }
                    catch (Exception exp)
                    {

                    }

                }
        }

        public void HiddeSheets(IEnumerable<string> sheetNames, ExcelWorkbook workbook)
        {
            foreach (var name in sheetNames){
               
                workbook.Worksheets[name].Hidden = eWorkSheetHidden.Hidden;
            }
        }

        public void CreateEaFromTemplate(){

            using (var p = new ExcelPackage()){

                    //A workbook must have at least on cell, so lets add one... 
                    var ws = p.Workbook.Worksheets.Add("MySheet");
                //To set values in the spreadsheet use the Cells indexer.
                ws.Cells["A1"].Value = "This is cell A1";
                //Save the new workbook. We haven't specified the filename so use the Save as method.

                p.SaveAs(new FileInfo(@"c:\workbooks\myworkbook.xlsx"));
            }
        }
    }
}
