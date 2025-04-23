using cafe_yonetim_sistemi_Enities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema; // Bunu Sql'deki elemanların typelerini belirlemek için koyduk
using System.ComponentModel.DataAnnotations; // Bunuda Sql'deki elemanlara sınırlama getirmek için kullandık

namespace cafe_yonetim_sistemi_Enities.Models
{
    public class Urun : IEntity
    {
        public int ID { get; set; }

        public int MenuID { get; set; }
        public string UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public decimal BirimFiyat1 { get; set; }
        public decimal BirimFiyat2 { get; set; }
        public decimal BirimFiyat3 { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public string Resim { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual ICollection<MasaHareketleri> MasaHareketleri { get; set; }
    }
}
