using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PRO.Global
{
    public static class ExFunction
    {

        public static string ExcelDosyaSec()
        {
            OpenFileDialog rs = new OpenFileDialog();
            rs.Filter = " Excel Dosya |*.XLS| Excel Dosya- Yeni|*.XLSX";
            rs.Title = "Excel Dosya Seç";
            
            if (rs.ShowDialog() == DialogResult.OK)
                return rs.FileName.ToString();
            else
                return "";


        }

        public static DataTable GetExcelData()
        {
            string _file = ExcelDosyaSec();
            if (_file == "") return null;


            string bagExcel = "Provider=Microsoft.Jet.OleDB.4.0; Data Source=" + _file + "; Extended Properties=Excel 8.0";
            string sorgu = "select * from [Data$] ";
            OleDbDataAdapter adb = new OleDbDataAdapter(sorgu, bagExcel);
             DataTable dt = new DataTable();
            adb.Fill(dt);
            return dt;
            
        }


    }
}
