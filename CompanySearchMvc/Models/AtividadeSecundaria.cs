using Microsoft.EntityFrameworkCore;

namespace BuscaCnpjMvc.Models
{
    [Owned]
    public class AtividadeSecundaria
    {
        public string? Code { get; set; }
        public string? Text { get; set; }
    }
}
