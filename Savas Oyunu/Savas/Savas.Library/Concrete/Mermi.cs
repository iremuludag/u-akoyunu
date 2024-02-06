using Savas.Library.Abstract;
using System.Drawing;

namespace Savas.Library.Concrete
{
    internal class Mermi : Cisim
    {
        public Mermi(Size hareketAlaniBoyutlari, int namluOrtasiX) : base(hareketAlaniBoyutlari)
        {
            BaslangicKonumuAyarla(namluOrtasiX);
            HareketMesafesi = (int) (Height * 1.5) ;
        }

        private void BaslangicKonumuAyarla(int namluOrtasiX)
        {
            Bottom = HareketAlaniBoyutlari.Height;
            Center = namluOrtasiX;
        }
    }
}
