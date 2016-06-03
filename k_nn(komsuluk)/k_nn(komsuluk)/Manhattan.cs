using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k_nn
{
    class Manhattan:Baginti
    {
        public override void islem(string baginti, Veri egitim, Veri test)
        {
            if (baginti == "Manhattan")
            {
                
                double hesapla = 0;
                for (int sut = 0; sut < egitim.degerler.Count; sut++)//Veri Sınıfındaki List ti dolduguruyor.
                {
                    hesapla += Math.Abs(egitim.degerlerGet(sut) - test.degerlerGet(sut));

                }
                egitim.uzaklikSet(Math.Round(Convert.ToDouble(Math.Sqrt(hesapla)), 5));
            }
            else
            {
                if (_sonrakiBaginti != null)
                {
                    _sonrakiBaginti.islem(baginti, egitim, test);
                }
            }
        }


       
    }
}
