using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace PRO.Global
{
   public class SessionUsers
    {
        private Hashtable _userRightsTable;
        private Hashtable _fieldRightsTable;

        public  string UserName;
        public  string UserFullName;
        public  Int32 Firma;
        public  string FirmaAdi;
        public  Int32 Sirket;
        public  string SirketAdi;
        public  string Lang;
      
       private SessionUsers() { }
       public SessionUsers( 
                            string _userName, 
                            string _fullName,
                            Int32 _firma,
                            string _firmaAdi,
                            Int32 _sirket,
                            string _sirketAdi,
                            string _lang
                          )
        {
            this.UserName = _userName;
            this.UserFullName = _fullName;
            this.Sirket = _sirket;
            this.SirketAdi = _sirketAdi;
            this.Firma = _firma;
            this.FirmaAdi = _firmaAdi;
            this.Lang = _lang;
            LoadUserRightsTable();

            GlobalEvent.OnYetkilerGuncellendi += () => { LoadUserRightsTable(); };
        }

       private void LoadUserRightsTable()
       {
           _userRightsTable = new Hashtable();
           _fieldRightsTable = new Hashtable();

           //var adapKulYetki = new SYS_UserYetkiTableAdapter();
           //var result = adapKulYetki.sp_SYS_GetUserYetki(this.UserID).ToList();

           //result.ToList().ForEach
           //(r =>
           //      r.YetkiListesi.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(s => _userRightsTable.Add(s.Trim(), s.Trim()))
           //);

           //var adapFieldYetki = new SYS_UserFieldKeyTableAdapter();
           //var resultKey = adapFieldYetki.sp_SYS_GetUserFieldYetki(this.Firma, this.Sirket, this.UserID).ToList();

           //resultKey.ToList().ForEach
           //(r =>
           //      _fieldRightsTable.Add(r.FieldName.Trim(), r.KeyValue)
           //);
       }

       public Int32 IsFieldKey(string value)
       {
           if (_fieldRightsTable.ContainsKey(value))
               return System.Convert.ToInt32(_fieldRightsTable[value]);
           else
               return 0;
       }

       public bool IsYetkisiVar(string yetkiKodu)
       {
           var yetkiVar = _userRightsTable.ContainsKey(yetkiKodu);

           if (!yetkiVar) // Eğer yetki yoksa, yetkileri bir kez güncelleyip tekrar bak.
           {
               LoadUserRightsTable();
               yetkiVar = _userRightsTable.ContainsKey(yetkiKodu);
           }

           return yetkiVar;
       }
    }



   public class SessionConnect
   {
 
       public readonly string Server;
       public readonly string Database;
       public readonly string Connection;
       public readonly string Lang;

       private SessionConnect() { }
       public SessionConnect(
                            string _server,
                            string _database,
                            string _connection,
                            string _lang
                          )
       {
           this.Server = _server;
           this.Database = _database;
           this.Connection = _connection;
           this.Lang = _lang;
           
       }

       


   }




}