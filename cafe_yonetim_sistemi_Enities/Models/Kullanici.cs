using cafe_yonetim_sistemi_Enities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_yonetim_sistemi_Enities.Models
{
    public class Kullanici : IEntity
    {
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string Gorevi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string HatirlatmaSorusu { get; set; }
        public string Cevap { get; set; }
        public string Aciklama { get; set; }
        public DateTime KayitTarihi { get; set; }
        public bool Aktifmi { get; set; }
        public virtual ICollection<KullaniciHareketleri> KullaniciHareketleri { get; set; }
        public virtual ICollection<Masa> masalar { get; set; }
    }
}
