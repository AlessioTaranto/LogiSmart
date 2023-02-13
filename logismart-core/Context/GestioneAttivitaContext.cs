using logismart_core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logismart_core.Context
{
    public class GestioneAttivitaContext : DbContext
    {
        public DbSet<Azienda> Aziende { get; set; }

        public DbSet<Operatore> Operatori { get; set; }

        public DbSet<Magazzino> Magazzini { get; set; }

        public DbSet<AreaMagazzino> AreeMagazzino { get; set; }

        public DbSet<AttrezzaturaDiLavoro> AttrezzatureDiLavoro { get; set; }

        public DbSet<Mansione> Mansioni { get; set; }

        public DbSet<SlotAreaMagazzino>  SlotsAreaMagazzino { get; set; }

        public DbSet<Attivita> Attivita { get; set; }

        public DbSet<OperatoreMansione> OperatoreMansioni { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=logismart;Username=postgres;Password=6333");
    }
}
