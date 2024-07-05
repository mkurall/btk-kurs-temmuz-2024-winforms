using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using d08_ef_personel_bilgileri.modeller;
using Microsoft.EntityFrameworkCore;//DbContext core tanısın

namespace d08_ef_personel_bilgileri.veri
{
    public class FabrikaDbContext : DbContext
    {
        public DbSet<PersonelBilgi> PersonelBilgileri { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=fabrika_db;Trusted_Connection=True");
        }
    }
}
