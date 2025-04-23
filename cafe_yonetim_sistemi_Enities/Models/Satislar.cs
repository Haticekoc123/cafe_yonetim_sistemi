using cafe_yonetim_sistemi_Enities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_yonetim_sistemi_Enities.Models
{
    public class Satislar : IEntity
    {
        public int ID { get; set; }
        public string SatisKodu { get; set; }
        public int? MusteriID { get; set; }
        public decimal Tutar { get; set; }
        public decimal IndirimTutari { get; set; }
        public decimal Odenen { get; set; }
        public decimal Kalan { get; set; }
        public string Aciklama { get; set; }
        public bool Paketmi { get; set; } = false;
        public DateTime SonIslemTarihi { get; set; }
        public virtual Musteriler Musteriler { get; set; }

    }
}
