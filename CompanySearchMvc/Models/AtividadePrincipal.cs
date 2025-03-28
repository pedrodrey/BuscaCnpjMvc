using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace BuscaCnpjMvc.Models
{
    [Owned]
    public class AtividadePrincipal
    {
        public string? Code { get; set; }
        public string? Text { get; set; }
    }
}
