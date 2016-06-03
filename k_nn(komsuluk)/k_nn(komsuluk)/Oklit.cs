using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k_nn
{
    class Oklit:Baginti
    {

        public override void islem(string baginti, Veri egitim, Veri test)
        {
            if (baginti == "Oklit")
            {
                
                double hesapla = 0;
                for (int sut = 0; sut < egitim.degerler.Count; sut++)//Veri Sınıfındaki List ti dolduguruyor.
                {
                    hesapla += Math.Pow(egitim.degerlerGet(sut) - test.degerlerGet(sut), 2);

                }
                egitim.uzaklikSet(Convert.ToDouble(Math.Sqrt(hesapla)));
            }
            else
            {
                if (_sonrakiBaginti!=null)
                {
                    _sonrakiBaginti.islem(baginti, egitim,test);
                }
            }
        }
    }
}
