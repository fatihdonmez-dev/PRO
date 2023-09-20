using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace PRO.Global
{
    public class RawPrint
    {

        //public static string RawYazdirDizi( _Tables _table, Guid _evrakID, string _rid , string _UDFParams = "")
        //{
        //    #region LISTE
        //    string _pr = string.Empty;
        //    string _r = _evrakID.ToString().Replace("-", "");
        //    if (_UDFParams == string.Empty)
        //        _pr = string.Format("EvrID='{0}'", _r);
        //    DataTable _Liste = _table.GetDataList(_pr, _UDFParams, _UDFParams != "");
        //    if (_Liste.Rows.Count == 0)
        //        return "";

        //    foreach (DataColumn dc in _Liste.Columns)
        //    {
        //        if (dc.ColumnName == "SiralamaSutunlari")
        //        {
        //            string _orderby = _Liste.Rows[0]["SiralamaSutunlari"].ToString();
        //            if (_orderby.Split(',').Count() > 1)
        //                _Liste = _Liste.AsEnumerable().ToList().OrderBy(a1 => a1.Field<string>(_orderby.Split(',')[0])).ThenBy(a1 => a1.Field<string>(_orderby.Split(',')[1])).CopyToDataTable();
        //            else
        //                _Liste = _Liste.AsEnumerable().ToList().OrderBy(a1 => a1.Field<string>(_orderby)).CopyToDataTable();
        //        }
        //    }

        //    decimal j = 0;
        //    string _yazi = "";
        //    var x = (decimal)_Liste.Rows[0]["Toplam"];
        //    j = Convert.ToDecimal(x);
        //    _yazi = j.YaziyaCevir();

        //    foreach (DataRow i in _Liste.Rows)
        //    {
        //        i.BeginEdit();
        //        i["ToplamYazi"] = _yazi;
        //        i.EndEdit();
        //    }




        //    #endregion
        //    #region DATA

        //    //string _boss = "";
        //    char[, ,] tablo = new char[1, 1, 1];
        //    int _SayfaSayisi = 0;
        //    int _Satir = 0;
        //    int _sutun = 0;
        //    char _pc = Convert.ToChar(" ");
        //    string _s = string.Format("RprID='{0}'", _rid);
        //    //DataTable _Matrix = _Tables.V_Rapor_Matrix.GetDataList(_s);
        //    //DataTable _MatrixDetay = _Tables.V_Rapor_Matrix_Detay.GetDataList(_s, "Sutun");
        //    //DataTable _MatrixBaslik = _Tables.V_Rapor_Matrix_Baslik.GetDataList(_s, "Satir", "Sutun");
        //    //DataTable _MatrixSon = _Tables.V_Rapor_Matrix_Son.GetDataList(_s, "Satir", "Sutun");

        //    //if (_Matrix.Rows.Count > 0)
        //    //{
        //    //    #region GET

        //    //    //int _sira = 1;
        //    //    int _detayBas = (int)_Matrix.Rows[0]["DetayBaslangic"];
        //    //    int _detayBit = (int)_Matrix.Rows[0]["DetayBitis"];
        //    //    int _sonBas = (int)_Matrix.Rows[0]["SayfaSonuBas"];
        //    //    int _sonSatir = (int)_Matrix.Rows[0]["SayfaSonuSatir"];

        //    //    _Satir = (int)_Matrix.Rows[0]["SatirSayisi"];
        //    //    _sutun = (int)_Matrix.Rows[0]["SutunSayisi"];

        //    //    decimal _detaySatir = Convert.ToDecimal(_detayBit - _detayBas);
        //    //    decimal _toplamSatir = Convert.ToDecimal(_Liste.Rows.Count);
        //    //    if (_toplamSatir > 0 && _detaySatir > 0)
        //    //        _SayfaSayisi = Convert.ToInt32(Math.Ceiling(_toplamSatir / _detaySatir));
        //    //    else
        //    //        return "";
        //    //    #endregion
        //    //    #region TABLO
        //    //    tablo = new char[_SayfaSayisi, _Satir, _sutun];
        //    //    for (int i1 = 0; i1 < _SayfaSayisi; i1++)
        //    //    {
        //    //        for (int i2 = 0; i2 < _Satir; i2++)
        //    //        {
        //    //            for (int i3 = 0; i3 < _sutun; i3++)
        //    //            {
        //    //                tablo[i1, i2, i3] = _pc;
        //    //            }
        //    //        }
        //    //    }
        //    //    #endregion
        //    //    #region SAYFA BASI
        //    //    DataRow _kayit = _Liste.Rows[0];
        //    //    foreach (DataRow _rw in _MatrixBaslik.Rows)
        //    //    {
        //    //        string _deger = "";
        //    //        string _a = "";

        //    //        int _uz = (int)_rw["Uzunluk"];
        //    //        int _str = (int)_rw["Satir"];
        //    //        int _sut = (int)_rw["Sutun"];
        //    //        int _bas = (int)_rw["Basamak"];

        //    //        Type _type = _kayit[_rw["Alan"].ToString()].GetType();
        //    //        if (_type.Name == "Decimal")
        //    //        {
        //    //            decimal _dc = (decimal)_kayit[_rw["Alan"].ToString()];
        //    //            _a = _dc.Yuvarla(_bas).ToString();
        //    //            string str =String.Format("{0:#.#}", _a); 
        //    //            _deger = str.PadLeft(_uz, _pc);
        //    //        }
        //    //        else if (_type.Name == "DateTime")
        //    //        {
        //    //            DateTime _dtime = (DateTime)_kayit[_rw["Alan"].ToString()];
        //    //            if (_dtime != null)
        //    //            {
        //    //                string _gunx = _dtime.Day.ToString();
        //    //                string _ayx = _dtime.Month.ToString();
        //    //                string _yilx = _dtime.Year.ToString();
        //    //                _gunx = _gunx.PadLeft(2, Convert.ToChar("0"));
        //    //                _ayx = _ayx.PadLeft(2, Convert.ToChar("0"));
        //    //                _deger = string.Format("{0}.{1}.{2}", _gunx, _ayx, _yilx);
        //    //            }
        //    //            else
        //    //                _deger = _a.PadLeft(_uz, _pc);

        //    //        }
        //    //        else
        //    //        {
        //    //            _a = _kayit[_rw["Alan"].ToString()].ToString();
        //    //            _deger = _a.PadRight(_uz, _pc);
        //    //            _deger = _deger.Substring(0, _uz);
        //    //        }

        //    //        for (int i1 = 0; i1 < _SayfaSayisi; i1++)
        //    //        {
        //    //            int _st = _sut;
        //    //            foreach (char c in _deger)
        //    //            {
        //    //                if (_st >= _sutun)
        //    //                    break;

        //    //                tablo[i1, _str - 1, _st - 1] = c;
        //    //                _st++;
        //    //            }

        //    //        }
        //    //    }
        //    //    #endregion
        //    //    #region SAYFA SONU
        //    //    foreach (DataRow _rw in _MatrixSon.Rows)
        //    //    {
        //    //        string _deger = "";
        //    //        string _a = "";

        //    //        int _uz = (int)_rw["Uzunluk"];
        //    //        int _str = (int)_rw["Satir"];
        //    //        int _sut = (int)_rw["Sutun"];
        //    //        int _bas = (int)_rw["Basamak"];

        //    //        Type _type = _kayit[_rw["Alan"].ToString()].GetType();
        //    //        if (_type.Name == "Decimal")
        //    //        {
        //    //            decimal _dc = (decimal)_kayit[_rw["Alan"].ToString()];
        //    //            _a = _dc.Yuvarla(_bas).ToString();
        //    //            string str = String.Format("{0:#.#}", _a);
        //    //            _deger = str.PadLeft(_uz, _pc);
        //    //        }
        //    //        else if (_type.Name == "DateTime")
        //    //        {
        //    //            DateTime _dtime = (DateTime)_kayit[_rw["Alan"].ToString()];
        //    //            if (_dtime != null)
        //    //            {
        //    //                string _gunx = _dtime.Day.ToString();
        //    //                string _ayx = _dtime.Month.ToString();
        //    //                string _yilx = _dtime.Year.ToString();
        //    //                _gunx = _gunx.PadLeft(2, Convert.ToChar("0"));
        //    //                _ayx = _ayx.PadLeft(2, Convert.ToChar("0"));
        //    //                _deger = string.Format("{0}.{1}.{2}", _gunx, _ayx, _yilx);
        //    //            }
        //    //            else
        //    //                _deger = _a.PadLeft(_uz, _pc);

        //    //        }
        //    //        else
        //    //        {
        //    //            _a = _kayit[_rw["Alan"].ToString()].ToString();
        //    //            _deger = _a.PadRight(_uz, _pc);
        //    //            _deger = _deger.Substring(0, _uz);
        //    //        }

        //    //        for (int i1 = 0; i1 < _SayfaSayisi; i1++)
        //    //        {
        //    //            int _st = _sut;
        //    //            foreach (char c in _deger)
        //    //            {
        //    //                if (_st >= _sutun)
        //    //                    break;

        //    //                tablo[i1, _str - 1, _st - 1] = c;
        //    //                _st++;
        //    //            }
        //    //        }
        //    //    }
        //    //    #endregion
        //    //    #region DETAY

        //    //    int _sayfaS = 0;
        //    //    int _satirS = _detayBas;
        //    //    foreach (DataRow dty in _Liste.Rows)
        //    //    {
        //    //        #region DETAY YAZ
        //    //        foreach (DataRow _rw in _MatrixDetay.Rows)
        //    //        {
        //    //            string _deger = "";
        //    //            string _a = "";

        //    //            int _uz = (int)_rw["Uzunluk"];
        //    //            int _sut = (int)_rw["Sutun"];
        //    //            int _bas = (int)_rw["Basamak"];

        //    //            Type _type = dty[_rw["Alan"].ToString()].GetType();
        //    //            if (_type.Name == "Decimal")
        //    //            {
        //    //                decimal _dc = (decimal)dty[_rw["Alan"].ToString()];
        //    //                _a = _dc.Yuvarla(_bas).ToString();
        //    //                string str = String.Format("{0:#.#}", _a); 
        //    //                _deger = str.PadLeft(_uz, _pc);
        //    //            }
        //    //            else if (_type.Name == "DateTime")
        //    //            {
        //    //                DateTime _dtime = (DateTime)dty[_rw["Alan"].ToString()];
        //    //                if (_dtime != null)
        //    //                {
        //    //                    string _gunx = _dtime.Day.ToString();
        //    //                    string _ayx = _dtime.Month.ToString();
        //    //                    string _yilx = _dtime.Year.ToString();
        //    //                    _gunx = _gunx.PadLeft(2, Convert.ToChar("0"));
        //    //                    _ayx = _ayx.PadLeft(2, Convert.ToChar("0"));
        //    //                    _deger = string.Format("{0}.{1}.{2}", _gunx, _ayx, _yilx);
        //    //                }

        //    //                else
        //    //                    _deger = _a.PadLeft(_uz, _pc);

        //    //            }
        //    //            else
        //    //            {
        //    //                _a = dty[_rw["Alan"].ToString()].ToString();
        //    //                _deger = _a.PadRight(_uz, _pc);
        //    //                _deger = _deger.Substring(0, _uz);
        //    //            }
        //    //            foreach (char c in _deger)
        //    //            {
        //    //                if (_sut >= _sutun)
        //    //                    break;

        //    //                tablo[_sayfaS, _satirS - 1, _sut - 1] = c;
        //    //                _sut++;
        //    //            }

        //    //        }
        //    //        #endregion


        //    //        _satirS++;
        //    //        if (_satirS > _detayBit)
        //    //        {
        //    //            _satirS = _detayBas;
        //    //            _sayfaS++;
        //    //        }
        //    //    }

        //    //    #endregion



        //    }

        //    #endregion
        //    #region YAZDIR
        //    string _Dosya = "";
        //    for (int syf = 0; syf < tablo.GetLength(0); syf++)
        //    {
        //        for (int str = 0; str < tablo.GetLength(1); str++)
        //        {
        //            for (int col = 0; col < tablo.GetLength(2); col++)
        //            {
        //                _Dosya += tablo[syf, str, col];
        //            }
        //            _Dosya += "\r\n";
        //        }
        //    }


        //    return _Dosya;
        //    #endregion
        //}


        //public static string RawYazdirDizi(string _pName, _Tables _table, Guid _evrakID, string _rid,bool _preview=false,bool _printerSec=false)
        //{
        //    try
        //    {
        //        #region LISTE
        //        string _r = _evrakID.ToString().Replace("-", "");
        //        string _pr = string.Format("EvrID='{0}'", _r);
        //        DataTable _Liste = _table.GetDataList(_pr);
        //        decimal j = 0;
        //        string _yazi = "";
        //        var x = (decimal)_Liste.Rows[0]["Toplam"];
        //        j = Convert.ToDecimal(x);
        //        _yazi = j.YaziyaCevir();

        //        foreach (DataRow i in _Liste.Rows)
        //        {
        //            i.BeginEdit();
        //            i["ToplamYazi"] = _yazi;
        //            i.EndEdit();
        //        }


        //        RawPrinterHelper _rp = new RawPrinterHelper();
        //        if (_printerSec)
        //            _rp.ChoosePrinter();
        //        else
        //            _rp.PrinterName = _pName;
        //        if (!_preview)
        //            if (!_rp.Open("LTS Raw Print")) return "";

        //        #endregion
        //        #region DATA

        //        //string _boss = "";
        //        char[, ,] tablo = new char[1, 1, 1];
        //        int _SayfaSayisi = 0;
        //        int _Satir = 0;
        //        int _sutun = 0;
        //        char _pc = Convert.ToChar(" ");
        //        string _s = string.Format("RprID='{0}'", _rid);
        //        //DataTable _Matrix = _Tables.V_Rapor_Matrix.GetDataList(_s);
        //        //DataTable _MatrixDetay = _Tables.V_Rapor_Matrix_Detay.GetDataList(_s, "Sutun");
        //        //DataTable _MatrixBaslik = _Tables.V_Rapor_Matrix_Baslik.GetDataList(_s, "Satir", "Sutun");
        //        //DataTable _MatrixSon = _Tables.V_Rapor_Matrix_Son.GetDataList(_s, "Satir", "Sutun");

        //        if (_Matrix.Rows.Count > 0)
        //        {
        //            #region GET

        //            //int _sira = 1;
        //            int _detayBas = (int)_Matrix.Rows[0]["DetayBaslangic"];
        //            int _detayBit = (int)_Matrix.Rows[0]["DetayBitis"];
        //            int _sonBas = (int)_Matrix.Rows[0]["SayfaSonuBas"];
        //            int _sonSatir = (int)_Matrix.Rows[0]["SayfaSonuSatir"];

        //            _Satir = (int)_Matrix.Rows[0]["SatirSayisi"];
        //            _sutun = (int)_Matrix.Rows[0]["SutunSayisi"];

        //            decimal _detaySatir = Convert.ToDecimal(_detayBit - _detayBas);
        //            decimal _toplamSatir = Convert.ToDecimal(_Liste.Rows.Count);
        //            _SayfaSayisi = Convert.ToInt32(Math.Ceiling(_toplamSatir / _detaySatir));
        //            #endregion
        //            #region TABLO
        //            tablo = new char[_SayfaSayisi, _Satir, _sutun];
        //            for (int i1 = 0; i1 < _SayfaSayisi; i1++)
        //            {
        //                for (int i2 = 0; i2 < _Satir; i2++)
        //                {
        //                    for (int i3 = 0; i3 < _sutun; i3++)
        //                    {
        //                        tablo[i1, i2, i3] = _pc;
        //                    }
        //                }
        //            }
        //            #endregion
        //            #region SAYFA BASI
        //            DataRow _kayit = _Liste.Rows[0];
        //            foreach (DataRow _rw in _MatrixBaslik.Rows)
        //            {
        //                string _deger = "";
        //                string _a = "";

        //                int _uz = (int)_rw["Uzunluk"];
        //                int _str = (int)_rw["Satir"];
        //                int _sut = (int)_rw["Sutun"];
        //                int _bas = (int)_rw["Basamak"];

        //                Type _type = _kayit[_rw["Alan"].ToString()].GetType();
        //                if (_type.Name == "Decimal")
        //                {
        //                    decimal _dc = (decimal)_kayit[_rw["Alan"].ToString()];
        //                    _a = _dc.Yuvarla(_bas).ToString();
        //                    string str = String.Format("{0:#.#}", _a);
        //                    _deger = str.PadLeft(_uz, _pc);
        //                }
        //                else if (_type.Name == "DateTime")
        //                {
        //                    DateTime _dtime = (DateTime)_kayit[_rw["Alan"].ToString()];
        //                    if (_dtime != null)
        //                    {
        //                        string _gunx = _dtime.Day.ToString();
        //                        string _ayx = _dtime.Month.ToString();
        //                        string _yilx = _dtime.Year.ToString();
        //                        _gunx = _gunx.PadLeft(2, Convert.ToChar("0"));
        //                        _ayx = _ayx.PadLeft(2, Convert.ToChar("0"));
        //                        _deger = string.Format("{0}.{1}.{2}", _gunx, _ayx, _yilx);
        //                    }
        //                    else
        //                        _deger = _a.PadLeft(_uz, _pc);

        //                }
        //                else
        //                {
        //                    _a = _kayit[_rw["Alan"].ToString()].ToString();
        //                    _deger = _a.PadRight(_uz, _pc);
        //                    _deger = _deger.Substring(0, _uz);
        //                }

        //                for (int i1 = 0; i1 < _SayfaSayisi; i1++)
        //                {
        //                    int _st = _sut;
        //                    foreach (char c in _deger)
        //                    {
        //                        if (_st >= _sutun)
        //                            break;

        //                        tablo[i1, _str - 1, _st - 1] = c;
        //                        _st++;
        //                    }

        //                }
        //            }
        //            #endregion
        //            #region SAYFA SONU
        //            foreach (DataRow _rw in _MatrixSon.Rows)
        //            {
        //                string _deger = "";
        //                string _a = "";

        //                int _uz = (int)_rw["Uzunluk"];
        //                int _str = (int)_rw["Satir"];
        //                int _sut = (int)_rw["Sutun"];
        //                int _bas = (int)_rw["Basamak"];

        //                Type _type = _kayit[_rw["Alan"].ToString()].GetType();
        //                if (_type.Name == "Decimal")
        //                {
        //                    decimal _dc = (decimal)_kayit[_rw["Alan"].ToString()];
        //                    _a = _dc.Yuvarla(_bas).ToString();
        //                    string str = String.Format("{0:#.#}", _a);
        //                    _deger = str.PadLeft(_uz, _pc);
        //                }
        //                else if (_type.Name == "DateTime")
        //                {
        //                    DateTime _dtime = (DateTime)_kayit[_rw["Alan"].ToString()];
        //                    if (_dtime != null)
        //                    {
        //                        string _gunx = _dtime.Day.ToString();
        //                        string _ayx = _dtime.Month.ToString();
        //                        string _yilx = _dtime.Year.ToString();
        //                        _gunx = _gunx.PadLeft(2, Convert.ToChar("0"));
        //                        _ayx = _ayx.PadLeft(2, Convert.ToChar("0"));
        //                        _deger = string.Format("{0}.{1}.{2}", _gunx, _ayx, _yilx);
        //                    }
        //                    else
        //                        _deger = _a.PadLeft(_uz, _pc);

        //                }
        //                else
        //                {
        //                    _a = _kayit[_rw["Alan"].ToString()].ToString();
        //                    _deger = _a.PadRight(_uz, _pc);
        //                    _deger = _deger.Substring(0, _uz);
        //                }

        //                for (int i1 = 0; i1 < _SayfaSayisi; i1++)
        //                {
        //                    int _st = _sut;
        //                    foreach (char c in _deger)
        //                    {
        //                        if (_st >= _sutun)
        //                            break;

        //                        tablo[i1, _str - 1, _st - 1] = c;
        //                        _st++;
        //                    }
        //                }
        //            }
        //            #endregion
        //            #region DETAY

        //            int _sayfaS = 0;
        //            int _satirS = _detayBas;
        //            foreach (DataRow dty in _Liste.Rows)
        //            {
        //                #region DETAY YAZ
        //                foreach (DataRow _rw in _MatrixDetay.Rows)
        //                {
        //                    string _deger = "";
        //                    string _a = "";

        //                    int _uz = (int)_rw["Uzunluk"];
        //                    int _sut = (int)_rw["Sutun"];
        //                    int _bas = (int)_rw["Basamak"];

        //                    Type _type = dty[_rw["Alan"].ToString()].GetType();
        //                    if (_type.Name == "Decimal")
        //                    {
        //                        decimal _dc = (decimal)dty[_rw["Alan"].ToString()];
        //                        _a = _dc.Yuvarla(_bas).ToString();
        //                        string str = String.Format("{0:#.#}", _a);
        //                        _deger = str.PadLeft(_uz, _pc);
        //                    }
        //                    else if (_type.Name == "DateTime")
        //                    {
        //                        DateTime _dtime = (DateTime)dty[_rw["Alan"].ToString()];
        //                        if (_dtime != null)
        //                        {
        //                            string _gunx = _dtime.Day.ToString();
        //                            string _ayx = _dtime.Month.ToString();
        //                            string _yilx = _dtime.Year.ToString();
        //                            _gunx = _gunx.PadLeft(2, Convert.ToChar("0"));
        //                            _ayx = _ayx.PadLeft(2, Convert.ToChar("0"));
        //                            _deger = string.Format("{0}.{1}.{2}", _gunx, _ayx, _yilx);
        //                        }

        //                        else
        //                            _deger = _a.PadLeft(_uz, _pc);

        //                    }
        //                    else
        //                    {
        //                        _a = dty[_rw["Alan"].ToString()].ToString();
        //                        _deger = _a.PadRight(_uz, _pc);
        //                        _deger = _deger.Substring(0, _uz);
        //                    }
        //                    foreach (char c in _deger)
        //                    {
        //                        if (_sut >= _sutun)
        //                            break;

        //                        tablo[_sayfaS, _satirS - 1, _sut - 1] = c;
        //                        _sut++;
        //                    }

        //                }
        //                #endregion


        //                _satirS++;
        //                if (_satirS > _detayBit)
        //                {
        //                    _satirS = _detayBas;
        //                    _sayfaS++;
        //                }
        //            }

        //            #endregion



        //        }

        //        #endregion
        //        #region YAZDIR
        //        string _Dosya = "";
        //        for (int syf = 0; syf < tablo.GetLength(0); syf++)
        //        {
        //            for (int str = 0; str < tablo.GetLength(1); str++)
        //            {
        //                for (int col = 0; col < tablo.GetLength(2); col++)
        //                {
        //                    _Dosya += tablo[syf, str, col];
        //                }
        //                _Dosya += "\r\n";
        //            }
        //        }

        //        if (_preview)
        //            return _Dosya;
        //        else
        //        {
        //            if (!_rp.Open("LTS Raw Print")) return "";
        //            _rp.Print(_Dosya);
        //            _rp.Close();
        //        }
        //        #endregion
        //        return "";
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return "";
        //    }
        //}

        //public static bool RawYazdir(string _pName, _Tables _table, Guid _evrakID, string _rid)
        //{

        //    //var row = dsEvrak.FNS_Evrak[0];
        //    //if (row == null) return;

        //    //string _r = row.EvrakID.ToString().Replace("-", "");
        //    string _r = _evrakID.ToString().Replace("-", "");
        //    string _pr = string.Format("EvrID='{0}'", _r);
        //    //DataTable _Liste = _Tables.V_FaturaYazdir.GetDataList(_pr);
        //    DataTable _Liste = _table.GetDataList(_pr);
        //    decimal j = 0;
        //    string _yazi = "";
        //    var x = (decimal)_Liste.Rows[0]["Toplam"];
        //    j = Convert.ToDecimal(x);
        //    _yazi = j.YaziyaCevir();

        //    foreach (DataRow i in _Liste.Rows)
        //    {
        //        i.BeginEdit();
        //        i["ToplamYazi"] = _yazi;
        //        i.EndEdit();
        //    }

        //    //string _rid = "810962E757D64214A4279420EEDB2781";
        //    //_rid = _rid.Replace("-", "");

        //    string _s = string.Format("RprID='{0}'", _rid);
        //    DataTable _Matrix = _Tables.V_Rapor_Matrix.GetDataList(_s);
        //    DataTable _MatrixDetay = _Tables.V_Rapor_Matrix_Detay.GetDataList(_s, "Sutun");
        //    DataTable _MatrixBaslik = _Tables.V_Rapor_Matrix_Baslik.GetDataList(_s, "Satir", "Sutun");
        //    DataTable _MatrixSon = _Tables.V_Rapor_Matrix_Son.GetDataList(_s, "Satir", "Sutun");

        //    if (_Matrix.Rows.Count > 0)
        //    {
        //        RawPrinterHelper _rp = new RawPrinterHelper();
        //        _rp.ChoosePrinter();
        //        //_rp.PrinterName = _pName;
        //        if (!_rp.Open("LTS Raw Print")) return false;
        //        int _sira = 1;
        //        int _detayBas = (int)_Matrix.Rows[0]["DetayBaslangic"];
        //        int _detayBit = (int)_Matrix.Rows[0]["DetayBitis"];
        //        int _sonBas = (int)_Matrix.Rows[0]["SayfaSonuBas"];
        //        int _sonSatir = (int)_Matrix.Rows[0]["SayfaSonuSatir"];

        //        char _pc = Convert.ToChar(" ");

        //        string _sayfaBasi = "";
        //        string _detay = "";
        //        string _sayfaSonu = "";

        //        string _Dosya = "";


        //        #region SAYFA BASI
        //        _sayfaBasi = "";
        //        if (_MatrixBaslik.Rows.Count > 0)
        //        {
        //            for (int i = 1; i < ((int)_MatrixBaslik.Rows[0]["Satir"]); i++)
        //            {
        //                _sayfaBasi += "\r\n";
        //            }

        //            int baslikSatir = 0;
        //            DataRow _kayit = _Liste.Rows[0];
        //            foreach (DataRow _baslik in _MatrixBaslik.Rows)
        //            {

        //                while (true)
        //                {
        //                    if ((int)_baslik["Satir"] == baslikSatir)
        //                        break;
        //                    _sayfaBasi += "\r\n";
        //                    baslikSatir++;
        //                }

        //                string _deger = "";
        //                string _a = "";

        //                int _uz = (int)_baslik["Uzunluk"];
        //                Type _type = _kayit[_baslik["Alan"].ToString()].GetType();
        //                if (_type.Name == "Decimal")
        //                {
        //                    decimal _dc = (decimal)_kayit[_baslik["Alan"].ToString()];
        //                    _a = _dc.Yuvarla(2).ToString();
        //                    _deger = _a.PadLeft(_uz, _pc);
        //                }
        //                else if (_type.Name == "DateTime")
        //                {
        //                    DateTime _dtime = (DateTime)_kayit[_baslik["Alan"].ToString()];
        //                    if (_dtime != null)
        //                        _deger = string.Format("{0}.{1}.{2}", _dtime.Day.ToString(), _dtime.Month.ToString(), _dtime.Year.ToString());
        //                    else
        //                        _deger = _a.PadLeft(_uz, _pc);

        //                }
        //                else
        //                {
        //                    _a = _kayit[_baslik["Alan"].ToString()].ToString();
        //                    _deger = _a.PadRight(_uz, _pc);
        //                    _deger = _deger.Substring(0, _uz);
        //                }

        //                int _bos = (int)_baslik["Bosluk"];
        //                string _boss = "";
        //                _boss = _boss.PadLeft(_bos, _pc);
        //                _sayfaBasi += _boss + _deger + " ";
        //            }
        //            for (int i = 1; i < (_detayBas - baslikSatir); i++)
        //            {
        //                _sayfaBasi += "\r\n";
        //            }



        //        }

        //        #endregion
        //        #region SAYFA SONU
        //        _sayfaSonu = "";
        //        if (_MatrixSon.Rows.Count > 0)
        //        {
        //            int baslikSatir = 0;
        //            DataRow _kayit = _Liste.Rows[0];
        //            foreach (DataRow _son in _MatrixSon.Rows)
        //            {
        //                while (true)
        //                {
        //                    if ((int)_son["Satir"] == baslikSatir)
        //                        break;

        //                    _sayfaSonu += "\r\n";
        //                    baslikSatir++;
        //                }

        //                //if ((int)_son["Satir"] != baslikSatir)
        //                //    _sayfaSonu += "\r\n";
        //                //baslikSatir = (int)_son["Satir"];

        //                string _deger = "";
        //                string _a = "";

        //                int _uz = (int)_son["Uzunluk"];
        //                Type _type = _kayit[_son["Alan"].ToString()].GetType();
        //                if (_type.Name == "Decimal")
        //                {
        //                    decimal _dc = (decimal)_kayit[_son["Alan"].ToString()];
        //                    _a = _dc.Yuvarla(2).ToString();
        //                    _deger = _a.PadLeft(_uz, _pc);
        //                }
        //                else if (_type.Name == "DateTime")
        //                {
        //                    DateTime _dtime = (DateTime)_kayit[_son["Alan"].ToString()];
        //                    if (_dtime != null)
        //                        _deger = string.Format("{0}.{1}.{2}", _dtime.Day.ToString(), _dtime.Month.ToString(), _dtime.Year.ToString());
        //                    else
        //                        _deger = _a.PadLeft(_uz, _pc); ;

        //                }
        //                else
        //                {
        //                    _a = _kayit[_son["Alan"].ToString()].ToString();
        //                    _deger = _a.PadRight(_uz, _pc);
        //                    _deger = _deger.Substring(0, _uz);
        //                }

        //                int _bos = (int)_son["Bosluk"];
        //                string _boss = "";
        //                _boss = _boss.PadLeft(_bos, _pc);
        //                _sayfaSonu += _boss + _deger + " ";
        //            }
        //            for (int i = 1; i < (_sonSatir - baslikSatir); i++)
        //            {
        //                _sayfaSonu += "\r\n";
        //            }
        //        }

        //        #endregion
        //        #region DETAY
        //        //for (int i = 0; i < (_sBas-_sira); i++)
        //        //{
        //        //    _rp.Print("\r\n");
        //        //}
        //        _Dosya = "";
        //        //_sira = _detayBas;
        //        _sira = 1;
        //        bool _aToplamYaz = false;
        //        foreach (DataRow dty in _Liste.Rows)
        //        {
        //            if (_sira < _detayBas)
        //            {
        //                for (int i = 1; i < _detayBas; i++)
        //                {
        //                    _detay += "\r\n";
        //                }
        //                _sira = _detayBas;
        //            }

        //            if (_sira > _detayBit)
        //            {
        //                _Dosya += _sayfaBasi;
        //                _Dosya += _detay;// +"\r\n";
        //                for (int i = 1; i < (_sonBas - _sira); i++)
        //                {
        //                    _Dosya += "\r\n";
        //                }
        //                // Ara Toplam Yaz
        //                if (_aToplamYaz == true)
        //                {
        //                    foreach (DataRow mdr in _MatrixDetay.Rows)
        //                    {
        //                        if ((bool)mdr["AraToplam"] == true)
        //                        {
        //                            int _uz = (int)mdr["Uzunluk"];
        //                            int _aTopBos = (int)mdr["AraToplamBosluk"];
        //                            decimal _aTop = (decimal)mdr["Toplam"];
        //                            string _a = _aTop.Yuvarla(2).ToString();
        //                            string _deger = _a.PadLeft(_uz, _pc);

        //                            string _boss = "";
        //                            _boss = _boss.PadLeft(_aTopBos, _pc);
        //                            _deger = _boss + _deger;

        //                            _Dosya += _deger + "\r\n"; ;
        //                        }

        //                    }
        //                }
        //                //////////////////////////////
        //                _Dosya += _sayfaSonu + "\r\n";
        //                _sira = _detayBas;
        //                _detay = "";
        //            }

        //            // detay yazdır
        //            if (_MatrixDetay.Rows.Count > 0)
        //            {

        //                foreach (DataRow mdr in _MatrixDetay.Rows)
        //                {
        //                    string _deger = "";
        //                    string _a = "";

        //                    if ((bool)mdr["TekYazdirildi"] == false)
        //                    { 
        //                        int _uz = (int)mdr["Uzunluk"];
        //                        Type _type = dty[mdr["Alan"].ToString()].GetType();
        //                        if (_type.Name == "Decimal")
        //                        {
        //                            decimal _dc = (decimal)dty[mdr["Alan"].ToString()];
        //                            _a = _dc.Yuvarla(2).ToString();
        //                            _deger = _a.PadLeft(_uz, _pc);
        //                            if ((bool)mdr["AraToplam"] == true)
        //                            {
        //                                _aToplamYaz = true;
        //                                mdr.BeginEdit();
        //                                mdr["Toplam"] = (decimal)mdr["Toplam"] + _dc;
        //                                mdr.EndEdit();
        //                            }
        //                        }
        //                        else if (_type.Name == "DateTime")
        //                        {
        //                            DateTime _dtime = (DateTime)dty[mdr["Alan"].ToString()];
        //                            if (_dtime != null)
        //                                _deger = string.Format("{0}.{1}.{2}", _dtime.Day.ToString(), _dtime.Month.ToString(), _dtime.Year.ToString());
        //                            else
        //                                _deger = _a.PadLeft(_uz, _pc); ;

        //                        }
        //                        else
        //                        {
        //                            _a = dty[mdr["Alan"].ToString()].ToString();
        //                            _deger = _a.PadRight(_uz, _pc);
        //                            _deger = _deger.Substring(0, _uz);
        //                        }

        //                        int _bos = (int)mdr["Bosluk"];
        //                        string _boss = "";
        //                        _boss = _boss.PadLeft(_bos, _pc);
        //                        _detay += _boss + _deger + " ";
        //                        if ((bool)mdr["TekYazdir"] == true)
        //                        {
        //                            mdr.BeginEdit();
        //                            mdr["TekYazdirildi"] = true;
        //                            mdr.EndEdit();
        //                        }
        //                    }
        //                }
        //                _detay += "\r\n";
        //            }




        //            _sira++;
        //        }

        //        _Dosya += _sayfaBasi + "\r\n";
        //        _Dosya += _detay + "\r\n";
        //        for (int i = 1; i < (_sonBas - _sira); i++)
        //        {
        //            _Dosya += "\r\n";
        //        }
        //        // Ara Toplam Yaz
        //        if (_aToplamYaz == true)
        //        {
        //            foreach (DataRow mdr in _MatrixDetay.Rows)
        //            {
        //                if ((bool)mdr["AraToplam"] == true)
        //                {
        //                    int _uz = (int)mdr["Uzunluk"];
        //                    int _aTopBos = (int)mdr["AraToplamBosluk"];
        //                    decimal _aTop = (decimal)mdr["Toplam"];
        //                    string _a = _aTop.Yuvarla(2).ToString();
        //                    string _deger = _a.PadLeft(_uz, _pc);

        //                    string _boss = "";
        //                    _boss = _boss.PadLeft(_aTopBos, _pc);
        //                    _deger = _boss + _deger;

        //                    _Dosya += _deger + "\r\n";
        //                }
        //            }
        //        }
        //        //////////////////////////////////////
        //        _Dosya += _sayfaSonu;
        //        #endregion

        //        _rp.Print(_Dosya);
        //        _rp.Close();
        //    }
        //    return true;
        //}

    }
}
