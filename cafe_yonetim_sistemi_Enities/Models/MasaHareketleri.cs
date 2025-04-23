using cafe_yonetim_sistemi_Enities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_yonetim_sistemi_Enities.Models
{
    public class MasaHareketleri : IEntity
    {
        public int ID { get; set; }
        public string SatisKodu { get; set; }
        public int? MasaID { get; set; }
        // public int MenuID { get; set; }
        public int UrunID { get; set; }
        public int Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal IndirimTutari { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public Masa Masalar { get; set; }

        public virtual Masa Masa { get; set; }
        public virtual Urun Urun { get; set; }
    }
}
