using Microsoft.EntityFrameworkCore;

namespace BuscaCnpjMvc.Models
{
    [Owned]
    public class Simples
    {
        public bool? Optante { get; set; }
        public DateTime? DataOpcao { get; set; }
        public DateTime? DataExclusao { get; set; }
        public DateTime? UltimaAtualizacao { get; set; }
    }
}
