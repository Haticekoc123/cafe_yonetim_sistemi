using cafe_yonetim_sistemi_Enities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_yonetim_sistemi_Enities.Models
{
    public class KullaniciHareketleri : IEntity
    {
        public int ID { get; set; }
        public int KullaniciID { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public virtual Kullanici Kullanicilar { get; set; }

    }
}
