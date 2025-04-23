using cafe_yonetim_sistemi_Enities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_yonetim_sistemi_Enities.Models
{
    public class OdemeHareketleri : IEntity
    {
        public int ID { get; set; }
        public string SatisKodu { get; set; }
        public string OdemeTuru { get; set; }
        public decimal Odenen { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
    }
}

