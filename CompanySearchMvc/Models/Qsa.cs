using Microsoft.EntityFrameworkCore;

namespace BuscaCnpjMvc.Models
{
    [Owned]
    public class Qsa
    {
        public string? Nome { get; set; }
        public string? Qual { get; set; }
        public string? PaisOrigem { get; set; }
        public string? NomeRepLegal { get; set; }
        public string? QualRepLegal { get; set; }
    }
}
