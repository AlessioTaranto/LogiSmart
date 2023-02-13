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
        public MagazzinoContext(DbContextOptions<MagazzinoContext> options) : base(options) { }

        public DbSet<Azienda> Aziende { get; set; }

        public DbSet<Operatore> Operatori { get; set; }

        public DbSet<Magazzino> Magazzini { get; set; }

        public DbSet<AreaMagazzino> AreeMagazzino { get; set; }

        public DbSet<AttrezzaturaDiLavoro> AttrezzatureDiLavoro { get; set; }

        public DbSet<Mansione> Mansioni { get; set; }

        public DbSet<SlotAreaMagazzino> SlotsAreaMagazzino { get; set; }

        public DbSet<Attivita> Attivita { get; set; }

        public DbSet<OperatoreMansione> OperatoreMansioni { get; set; }

        public MagazzinoContext()
        {

        }
    }
}
