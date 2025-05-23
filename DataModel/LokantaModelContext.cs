using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class LokantaModelContext :DbContext
    {
        public DbSet<Masa> Masa{ get; set; }
        public DbSet<Yemek> Yemek { get; set; }
        public DbSet<YemekTur> YemekTur { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Siparis> Siparis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ///Burada bağlanılacak veri tabanı belirtilecek
            ///PostgreSql servera bağlanmak için connection string cümlesi
            ///Server = 127.0.0.1; Port = 5432; Database = myDataBase; Integrated Security = true;
            ///optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=myDataBase;Integrated Security=true;");

            ///Microsoft SQL servera bağlanmak için kullanılan bağlantı cümlesi bildirimi
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Lokanta;Trusted_Connection=True;TrustServerCertificate=True");

        }
    }
}
