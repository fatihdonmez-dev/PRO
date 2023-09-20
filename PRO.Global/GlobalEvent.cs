using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PRO.Global
{
    public static class GlobalEvent
    {

        //#region FaturaAcma

        //public delegate void OnFaturaAcEventHandler(MenuData _mnuData, DataTable _dt,bool _irsaliyemi);
        //public static event OnFaturaAcEventHandler OnFaturaAc;
        //public static void SendFaturaAc(MenuData _mnuData, DataTable _dt, bool _irsaliyemi)
        //{
        //    if (OnFaturaAc != null)
        //    {
        //        OnFaturaAc(_mnuData, _dt, _irsaliyemi);
        //    }
        //}

        //#endregion

        #region DilCevrimleriGuncellendiEventHandler

        public delegate void OnDilCevrimleriGuncellendiEventHandler();
        public static event OnDilCevrimleriGuncellendiEventHandler OnDilCevrimleriGuncellendi;
        public static void SendOnDilCevrimleriGuncellendi()
        {
            if (OnDilCevrimleriGuncellendi != null)
            {
                OnDilCevrimleriGuncellendi();
            }
        }


        #region MakinaListeYenileEventHandler

        public delegate void MakinaListeYenileEventHandler();
        public static event MakinaListeYenileEventHandler OnMakinaListeYenile;
        public static void SendMakinaListeYenile()
        {
            if (OnMakinaListeYenile != null)
            {
                OnMakinaListeYenile();
            }
        }

        #endregion

        #region HesapKartEventHandler

        public delegate void HesapKartEventHandler(string menuNo, string dilKey, string kartTipi, Guid kartID, MenuData FormData);
        public static event HesapKartEventHandler OnHesapKart;
        public static void SendHesapKart(string menuNo, string dilKey, string kartTipi, Guid kartID, MenuData FormData)
        {
            if (OnHesapKart != null)
            {
                OnHesapKart(menuNo, dilKey, kartTipi, kartID, FormData);
            }
        }

        #endregion

        #region SirketFabrikaEventHandler

        public delegate void SirketFabrikaEventHandler(string Sirket, string Fabrika);
        public static event SirketFabrikaEventHandler OnSirketFabrika;
        public static void SendSirketFabrika(string Sirket, string Fabrika)
        {
            if (OnSirketFabrika != null)
            {
                OnSirketFabrika(Sirket, Fabrika);
            }
        }

        #endregion

        #region YetkilerGuncellendiEventHandler

        public delegate void YetkilerGuncellendiEventHandler();
        public static event YetkilerGuncellendiEventHandler OnYetkilerGuncellendi;
        public static void SendYetkilerGuncellendi()
        {
            if (OnYetkilerGuncellendi != null)
            {
                OnYetkilerGuncellendi();
            }
        }

        #endregion


        #endregion

        #region KopyalamaEventi

        public delegate void KopyalaEventHandler();
        public static event KopyalaEventHandler OnKopyalaThreadFinish;
        public static void KopyalaThreadFinish()
        {
            if (OnKopyalaThreadFinish != null)
            {
                OnKopyalaThreadFinish();
            }
        }

        #endregion

        #region GuncellemeEventi

        public delegate void GuncelleEventHandler();
        public static event GuncelleEventHandler OnGuncelleThreadFinish;
        public static void GuncelleThreadFinish()
        {
            if (OnGuncelleThreadFinish != null)
            {
                OnGuncelleThreadFinish();
            }
        }

        #endregion

        #region Guncelle Butonu enable

        public delegate void barGuncelleEventHandler();
        public static event barGuncelleEventHandler OnbarGuncelleEnable;
        public static void barGuncelleEnable()
        {
            if (OnbarGuncelleEnable != null)
            {
                OnbarGuncelleEnable();
            }
        }

        #endregion

        #region UygulamayiKapat

        public delegate void AppCloseEventHandler();
        public static event AppCloseEventHandler OnfrmGuncelleOK;
        public static void frmGuncelleOK()
        {
            if (OnfrmGuncelleOK != null)
            {
                OnfrmGuncelleOK();
            }
        }

        #endregion

    }

}
