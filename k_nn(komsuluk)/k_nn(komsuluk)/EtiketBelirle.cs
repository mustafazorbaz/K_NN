using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_nn
{
    class EtiketBelirle
    {
       
        private Form1 form1;
        public EtiketBelirle(Form1 form1)
        {
            
            this.form1 = form1;
        }
  
        public string etiketBelirle(List<Veri> satirlarEgitim,int k)
        {

            int sayac = 0;
            string etiket = "";
            int[] etiketSayisi = new int[k];
            for (int i = 0; i < k; i++)
            {
                sayac = 0;
                for (int j = 0; j < k; j++)
                {
                    if (satirlarEgitim[i].etiket == satirlarEgitim[j].etiket)
                    {
                        sayac++;

                    }
                }
                etiketSayisi[i] = sayac;
            }

            int buyukIndis = diziIndisiGeriyeDondur(etiketSayisi);
            for (int y = 0; y < etiketSayisi.Length; y++)
            {
                form1.listView2.Items.Add(satirlarEgitim[y].etiket);
            }
            form1.listView2.Items.Add("|||");
            etiket = satirlarEgitim[buyukIndis].etiket;
            return etiket;
        }

        public int diziIndisiGeriyeDondur(int[] dizi)
        {
            int deger = dizi[0];
            int indis = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (deger < dizi[i])
                {
                    deger = dizi[i];
                    indis = i;
                }
            }
            return indis;

        }
    }
}
