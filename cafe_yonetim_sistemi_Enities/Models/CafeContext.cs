using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace cafe_yonetim_sistemi_Enities.Models
{
    public class CafeContext : DbContext
    {
        public CafeContext() : base("NameConnection")
        {

        }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<KullaniciHareketleri> KullaniciHareketleri { get; set; }
        public DbSet<Masa> Masalar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Satislar> Satislar { get; set; }
        public DbSet<Roller> Roller { get; set; }
        public DbSet<OdemeHareketleri> OdemeHareketleri { get; set; }
        public DbSet<MasaHareketleri> MasaHareketleri { get; set; }
        public DbSet<Musteriler> Musteriler { get; set; }
        public DbSet<SatisKodu> SatisKodu { get; set; }


        // Configuration edebilmek için burayı override ettik tablodaki alanların özelliklerini belirledik
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MenuMap());
            modelBuilder.Configurations.Add(new UrunMap());
            modelBuilder.Configurations.Add(new KullanicilarMap());
            modelBuilder.Configurations.Add(new KullaniciHareketleriMap());
            modelBuilder.Configurations.Add(new MasalarMap());
            modelBuilder.Configurations.Add(new MasaHareketleriMap());
            modelBuilder.Configurations.Add(new OdemeHareketleriMap());
            modelBuilder.Configurations.Add(new SatislarMap());
            modelBuilder.Configurations.Add(new RollerMap());
            modelBuilder.Configurations.Add(new MusterilerMap());
        }
    }
}
