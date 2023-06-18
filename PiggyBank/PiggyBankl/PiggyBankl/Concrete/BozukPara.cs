using PiggyBankl.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBankl.Concrete
{
    public class BozukPara : Para
    {
        public const double PI = 3.14;
        public double Cap { get; set; }
        public double Yukseklik { get; set; }
        public override double Hacim()
        {
            return Yukseklik * (Cap / 2) * (Cap / 2) * PI;
        }
        public double MinumumHacim(double hacim)
        {
            return hacim * 1.25;
        }
        public double FazladanHacimHesapla(double hacim)
        {
            Random rnd = new Random();
            return hacim * rnd.Next(25, 76) * 0.01;
        }
        public override string ToString()
        {
            return $"{Ad}";
        }
    }
}
