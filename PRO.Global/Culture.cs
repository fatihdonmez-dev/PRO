using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;
using System.Collections;
using System.Data;
using PRO.Data;
using PRO.Data.DSSystemTableAdapters;
//using System.Data.Objects;

namespace PRO.Global
{
    public delegate void CultureChangedEventHandler(Object sender, CultureInfo newCulture, Hashtable languageTable);

    public class Culture
    {

        private CultureInfo _currentCulture;
        //private Hashtable _languageTable;
        private DSSystem.SYS_DilKeyDataTable _languageTable;

        public List<string> GetSupportedLanguages()
        {
            return new List<string>()
                   {
                       "tr-TR",
                       "en-US"
                   };
        }
        
        public CultureInfo CurrentCulture
        {
            get { return _currentCulture; }
        }

        public void SetCurrentCulture(CultureInfo ci)
        {
            _currentCulture = ci;
            LoadLanguageTable();
        }

        public void LoadLanguageTable()
        {
            _languageTable = new DSSystem.SYS_DilKeyDataTable();
            using (var adapDil = new SYS_DilKeyTableAdapter())
            {
                var result = adapDil.GetData(this.CurrentCulture.Name).ToList();
                result.ForEach(dil =>
             {
                var oRow = _languageTable.NewSYS_DilKeyRow();  
                oRow.DilKey = dil.DilKey;
                oRow.Caption = dil.Caption;
                oRow.Language = dil.Language;
                oRow.Parametre = dil.Parametre;
                _languageTable.AddSYS_DilKeyRow(oRow);
            }
                );
            }
        }

        public string Translate(string dilKey, string parameter="0")
        {
            //return _languageTable[dilKey] as string;
            var _c = _languageTable.Where(x => x.DilKey == dilKey && x.Parametre == parameter).FirstOrDefault();
            if (_c == null)
                return "?" + dilKey;
            else
                return _c.Caption;
        }
        private Culture() { }
        public Culture(CultureInfo culture)
        {
            _currentCulture = culture;
            LoadLanguageTable();

            GlobalEvent.OnDilCevrimleriGuncellendi += () => { LoadLanguageTable(); };
        }


    }
}
