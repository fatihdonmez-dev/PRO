using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.IO.Compression;
using PRO.Data.DSSystemTableAdapters;


namespace PRO.Global
{
    public class Procs
    {
        public static string GetNextSeriNoGetir(int _firma, string _menuNo, string _parametre, string _seri, int _seriEkle = 0)
        {
            string _sonuc = string.Empty;
            try
            {
                using (var funcs = new FunctionsTableAdapter())
                {
                    funcs._sp_GetSeri(_firma, _menuNo, _parametre, _seri, _seriEkle, ref _sonuc);
                    return _sonuc;
                }
            }
            catch (Exception)
            {
                return string.Empty;
                throw;
            }
        }

        public static string StokKoduOlustur(int _firma, string _tip)
        {
            string _sonuc = string.Empty;
            try
            {
                using (var funcs = new FunctionsTableAdapter())
                {
                    funcs._sp_StokKodu(_firma, _tip, ref _sonuc);
                    return _sonuc;
                }
            }
            catch (Exception)
            {
                return string.Empty;
                throw;
            }
        }

        public static void StokBarkodOlustur(Guid _EvrakID)
        {

            try
            {
                using (var funcs = new FunctionsTableAdapter())
                {
                    funcs._sp_STI_Barkod(_EvrakID, Session.Instance.CurrentUser.UserName);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        public static string SiparisEvrakNoOlustur(int _firma)
        {
            string _sonuc = string.Empty;
            try
            {
                using (var funcs = new FunctionsTableAdapter())
                {
                    funcs._sp_SiparisEvrakNo(_firma, ref _sonuc);
                    return _sonuc;
                }
            }
            catch (Exception)
            {
                return string.Empty;
                throw;
            }
        }

        //public static bool OrtakSureHesapla(Guid OrtakID, int Fabrika,DateTime Baslangic)
        //{
        //    try
        //    {
        //        using (var funcs = new FunctionsTableAdapter())
        //        {
        //            funcs._sp_OrtakSureHesapla(OrtakID,Fabrika,Baslangic,Session.Instance.CurrentUser.UserName);
        //        }
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        public static bool OpenFile(string fileName)
        {
            System.Diagnostics.Process process=new System.Diagnostics.Process();
            process.StartInfo.FileName = fileName;
            process.StartInfo.Verb = "Open";
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized;
            process.Start();
             
            return true;
        }

        //public static bool GetSeriNoKontrol(Guid _ID,int _firma,int _sirket, string _seri,string _seriNo,int _islem,int _evrakTip,int _tip,int _tur)
        //{
        //    try
        //    {
        //        string sonuc = "";
        //        using (var funcs = new FunctionsTableAdapter())
        //        {

        //            funcs.sp_SeriNoKontrol((Guid)_ID,_firma,_sirket, (string)_seri,(string)_seriNo,(int)_islem,(int)_evrakTip,(int)_tip,(int)_tur, ref sonuc);
        //            if (sonuc == "0")
        //                return false;
        //            else
        //                return true;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //        throw;
        //    }
        //}

        public static bool SetUserYetki()
        {
            try
            {
                using (var funcs = new FunctionsTableAdapter())
                {
                    funcs._sp_UserYetki();

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        //public static bool SetDilKey(string KaynakDil,string HedefDil)
        //{
        //    try
        //    {
        //        using (var funcs = new FunctionsTableAdapter())
        //        {
        //            funcs._sp_DilKeyUpdate(KaynakDil,HedefDil);

        //            return true;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //        throw;
        //    }
        //}

        //public static bool SetUserShortcuts()
        //{
        //    try
        //    {
        //        using (var funcs = new FunctionsTableAdapter())
        //        {
        //            funcs._sp_UserShortcut();

        //            return true;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //        throw;
        //    }
        //}

        //public static bool UpdateUserLanguageOnLogin(string kullanici, string language)
        //{
        //    try
        //    {
        //        using (var funcs = new FunctionsTableAdapter())
        //        {
        //            funcs._sp_UpdateUserLanguageOnLogin(language, kullanici);

        //            return true;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //        throw;
        //    }
        //}
       
     
        public static IEnumerable<FileInfo> DosyaListesi(DirectoryInfo KokDizin, string Uzanti, string DosyaAdiParcasi)
        {
            foreach (var f in KokDizin.GetFiles().Where(Dosya => Dosya.Extension == Uzanti && Dosya.Name.Contains(DosyaAdiParcasi)))
                yield return f;

            foreach (DirectoryInfo d in KokDizin.GetDirectories())
                foreach (var f in DosyaListesi(d, Uzanti, DosyaAdiParcasi))
                    yield return f;
        }


        public static string GetCurrentDateTime()
        {
            return DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

    }
}
