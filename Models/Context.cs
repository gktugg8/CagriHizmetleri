using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CagriHizmetleri.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;  database=DbCagriHizmetleri; integrated security=true");
        }

        public DbSet<Musteriler> Musterilers { get; set; }
        public DbSet<CagriOperatorleri>CagriOperatorleris { get; set; }
    }
}
