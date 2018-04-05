using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Proyecto_Final.Incidences
{
    class ExportIncidencesToExcel
    {
        public static void Export(string filename)
        {
            Request.IncidenceRequest incidenceRequest = new Request.IncidenceRequest();
            Excel.Application appExcel = new Excel.Application();
            Excel.Workbook workBookExcel = null;
            Excel.Worksheet workSheetExcel = null;
            workBookExcel = appExcel.Workbooks.Open(Directory.GetCurrentDirectory() + "/incidenceReport");
            workSheetExcel = (Excel.Worksheet)workBookExcel.Worksheets.get_Item(1);
            appExcel.DisplayAlerts = false;
            int i = 2;
            foreach (JSON.Incidence inc in incidenceRequest.getAllIncidencesData())
            {
                workSheetExcel.Cells[i, 1] = inc._id;
                workSheetExcel.Cells[i, 2] = inc.userId;
                workSheetExcel.Cells[i, 3] = inc.title;
                workSheetExcel.Cells[i, 4] = inc.date;
                workSheetExcel.Cells[i, 5] = Utils.IncidenceCategory.NumToString(inc.category);
                workSheetExcel.Cells[i, 6] = inc.lat;
                workSheetExcel.Cells[i, 7] = inc.lng;
                workSheetExcel.Cells[i, 8] = Utils.IncidenceStatus.NumToString(inc.status);
                workSheetExcel.Cells[i, 9] = inc.street;
                workSheetExcel.Cells[i, 10] = inc.imageName;
                workSheetExcel.Cells[i, 11] = inc.mac;
                workSheetExcel.Cells[i, 12] = inc.streetbyUser;
                workSheetExcel.Cells[i, 13] = inc.resolutionDate;
                i++;
            }
            workBookExcel.SaveAs(filename);
            workBookExcel.Close(true);//guardar los cambios:true
            appExcel.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(appExcel);
        }
    }
}
