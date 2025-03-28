using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BuscaCnpjMvc.Models;

namespace BuscaCnpjMvc.Data
{
    public class BuscaCnpjMvcContext : DbContext
    {
        public BuscaCnpjMvcContext (DbContextOptions<BuscaCnpjMvcContext> options)
            : base(options)
        {
        }

        public DbSet<BuscaCnpjMvc.Models.CnpjResponse> CnpjResponse { get; set; } = default!;
    }
}
