using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_yonetim_sistemi_Enities.Models
{
    [Table("SatisKodu")]
    public class SatisKodu
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        [Column(TypeName = "nvarchar")]
        public string SatisTanimi { get; set; }
        public int Sayi { get; set; }
    }
}
