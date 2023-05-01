using LogiSmart.Api.Models.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiSmart.Api.Context
{
    public class MagazziniContext : DbContext
    {
        public MagazziniContext(DbContextOptions<MagazziniContext> options) 
            : base(options) 
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=localhost;Database=logismart;Trusted_Connection=True;TrustServerCertificate=true;");
        }


        public DbSet<Magazzino> Magazzini { get; set; }

        public DbSet<AreaMagazzino> AreeMagazzino { get; set; }

        public DbSet<Attrezzatura> Attrezzature { get; set; }

        public DbSet<Azienda> Aziende { get; set; }

        public DbSet<Operatore> Operatori { get; set; }

        public DbSet<Mansione> Mansioni { get; set; }
    }
}
