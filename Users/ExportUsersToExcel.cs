using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Proyecto_Final.Users
{
    class ExportUsersToExcel
    {
        public static void Export(string filename)
        {
            Request.UserRequests usersRequest = new Request.UserRequests();
            Excel.Application appExcel = new Excel.Application();
            Excel.Workbook workBookExcel = null;
            Excel.Worksheet workSheetExcel = null;
            workBookExcel = appExcel.Workbooks.Open(Directory.GetCurrentDirectory() + "/usersReport");
            workSheetExcel = (Excel.Worksheet)workBookExcel.Worksheets.get_Item(1);
            appExcel.DisplayAlerts = false;
            int i = 2;
            foreach (JSON.User user in usersRequest.getAllUsersData())
            {
                workSheetExcel.Cells[i, 1] = user._id;
                workSheetExcel.Cells[i, 2] = user.id_prov;
                workSheetExcel.Cells[i, 3] = user.name;
                workSheetExcel.Cells[i, 4] = user.lastname;
                workSheetExcel.Cells[i, 5] = user.email;
                workSheetExcel.Cells[i, 6] = user.password;
                workSheetExcel.Cells[i, 7] = user.gender;
                workSheetExcel.Cells[i, 8] = user.avatar;
                workSheetExcel.Cells[i, 9] = user.mac;
                workSheetExcel.Cells[i, 10] = Utils.UserStatus.numToString(user.status);
                workSheetExcel.Cells[i, 11] = user.positivePoints;
                workSheetExcel.Cells[i, 12] = user.negativePoints;
                i++;
            }
            workBookExcel.SaveAs(filename);
            workBookExcel.Close(true);//guardar los cambios:true
            appExcel.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(appExcel);
        }
    }
}
