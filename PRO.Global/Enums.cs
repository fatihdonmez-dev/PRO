using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRO.Global


{
    public enum LayoutOperation
    {
        SaveLayout,
        LoadLayout
    }

    public enum SeriTip
    {
        Normal = 0,
        Arti = 1,
        Eksi = 2
    }

    public enum KartTipi
    {
        Tumu = 0,
        Kasa = 100,
        Banka = 102,
        Satici = 110,
        Musteri = 111,
        Nakliyeci = 112,
        SaticiMusteri = 113,
        Diger = 120
    }
  
}
