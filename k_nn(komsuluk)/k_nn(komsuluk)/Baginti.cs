using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_nn
{
    public abstract class Baginti
    {
        protected Baginti _sonrakiBaginti;
        public Baginti sonrakiBaginti
        {
            set { _sonrakiBaginti = value; }
        }
        public abstract void islem(string baginti, Veri egitim, Veri test);

     
        
        
    }
}
