using Microsoft.EntityFrameworkCore;

namespace BuscaCnpjMvc.Models
{
    [Owned]
    public class Billing
    {
        public bool? Optante { get; set; }
        public bool? Database { get; set; }
    }
}
