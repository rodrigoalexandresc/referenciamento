using Microsoft.EntityFrameworkCore;
using referenciamento.api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace referenciamento.api.ORM
{
    public class ReferenciamentoDbContext : DbContext
    {
        public ReferenciamentoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Prontuario> Prontuarios { get; set; }

    }
}
