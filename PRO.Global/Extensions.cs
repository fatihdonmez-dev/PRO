using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using System.IO;
using System.Drawing;

namespace PRO.Global
{
    public static class Extensions
    {
        //public static void XSelectAll(this SpinEdit input)
        //{
        //    input.SelectAll();
        //}

        //public static void XSelectAll(this TextEdit input)
        //{
        //    input.SelectAll();
        //}

        //public static void XSelectAll(this ButtonEdit input)
        //{
        //    input.SelectAll();
        //}

        //public static void XSelectAll(this RepositoryItemBaseSpinEdit input)
        //{
        //    input.
        //}

        //public static void XSelectAll(this RepositoryItemTextEdit input)
        //{
        //    input.XSelectAll();
        //}

        //public static void XSelectAll(this RepositoryItemSpinEdit input)
        //{
            
        //    //if (input. == string.Empty) return;

        //    //if (Convert.ToInt32(Convert.ToDecimal(input.Text)) == 0)
        //    //{
        //    //    input.SelectAll();
        //    //}
        //}

        //fat1hh
        public static decimal ExStringToDecimal(this string _str)
        {
            if(_str == string.Empty) return 0;
            string[] _s = _str.Split('.');
            string _s1 = _s[0];
            string _s2 = _s[1];
            _s2 += "000000";
            _s2 = _s2.xLeft(6);
            _s1 = _s1 + _s2;
            decimal _sonuc = Convert.ToDecimal(_s1) / 1000000;
            return _sonuc;
        }


        public static byte[] ExImageToByteArray(this Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public static byte[] ExToByte(this Stream input)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }


        public static bool ExContainsAny(this string str, params string[] values)
        {
            if (!string.IsNullOrEmpty(str) || values.Length > 0)
            {
                foreach (string value in values)
                {
                    if (str.Contains(value))
                        return true;
                }
            }

            return false;
        }


        public static bool frmFileCopyEvent;
        public static bool frmFtpGuncelleEvent;
        //public static bool frmHesapListedenAcildi;
        //public static bool frmSiparisListeFaturaOlusturuldu;
        
        public static int XGetStringToInt(this string sayi)
        {
            try
            {
                return Convert.ToInt32(sayi);
            }
            catch (Exception)
            {
                return -1;
                throw;
            }
        }
        //SubString(6,3)
        

        public static string XGetGuidString(this Guid _guid)
        {
            return _guid.ToString().Replace("-", "");
        }

        public static DataTable GetDataList(this _Tables tableName)
        {
            return tableName.GetDataList(string.Empty, string.Empty);
        }
        public static DataTable GetDataList(this _Tables tableName, string whereConditions, string _UDFParams = "", bool _UDF = false)
        {
            if (_UDF)
                return tableName.GetDataListUDF(_UDFParams, whereConditions, string.Empty);
            else
                return tableName.GetDataList(whereConditions, string.Empty);
        }
        public static DataTable GetDataList(this _Tables tableName, string whereConditions, string orderBy)
        {
            DataTable dtResult = new DataTable();
            using (var con = Functions.GetConnection())
            {
                string query = string.Format("SELECT * FROM {0}", tableName.ToString("G"));

                if (whereConditions != string.Empty)
                    query += string.Format(" WHERE {0}", whereConditions);

                if (orderBy != string.Empty)
                    query += string.Format(" ORDER BY {0}", orderBy);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = con.CreateCommand();
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.SelectCommand.CommandText = query;
                adapter.Fill(dtResult);
            }
            return dtResult;
        }
        public static DataTable GetDataListUDF(this _Tables tableName, string _UDFParams, string whereConditions, string orderBy)
        {
            DataTable dtResult = new DataTable();
            using (var con = Functions.GetConnection())
            {
                string query = string.Format("SELECT * FROM {0}('{1}')", tableName.ToString("G"), _UDFParams);

                if (whereConditions != string.Empty)
                    query += string.Format(" WHERE {0}", whereConditions);

                if (orderBy != string.Empty)
                    query += string.Format(" ORDER BY {0}", orderBy);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = con.CreateCommand();
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.SelectCommand.CommandText = query;
                adapter.Fill(dtResult);
            }
            return dtResult;
        }
        

        public static DataTable GetDataList(this _Tables tableName, string whereConditions, string orderBy, string orderBy2)
        {
            DataTable dtResult = new DataTable();
            using (var con = Functions.GetConnection())
            {
                string query = string.Format("SELECT * FROM {0}", tableName.ToString("G"));

                if (whereConditions != string.Empty)
                    query += string.Format(" WHERE {0}", whereConditions);

                if (orderBy != string.Empty)
                    query += string.Format(" ORDER BY {0},{1}", orderBy, orderBy2);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = con.CreateCommand();
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.SelectCommand.CommandText = query;
                adapter.Fill(dtResult);
            }
            return dtResult;
        }

        public static DataTable GetDataListLocal(this _Tables tableName, string whereConditions = "")
        {
            DataTable dtResult = new DataTable();
            using (var con = Functions.GetLocalDBConnection())
            {
                string query = string.Format("SELECT * FROM {0}", tableName.ToString("G"));

                if (whereConditions != string.Empty)
                    query += string.Format(" WHERE {0}", whereConditions);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = con.CreateCommand();
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.SelectCommand.CommandText = query;
                adapter.Fill(dtResult);
            }
            return dtResult;
        }


        public static DataTable GetDataListLocalUser(this _Tables tableName, string whereConditions = "")
        {
            DataTable dtResult = new DataTable();
            using (var con = Functions.GetUserDBConnection())
            {
                string query = string.Format("SELECT * FROM {0}", tableName.ToString("G"));

                if (whereConditions != string.Empty)
                    query += string.Format(" WHERE {0}", whereConditions);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = con.CreateCommand();
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.SelectCommand.CommandText = query;
                adapter.Fill(dtResult);
            }
            return dtResult;
        }
        public static DataTable GetDataListUDF(this _Tables tableName, string parameter, string orderBy)
        {
            DataTable dtResult = new DataTable();
            using (var con = Functions.GetConnection())
            {
                string query = string.Format("SELECT * FROM {0}", tableName.ToString("G"));
                query += string.Format("('{0}')", parameter);

                if (orderBy != string.Empty)
                    query += string.Format(" ORDER BY {0}", orderBy);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = con.CreateCommand();
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.SelectCommand.CommandText = query;
                adapter.Fill(dtResult);
            }
            return dtResult;
        }



        public static string GetKeyText(this _Tables tableName, string whereField, object whereValue, string returnField)
        {
            using (var con = Functions.GetConnection())
            {
                string query = string.Format("SELECT {0} FROM {1} WHERE {2} = @p", returnField, tableName.ToString("G"), whereField);

                var cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@p", whereValue));

                con.Open();
                object result = cmd.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                    return string.Empty;
                else
                    return result.ToString();

            }
        }




        public static object GetKeyObject(this _Tables tableName, string whereField, object whereValue, string returnField)
        {
            using (var con = Functions.GetConnection())
            {
                string query = string.Format("SELECT {0} FROM {1} WHERE {2} = @p", returnField, tableName.ToString("G"), whereField);

                var cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@p", whereValue));

                con.Open();
                object result = cmd.ExecuteScalar();

                return result;



            }
        }
        public static object GetObject(this _Tables tableName, string whereStr, string returnField)
        {
            using (var con = Functions.GetConnection())
            {
                string query = string.Format("SELECT TOP 1 {0} FROM {1} ", returnField, tableName.ToString("G"));

                if (whereStr.Length>0)
                    query+=string.Format("WHERE {0}", whereStr);

                var cmd = con.CreateCommand();
                cmd.CommandText = query;

                con.Open();
                object result = cmd.ExecuteScalar();

                return result;
            }
        }
        
        public static object GetKeyObject(this _Tables tableName, string whereValue, string returnField)
        {
            using (var con = Functions.GetConnection())
            {
                string query = string.Format("SELECT {0} FROM {1} WHERE {2}", returnField, tableName.ToString("G"), whereValue);

                var cmd = con.CreateCommand();
                cmd.CommandText = query;

                con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();
                return result;
            }
        }

        public static object GetLocalKeyObject(this _Tables tableName, string whereValue, string returnField)
        {
            using (var con = Functions.GetLocalDBConnection())
            {
                string query = string.Format("SELECT {0} FROM {1} WHERE {2}", returnField, tableName.ToString("G"), whereValue);

                var cmd = con.CreateCommand();
                cmd.CommandText = query;

                con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();
                return result;
            }
        }


        public static void BindToControl(this DataTable table, CheckedComboBoxEdit combo, string valueMember, string displayMember)
        {
            combo.Properties.DataSource = table;
            combo.Properties.ValueMember = valueMember;
            combo.Properties.DisplayMember = displayMember;
        }
        public static void BindToControl(this DataTable table, RepositoryItemCheckedComboBoxEdit combo, string valueMember, string displayMember)
        {
            combo.ValueMember = valueMember;
            combo.DisplayMember = displayMember;
            combo.DataSource = table;
            
        }
        public static void BindToControl(this DataTable table, LookUpEdit lookupEdit, string valueMember, string displayMember)
        {
            table.BindToControl(lookupEdit.Properties, valueMember, displayMember);
        }
        public static void BindToControl(this DataTable table, RepositoryItemLookUpEdit lookupEdit, string valueMember, string displayMember)
        {
            lookupEdit.Columns.Clear();
            lookupEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(displayMember));
            lookupEdit.ShowHeader = false;

            lookupEdit.ValueMember = valueMember;
            lookupEdit.DisplayMember = displayMember;
            lookupEdit.DataSource = table;
        }
        public static void BindToControl(this DataTable table, ImageComboBoxEdit combo, string valueMember, string displayMember)
        {
            table.BindToControl(combo.Properties, valueMember, displayMember);
        }
        public static void BindToControl(this DataTable table, RepositoryItemImageComboBox combo, string valueMember, string displayMember)
        {
            combo.Items.Clear();
            foreach (DataRow i in table.Rows)
            {
                combo.Items.Add(new ImageComboBoxItem((string)i[displayMember], (int)i[valueMember],0));
            }
        }
        public static void BindToControl(this DataTable table, ComboBoxEdit combo, string displayMember)
        {
            table.BindToControl(combo.Properties, displayMember);
        }
        public static void BindToControl(this DataTable table, RepositoryItemComboBox combo,string displayMember)
        {
            
            combo.Items.Clear();
            foreach (DataRow i in table.Rows)
            {

                combo.Items.Add(i[displayMember].ToString());
            }
            
        }

        public static void BindToControl(this DataTable table, RepositoryItemComboBox combo, string displayMember,int yuvarla)
        {

            combo.Items.Clear();
            foreach (DataRow i in table.Rows)
            {
                decimal _d = (decimal)i[displayMember];
                combo.Items.Add(_d.Yuvarla(yuvarla).ToString());
            }

        }






        public static void XPostEditor(this GridControl grid)
        {
            BaseView view = grid.FocusedView;
            if (!view.PostEditor())
            {
                view.UpdateCurrentRow();
            }

            grid.EmbeddedNavigator.Buttons.DoClick(grid.EmbeddedNavigator.Buttons.EndEdit);
        }

        public static decimal Yuvarla(this decimal sayi, int ondalik)
        {
            return Math.Round(sayi, ondalik);
        }

        public static decimal YuvarlaYukari(this decimal sayi)
        {
            return Math.Ceiling(sayi);
        }

        public static decimal YuvarlaAsagi(this decimal sayi)
        {
            return Math.Floor(sayi);
        }
        public static string xLeft(this string sayi,int _lengt)
        {
            if (sayi.Length <= _lengt)
                return sayi;
            else
                return sayi.Substring(0, _lengt);
        }
        public static string xRigt(this string sayi, int _lengt)
        {
            if (sayi.Length <= _lengt)
                return sayi;
            else
                return sayi.Substring(sayi.Length - _lengt, _lengt);

                
        }
        public static int xInt(this string sayi)
        {
            if (sayi.Length > 0)
                return Convert.ToInt32(sayi);
            else
                return 0;
        }
        public static string xStartLengt(this string deger, int _start)
        {
            if (_start < deger.Length)
                return deger.Substring(_start, (deger.Length-_start));
            else
                return "";
        }

        public static string YaziyaCevir(this decimal sayi)
        {
            return Functions.SayiyaYaziyaCevir(sayi);
        }


        public static void SetDegistirenBilgi(this DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                if (row.RowState == DataRowState.Modified || row.RowState == DataRowState.Added || row.RowState == DataRowState.Detached)
                {
                    row["DegisBy"] = Session.Instance.CurrentUser.UserName;
                    row["DegisDate"] = DateTime.Now;
                }
            }
        }
        public static void SetVersyon(this DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                if (row.RowState == DataRowState.Modified || row.RowState == DataRowState.Added || row.RowState == DataRowState.Detached)
                {
                    row["DegisBy"] = Session.Instance.CurrentUser.UserName;
                    row["DegisDate"] = DateTime.Now;
                    row["Versiyon"] = DateTime.Now;
                }
            }
        }
        public static void SetVersyonRow(this DataRow row)
        {
            if (row == null) return;
            row["DegisBy"] = Session.Instance.CurrentUser.UserName;
            row["DegisDate"] = DateTime.Now;
            row["Versiyon"] = DateTime.Now;
            

        }

        public static void SetRowSil(this DataRow _row)
        {
            if (_row.RowState != DataRowState.Added)
            {
                _row["Silindi"] = true;
                _row["SilmeNedeni"] = "";
                _row["DegisBy"] = Session.Instance.CurrentUser.UserName;
                _row["DegisDate"] = DateTime.Now;
            }
        }

        public static void SetDegistiren(this DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                if (row.RowState == DataRowState.Modified)
                {
                    row["DegisBy"] = Session.Instance.CurrentUser.UserName;
                    row["DegisDate"] = DateTimeOffset.Now;
                }
            }
        }
        public static void SetRowVersiyon(this DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                if (row.RowState != DataRowState.Deleted)
                {
                    row["RowVersiyon"] = DateTime.Now;
                }
            }
        }
        public static void XLog(this DataTable _TableName, Guid _VerID, Guid _EvrakID,int _EvrakTipi, DateTime _EvrakTarih, string _EvrakNo, List<DataRow> deletedRows)
        {
            string sql = String.Empty;

            foreach (DataRow item in _TableName.Rows)
            {
                if (item.RowState != DataRowState.Unchanged && item.RowState != DataRowState.Deleted)
                {
                    System.IO.StringWriter sw = new System.IO.StringWriter();
                    DataTable table = _TableName.Clone();
                    var desRow = table.NewRow();
                    table.Clear();
                    var sourceRow = item;
                    desRow.ItemArray = sourceRow.ItemArray.Clone() as object[];
                    table.Rows.Add(desRow);
                    table.WriteXml(sw,XmlWriteMode.WriteSchema,true);
                    string xml = sw.ToString();
                    SqlParameter[] prm = new SqlParameter[12];
                    prm[0] = new SqlParameter("LogID", Guid.NewGuid());
                    prm[1] = new SqlParameter("Kullanici", Session.Instance.CurrentUser.UserName);
                    prm[2] = new SqlParameter("IslemTipi", item.RowState.GetHashCode());
                    prm[3] = new SqlParameter("Tarih", DateTime.Now);
                    prm[4] = new SqlParameter("VersionID", _VerID == Guid.Empty ? Guid.NewGuid() : _VerID);
                    prm[5] = new SqlParameter("Data", xml);
                    prm[6] = new SqlParameter("EvrakTipi", _EvrakTipi);
                    prm[7] = new SqlParameter("EvrakID", _EvrakID == Guid.Empty ? item[0] : _EvrakID);
                    prm[8] = new SqlParameter("Tablo", _TableName.TableName);
                    prm[9] = new SqlParameter("EvrakNo", _EvrakNo);
                    prm[10] = new SqlParameter("EvrakTarih", _EvrakTarih);
                    prm[11] = new SqlParameter("SatirID", item[0]);
                    sql =
                        "INSERT INTO SYS_LOG \n" +
                        "   (LogID, Kullanici, IslemTipi, Tarih, VersionID, Data, EvrakTipi, EvrakId, Tablo, EvrakNo, EvrakTarih, SatirID)\n" +
                        "VALUES\n" +
                        "   (@LogID, @Kullanici, @IslemTipi, @Tarih, @VersionID, @Data, @EvrakTipi, @EvrakId, @Tablo, @EvrakNo, @EvrakTarih, @SatirID)";
                    DB.ExecuteNonQuery(Functions.GetConnectionString(), CommandType.Text, sql, prm);
                }
            }

            if (deletedRows != null)
            {
                foreach (var item in deletedRows)
                {
                    System.IO.StringWriter sw = new System.IO.StringWriter();
                    DataTable table = _TableName.Clone();
                    var desRow = table.NewRow();
                    table.Clear();
                    var sourceRow = item;
                    desRow.ItemArray = sourceRow.ItemArray.Clone() as object[];
                    table.Rows.Add(desRow);
                    table.WriteXml(sw);
                    string xml = sw.ToString();
                    SqlParameter[] prm = new SqlParameter[12];
                    prm[0] = new SqlParameter("LogID", Guid.NewGuid());
                    prm[1] = new SqlParameter("Kullanici", Session.Instance.CurrentUser.UserName);
                    prm[2] = new SqlParameter("IslemTipi", DataRowState.Deleted.GetHashCode());
                    prm[3] = new SqlParameter("Tarih", DateTime.Now);
                    prm[4] = new SqlParameter("VersionID", _VerID == Guid.Empty ? Guid.NewGuid() : _VerID);
                    prm[5] = new SqlParameter("Data", xml);
                    prm[6] = new SqlParameter("EvrakTipi", _EvrakTipi);
                    prm[7] = new SqlParameter("EvrakID", _EvrakID == Guid.Empty ? item[0] : _EvrakID);
                    prm[8] = new SqlParameter("Tablo", _TableName.TableName);
                    prm[9] = new SqlParameter("EvrakNo", _EvrakNo);
                    prm[10] = new SqlParameter("EvrakTarih", _EvrakTarih);
                    prm[11] = new SqlParameter("SatirID", item[0]);
                    sql =
                        "INSERT INTO SYS_LOG \n" +
                        "   (LogID, Kullanici, IslemTipi, Tarih, VersionID, Data, EvrakTipi, EvrakId, Tablo, EvrakNo, EvrakTarih, SatirID)\n" +
                        "VALUES\n" +
                        "   (@LogID, @Kullanici, @IslemTipi, @Tarih, @VersionID, @Data, @EvrakTipi, @EvrakId, @Tablo, @EvrakNo, @EvrakTarih, @SatirID)";
                    DB.ExecuteNonQuery(Functions.GetConnectionString(), CommandType.Text, sql, prm);
                }
            }
        }

        public static bool XDeleteRows(this GridView gw, string message)
        {
            if (XtraMessageBox.Show(message, "Kayıt Sil",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {

                try
                {
                    gw.DeleteSelectedRows();
                    return true;
                }
                catch (Exception e)
                {
                    XtraMessageBox.Show(e.Message);
                    return false;

                }
            }
            else
                return false;
        }




        public static DateTime AyinIlkGunu(this DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, 1);
        }

        public static DateTime AyinSonGunu(this DateTime dt)
        {
            return dt.AyinIlkGunu().AddMonths(1).AddDays(-1);
        }

        public static int ExHaftaninGunu(this DateTime dt)
        {
            //return dt.AyinIlkGunu().AddMonths(1).AddDays(-1);
            return (int)DateTime.Parse(dt.ToShortDateString()).DayOfWeek;
        }


        //int haftaninGunu = (int)DateTime.Parse(_trh.ToShortDateString()).DayOfWeek;

        //   EKLENEN KODLAR

        public static bool IsNumeric(this string s)
        {
            int n;
            return Int32.TryParse(s, out n);
        }

        public static bool IsDecimal(this string s)
        {
            decimal n;
            return decimal.TryParse(s, out n);
        }

        public static object GetObjFromString(this string s)
        {
            return (object)s;
        }

        public static string GetSQLDecimalString(this string s)
        {
            return s.Replace(".",",");
        }

        public static IEnumerable<Object[]> DataRecord(this System.Data.IDataReader source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            while (source.Read())
            {
                Object[] row = new Object[source.FieldCount];
                source.GetValues(row);
                yield return row;
            }
        }






    }
}
