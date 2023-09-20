using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.OleDb;
using System.Data;

namespace PRO.Global
{
    public class ExcelHelper
    {


        #region Read

        private static string connectionString = string.Empty;
        private static ExcelExtention excelExtention = ExcelExtention.xls;

        public static DataSet Read(string path, bool ekcolumn = false)
        {
            excelExtention = GetExcelExtention(path);            
            return Read(path, GetWorkSheets(GetConnectionString(path)), ekcolumn);
        }

        private static ExcelExtention GetExcelExtention(string path)
        {
            string extention = path.Split('.')[path.Split('.').Length - 1];
            if (extention.Trim() == ExcelExtention.xlsx.ToString())
                return ExcelExtention.xlsx;
            else
                return ExcelExtention.xls;

        }

        private static string GetConnectionString(string path)
        {
            if (excelExtention == ExcelExtention.xls)
                connectionString = string.Format("Provider=Microsoft.Jet.OleDb.4.0;data source={0};Extended Properties=Excel 8.0;", path);
            else if (excelExtention == ExcelExtention.xlsx)
                connectionString = string.Format("Provider=Microsoft.ACE.OleDb.12.0; data source={0}; Extended Properties=Excel 8.0;", path);
            return connectionString;
        }

        private static DataSet Read(string path, string[] workSheets, bool ekcolumn = false)
        {

            var ds = new DataSet();
            if (workSheets.Count()>0)
            {
                string workSheet = workSheets[0];
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(string.Format("SELECT * FROM [{0}]", workSheet), GetConnectionString(path)))
                {
                    adapter.Fill(ds, workSheet);
                }
            }
            if (ekcolumn)
            {
                ds.Tables[0].Columns.Add("ExcelKontrol", typeof(string));
            }
            return ds;

        }

        private static string[] GetWorkSheets(string connectionString)
        {
            DataTable dataTable;
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    dataTable = connection.GetSchema("Tables");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
            int lenght = dataTable.Rows.Count;
            string[] worksheets = new string[lenght];
            for (int i = 0; i < lenght; i++)
            {
                worksheets[i] = dataTable.Rows[i]["TABLE_NAME"].ToString();
            }
            return worksheets;
        }

        private enum ExcelExtention
        {
            xls = 1,
            xlsx = 2
        }

        #endregion

        #region Write
        public static void Write(DataTable dt, string path)
        {

            FileStream fileStream = new FileStream(string.Format(@"{0}\{1}.xls", path, dt.TableName), FileMode.Create);
            ExcelWriter writer = new ExcelWriter(fileStream);
            writer.BeginWrite();
            int rowIndex = 0;
            foreach (DataColumn column in dt.Columns)
            {
                writer.WriteCell(rowIndex, column.Ordinal, column.ColumnName);
            }
            foreach (DataRow row in dt.Rows)
            {
                rowIndex++;
                foreach (DataColumn column in dt.Columns)
                {
                    writer.WriteCell(rowIndex, column.Ordinal, row[column.ColumnName].ToString());
                }

            }
            writer.EndWrite();
            fileStream.Close();

        }

        public static void Write(DataSet ds, string path)
        {
            foreach (DataTable dt in ds.Tables)
            {
                Write(dt, path);
            }

        }

        private class ExcelWriter
        {
            private Stream stream;
            private BinaryWriter writer;

            private ushort[] clBegin = { 0x0809, 8, 0, 0x10, 0, 0 };
            private ushort[] clEnd = { 0x0A, 00 };


            private void WriteUshortArray(ushort[] value)
            {
                for (int i = 0; i < value.Length; i++)
                    writer.Write(value[i]);
            }

            public ExcelWriter(Stream stream)
            {
                this.stream = stream;
                writer = new BinaryWriter(stream);
            }

            public void WriteCell(int row, int col, string value)
            {
                ushort[] clData = { 0x0204, 0, 0, 0, 0, 0 };
                int iLen = value.Length;
                byte[] plainText = Encoding.ASCII.GetBytes(value);
                clData[1] = (ushort)(8 + iLen);
                clData[2] = (ushort)row;
                clData[3] = (ushort)col;
                clData[5] = (ushort)iLen;
                WriteUshortArray(clData);
                writer.Write(plainText);
            }

            public void WriteCell(int row, int col, int value)
            {
                ushort[] clData = { 0x027E, 10, 0, 0, 0 };
                clData[2] = (ushort)row;
                clData[3] = (ushort)col;
                WriteUshortArray(clData);
                int iValue = (value << 2) | 2;
                writer.Write(iValue);
            }

            public void WriteCell(int row, int col, double value)
            {
                ushort[] clData = { 0x0203, 14, 0, 0, 0 };
                clData[2] = (ushort)row;
                clData[3] = (ushort)col;
                WriteUshortArray(clData);
                writer.Write(value);
            }

            public void WriteCell(int row, int col)
            {
                ushort[] clData = { 0x0201, 6, 0, 0, 0x17 };
                clData[2] = (ushort)row;
                clData[3] = (ushort)col;
                WriteUshortArray(clData);
            }

            public void BeginWrite()
            {
                WriteUshortArray(clBegin);
            }

            public void EndWrite()
            {
                WriteUshortArray(clEnd);
                writer.Flush();
            }
        }

        #endregion 



    }
}
