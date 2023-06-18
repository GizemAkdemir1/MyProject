using PiggyBankl.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBankl.Concrete
{
    public class Kumbara : ISalla
    {
        public Kumbara(int hacim)
        {
            KumbaraHacmi = hacim;
        }
        public double KumbaraHacmi { get; set; }

        public double ToplamParaHacim { get; set; }
        public void ParaEkle(double miktar)
        {
            ToplamParaHacim += miktar;
        }
    }
}
