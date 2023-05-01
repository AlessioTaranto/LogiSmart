using LogiSmart.Api.Models.Dto;
using System.Diagnostics.CodeAnalysis;

namespace LogiSmart.Api.Models.Generics
{
    // TODO remove required and use constuctor
    public class Magazzino
    {
        public long Id { get; set; }

        public required string Nome { get; set; }

        public required string Indirizzo { get; set; }

        public required string NumeroTelefono { get; set; }

        public required string Mail { get; set; }

        public List<Mansione>? Mansioni { get; set; }

        public List<Azienda>? Azienda { get; set; }

        public List<AreaMagazzino>? AreaMagazzino { get; set; }

        public List<Operatore>? Operatori { get; set; }
    }
}