using Microsoft.EntityFrameworkCore;

namespace BuscaCnpjMvc.Models
{
    [Owned]
    public class Billing
    {
        public bool IsEmpty { get; set; } = true;
        public bool? Optante { get; set; }
        public bool? Database { get; set; }
    }
}
