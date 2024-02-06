
using Savas.Library.Enum;


using System.Drawing;

namespace Savas.Library.Interface
{
    internal interface IHareketEden
    {
        Size HareketAlaniBoyutlari { get; }
        int HareketMesafesi { get;  }

        /// <summary>
        /// Cismi istenilen yönde hareket ettir
        /// </summary>
        /// <param name="yon">hangi yönde hareket edileceği</param>
        /// <returns>cisim duvara çarparsa true döndürür</returns>
        bool HareketEttir (Yon yon);
        
    }
}
