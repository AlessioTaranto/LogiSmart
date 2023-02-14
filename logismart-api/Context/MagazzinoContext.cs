using logismart_api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logismart_api.Context
{
    public class MagazzinoContext : DbContext
    {
        public MagazzinoContext(DbContextOptions<MagazzinoContext> options) 
            : base(options) 
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=localhost;Database=logismart;Trusted_Connection=True;TrustServerCertificate=true;");
        }

        public DbSet<Azienda> Aziende { get; set; }

        public DbSet<Operatore> Operatori { get; set; }

        //public DbSet<AreaMagazzino> AreeMagazzino { get; set; }

        //public DbSet<AttrezzaturaDiLavoro> AttrezzatureDiLavoro { get; set; }

        //public DbSet<Mansione> Mansioni { get; set; }
    }
}
