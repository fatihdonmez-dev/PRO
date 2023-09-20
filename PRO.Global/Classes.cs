using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRO.Global
{

    public class MenuData
    {
        public readonly string MenuNo;
        public readonly string DilKey;
        public readonly string IslemFormu;
        public readonly string Parametre;
        public readonly string LayoutName;

        public readonly int Sirket;
        public readonly string SirketAdi;
        public readonly int Firma;
        public readonly string FirmaAdi;

        public readonly string LoadParam;
        public readonly string DefaultParam;
        public readonly string SeriParam;
        public readonly string ConnStr;
        public readonly bool MultiLang;
        public readonly string HesapParam;
        public readonly string KHesapParam;

        public MenuData()
        { 

        }
       
        public MenuData(
            string MenuNo,
            string dilKey,
            string islemFormu, 
            string parametre, 
            string layoutName, 
            int sirket,
            string sirketAdi, 
            int firma,
            string firmaadi, 

            string loadParam = "", 
            string defaultParam = "", 
            string seriParam = "",
            string connStr="",
            bool multiLang=false,
            string hesapParam="",
            string khesapParam=""
            )
        {
            this.MenuNo = MenuNo;
            this.DilKey = dilKey;
            this.IslemFormu = islemFormu;
            this.Parametre = parametre;
            this.LayoutName = layoutName;
            this.Sirket = sirket;
            this.SirketAdi = sirketAdi;
            this.Firma = firma;
            this.FirmaAdi = firmaadi;
            this.LoadParam = loadParam;
            this.DefaultParam = defaultParam;
            this.SeriParam = seriParam;
            this.ConnStr = connStr;
            this.MultiLang = multiLang;
            this.HesapParam = hesapParam;
            this.KHesapParam = khesapParam;
        }

    }

    public class GrupYetkiData
    {
        public readonly Guid YetkiGrupID;
        public readonly string GrupAdi;
        public readonly string UserKod;
        public readonly string UserName;
        public readonly int UserKey;


        public GrupYetkiData()
        {

        }

        public GrupYetkiData(
                            Guid _yetkiGrupID,
                            string _grupAdi,
                            string _userKod,
                            string _userName,
                            int _userKey
                            )
        {
            this.YetkiGrupID = _yetkiGrupID;
            this.GrupAdi = _grupAdi;
            this.UserKod= _userKod;
            this.UserName = _userName;
            this.UserKey= _userKey;
            
        }
    }
   
    public class ConnectData
    {
        public readonly string _Connect;
        public readonly string _Server;
        public readonly string _DataBase;

        public ConnectData()
        {

        }

        public ConnectData(string _connect,string _server,string _database)
        {
            this._Connect = _connect;
            this._Server = _server;
            this._DataBase = _database;
            
        }


    }

}
