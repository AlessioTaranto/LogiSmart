using System.ComponentModel.DataAnnotations;
using static LogiSmart.Api.Models.Generics.Operatore;

namespace LogiSmart.Api.Models.Dto
{
    public class OperatoreDto
    {

        [Required]
        public required string Nome { get; set; }

        [Required]
        public DateTime DataDiNascita { get; set; }

    }
}
