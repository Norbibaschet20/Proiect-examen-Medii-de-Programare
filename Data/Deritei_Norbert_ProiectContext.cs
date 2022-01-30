using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Deritei_Norbert_Proiect.Models;

namespace Deritei_Norbert_Proiect.Data
{
    public class Deritei_Norbert_ProiectContext : DbContext
    {
        public Deritei_Norbert_ProiectContext (DbContextOptions<Deritei_Norbert_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Deritei_Norbert_Proiect.Models.Product> Product { get; set; }

        public DbSet<Deritei_Norbert_Proiect.Models.Storage> Storage { get; set; }

        public DbSet<Deritei_Norbert_Proiect.Models.Category> Category { get; set; }
    }
}
