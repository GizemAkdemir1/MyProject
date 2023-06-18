using PiggyBankl.Abstract;
using PiggyBankl.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBankl.Concrete
{
    public class KagitPara : Para, IKatla
    {
        public double En { get; set; }
        public double Boy { get; set; }
        public double Yukseklik { get; set; } = 0.25;
        public override double Hacim()
        {
            return En * Boy * Yukseklik;
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
        public double Katla(double kagitParaHacim)
        {
            return (En / 4) * Boy * (Yukseklik * 4);
        }
        public override string ToString()
        {
            return $"{Ad}";
        }
    }
}
