using ESXSol.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESXSol.Data
{
    public class ESXDataContext : DbContext
    {

        public ESXDataContext(DbContextOptions<ESXDataContext> options)
            : base(options)
        {

        }

        public DbSet<Patrimonio> Patrimonio { get; set; }
        public DbSet<Marca> Marca { get; set; }
    }
}
