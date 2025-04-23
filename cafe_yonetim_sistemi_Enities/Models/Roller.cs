using cafe_yonetim_sistemi_Enities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_yonetim_sistemi_Enities.Models
{
    public class Roller : IEntity
    {
        public int ID { get; set; }
        public int KullaniciID { get; set; }
        public string FormName { get; set; }
        public string KontrolName { get; set; }
        public string ControlCaption { get; set; }
    }
}
