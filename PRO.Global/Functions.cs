using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;
using PRO.Data;
using PRO.Data.DSDataSystemTableAdapters;
using DevExpress.Utils;

namespace PRO.Global
{
    public static class Functions
    {

        public static DSDataSystem.SYS_ModulFieldDataTable GetValidationKeyList(string MenuNo, int param)
        {
            using (SYS_ModulFieldTableAdapter adapMenu = new SYS_ModulFieldTableAdapter())
            {
                return adapMenu.GetData(MenuNo, param);
            }
        }


        public static bool XNull(object o)
        {
            try
            {
                return o == null;
            }
            catch
            {
                return false;
            }
        }

        
        public static DSSystem.SYS_ShortcutUserDataTable GetShortcut()
        {
            try
            {

                DSSystem.SYS_ShortcutUserDataTable resultTable = new DSSystem.SYS_ShortcutUserDataTable();

                using (var con = Functions.GetConnection())
                {

                    resultTable.Clear();

                    SqlCommand cmd = new SqlCommand("_sp_Shortcut", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Kullanici", Session.Instance.CurrentUser.UserName);

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        object[] values = new object[rdr.FieldCount];
                        rdr.GetValues(values);
                        resultTable.Rows.Add(values);
                    }
                    con.Close();

                    return resultTable;


                }
            }
            catch (Exception)
            {
                return null;
            }

        }


        //public static DSSystem.SYS_LayoutDataTable GetLayoutTable(string _user)
        //{
        //    try
        //    {

        //        DSSystem.SYS_LayoutDataTable resultTable = new DSSystem.SYS_LayoutDataTable();

        //        using (var con = Functions.GetConnection())
        //        {

        //            resultTable.Clear();

        //            SqlCommand cmd = new SqlCommand("sp_SYS_LayoutAll", con);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@UserName", _user);

        //            con.Open();
        //            SqlDataReader rdr = cmd.ExecuteReader();

        //            while (rdr.Read())
        //            {
        //                object[] values = new object[rdr.FieldCount];
        //                rdr.GetValues(values);
        //                resultTable.Rows.Add(values);
        //            }
        //            con.Close();

        //            return resultTable;


        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }

        //}
        public static DSSystem.SYS_LayoutDataTable GetLayoutTable(int firma, string _user, string _layID, string _lyt, string _param)
        {
            DSSystem.SYS_LayoutDataTable resultTable = new DSSystem.SYS_LayoutDataTable();
            //using (var con = Functions.GetUserDBConnection())
            using (var con = Functions.GetConnection())
            {
                resultTable.Clear();

                SqlCommand cmd = new SqlCommand("_sp_SYS_Layout ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Sirket", firma);
                cmd.Parameters.AddWithValue("@UserName", _user);
                cmd.Parameters.AddWithValue("@LayID", _layID);
                cmd.Parameters.AddWithValue("@Lyt", _lyt);
                cmd.Parameters.AddWithValue("@Param", _param);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                resultTable.Load(rdr);
                con.Close();
                return resultTable;
            }
        }
        public static DSSystem.SYS_FormLayoutDataTable GetFormLayoutTable(string _LayID)
        {
            DSSystem.SYS_FormLayoutDataTable resultTable = new DSSystem.SYS_FormLayoutDataTable();
            //using (var con = Functions.GetUserDBConnection())
            using (var con = Functions.GetConnection())
            {
                resultTable.Clear();

                SqlCommand cmd = new SqlCommand("_sp_SYS_FormLayout ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LayID", _LayID);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    object[] values = new object[rdr.FieldCount];
                    rdr.GetValues(values);
                    resultTable.Rows.Add(values);
                }
                con.Close();
                return resultTable;
            }
        }


        public static byte[] XGridControlConvertByte(DevExpress.XtraGrid.Views.Grid.GridView _gw)
        {
            System.IO.Stream str = new System.IO.MemoryStream();
            //str = new System.IO.MemoryStream();
            _gw.SaveLayoutToStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout);
            str.Seek(0, System.IO.SeekOrigin.Begin);

            byte[] byteArray = new byte[str.Length];
            str.Read(byteArray, 0, System.Convert.ToInt32(str.Length));
            str.Close();

            return byteArray;
        }


        public static byte[] XReportConvertByte(XtraReport report)
        {
            System.IO.Stream str = new System.IO.MemoryStream();
            //str = new System.IO.MemoryStream();
            report.SaveLayout(str);
            str.Seek(0, System.IO.SeekOrigin.Begin);

            byte[] byteArray = new byte[str.Length];
            str.Read(byteArray, 0, System.Convert.ToInt32(str.Length));
            str.Close();

            return byteArray;
        }

        public static byte[] XConvertStreamToByte(System.IO.MemoryStream MStream)
        {

            byte[] byteArray = new byte[MStream.Length];
            MStream.Read(byteArray, 0, System.Convert.ToInt32(MStream.Length));
            MStream.Close();
            return byteArray;

        }

        public static System.IO.MemoryStream XConvertByteToStream(byte[] byteData)
        {
            return new System.IO.MemoryStream(byteData);

        }



        public static SqlConnection GetConnection()
        {
            //return new SqlConnection(ConfigurationManager.ConnectionStrings["BALCIConnectionString"].ConnectionString);
            return new SqlConnection(GetConnectionString());

        }
        public static SqlConnection GetLocalDBConnection()
        {
            return new SqlConnection(GetLocalDBConnectionString());
        }
        public static SqlConnection GetSystemDBConnection()
        {
            return new SqlConnection(GetSystemDBConnectionString());
        }
        public static SqlConnection GetUserDBConnection()
        {
            return new SqlConnection(GetUserDBConnectionString());
        }

        public static string GetConnectionString()
        {
            //return Session.Instance.CurrentConnect.Connection;
            //return @"Data Source=192.168.1.7\SQL2012;Initial Catalog=PRINT_Pro;Persist Security Info=True;User ID=sa;Password=sql2012";
            return PRO.Global.Variables._conStr;
            
        }
        public static string GetLocalDBConnectionString()
        {
            //return @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\DBLocal.mdf;Integrated Security=True";
            return PRO.Global.Variables._conStr;
        }
        public static string GetSystemDBConnectionString()
        {
            //return @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\DBSystem.mdf;Integrated Security=True";
            return PRO.Global.Variables._conStr;
        }
        public static string GetUserDBConnectionString()
        {
            //return @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\DBUser.mdf;Integrated Security=True";
            //return Session.Instance.CurrentConnect.Connection;
            //return @"Data Source=192.168.1.7\SQL2012;Initial Catalog=PRINT_Pro;Persist Security Info=True;User ID=sa;Password=sql2012";
            return PRO.Global.Variables._conStr;
        }

        public static ConnectData _GetConnectData()
        {

            string XPath = Application.StartupPath + "\\System\\Settings.xml";  //  +_dosya;   //Settings.xml";


            string Servername = "";
            string UserName = "";
            string Sifre = "";
            string DataBase = "";
            string QConSTR = "";

            XmlTextReader textReader = new XmlTextReader(XPath);
            string elementTag = "";
            while (textReader.Read())
            {
                textReader.MoveToElement();

                elementTag = textReader.LocalName.ToString();

                if (elementTag == "Servername")
                {
                    Servername = XConvert.Sifreleme.SifreCoz(textReader.ReadString());
                }
                if (elementTag == "UserName")
                {
                    UserName = XConvert.Sifreleme.SifreCoz(textReader.ReadString());
                }
                if (elementTag == "Sifre")
                {
                    Sifre = XConvert.Sifreleme.SifreCoz(textReader.ReadString());
                }
                if (elementTag == "dataBase")
                {
                    DataBase = XConvert.Sifreleme.SifreCoz(textReader.ReadString());
                }
            }
            textReader.Close();
            QConSTR = "Data Source=" + Servername + ";Initial Catalog=" + DataBase + ";Persist Security Info=True;User ID=" + UserName + ";Password=" + Sifre + ";Language=Turkish;Connection Timeout=300";

            ConnectData _ConnData = new ConnectData(QConSTR, Servername, DataBase);

            return _ConnData;

        }


        public static bool IsNullOrDBNull(object value)
        {
            return (value == null || value == DBNull.Value);
        }

        public static bool IsInteger(object value)
        {
            if (IsNullOrDBNull(value))
            {
                return false;
            }
            else
            {
                int result;
                return int.TryParse(value.ToString(), out result);
            }
        }
        public static int ToInteger(object value)
        {
            return Convert.ToInt32(value);
        }
        public static int SafeInteger(object value, int def)
        {
            if (IsInteger(value))
                return ToInteger(value);
            else
                return def;
        }

        public static bool IsDecimal(object value)
        {
            if (IsNullOrDBNull(value))
            {
                return false;
            }
            else
            {
                string s = value.ToString();

                s = s.Replace('.', ',');

                decimal result;
                return decimal.TryParse(s, NumberStyles.Number, System.Threading.Thread.CurrentThread.CurrentUICulture, out result);
            }
        }
        public static decimal ToDecimal(object value)
        {
            string s = value.ToString();

            s = s.Replace('.', ',');

            return Convert.ToDecimal(s, System.Threading.Thread.CurrentThread.CurrentUICulture);
        }
        public static decimal SafeDecimal(object value, decimal def)
        {
            if (IsDecimal(value))
                return ToDecimal(value);
            else
                return def;
        }

        public static bool IsString(object value)
        {
            if (IsNullOrDBNull(value))
            {
                return false;
            }
            else
            {
                return string.IsNullOrWhiteSpace(value.ToString()) == false;
            }
        }
        public static string ToString(object value)
        {
            return Convert.ToString(value);
        }
        public static string SafeString(object value, string def)
        {
            if (IsString(value))
                return ToString(value);
            else
                return def;
        }

        public static bool IsGuid(object value)
        {
            if (IsNullOrDBNull(value))
            {
                return false;
            }
            else
            {
                Guid result;
                return Guid.TryParse(value.ToString(), out result);
            }
        }
        public static Guid ToGuid(object value)
        {
            return new Guid(value.ToString());
        }
        public static Guid SafeGuid(object value, Guid def)
        {
            if (IsGuid(value))
                return ToGuid(value);
            else
                return def;
        }



        public static string SayiyaYaziyaCevir(decimal tutar)
        {
            string sTutar = tutar.ToString("F2").Replace('.', ',');
            string lira = sTutar.Substring(0, sTutar.IndexOf(','));
            string kurus = sTutar.Substring(sTutar.IndexOf(',') + 1, 2);
            string yazi = "";

            string[] birler = { "", "BİR", "İKİ", "Üç", "DÖRT", "BEŞ", "ALTI", "YEDİ", "SEKİZ", "DOKUZ" };
            string[] onlar = { "", "ON", "YİRMİ", "OTUZ", "KIRK", "ELLİ", "ALTMIŞ", "YETMİŞ", "SEKSEN", "DOKSAN" };
            string[] binler = { "KATRİLYON", "TRİLYON", "MİLYAR", "MİLYON", "BİN", "" };

            int grupSayisi = 6;

            lira = lira.PadLeft(grupSayisi * 3, '0');

            string grupDegeri;

            for (int i = 0; i < grupSayisi * 3; i += 3)
            {
                grupDegeri = "";

                if (lira.Substring(i, 1) != "0")
                    grupDegeri += birler[Convert.ToInt32(lira.Substring(i, 1))] + "YÜZ"; //yüzler                

                if (grupDegeri == "BİRYÜZ")
                    grupDegeri = "YÜZ";

                grupDegeri += onlar[Convert.ToInt32(lira.Substring(i + 1, 1))]; //onlar

                grupDegeri += birler[Convert.ToInt32(lira.Substring(i + 2, 1))]; //birler                

                if (grupDegeri != "")
                    grupDegeri += binler[i / 3];

                if (grupDegeri == "BİRBİN")
                    grupDegeri = "BİN";

                yazi += grupDegeri;
            }

            if (yazi != "")
                yazi += " TL ";

            int yaziUzunlugu = yazi.Length;

            if (kurus.Substring(0, 1) != "0") //kuruş onlar
                yazi += onlar[Convert.ToInt32(kurus.Substring(0, 1))];

            if (kurus.Substring(1, 1) != "0") //kuruş birler
                yazi += birler[Convert.ToInt32(kurus.Substring(1, 1))];

            if (yazi.Length > yaziUzunlugu)
                yazi += " Kr.";
            else
                yazi += "";

            return yazi;
        }

      
    }
}
