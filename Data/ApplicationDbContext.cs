using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Simulacro_PC3.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Simulacro_PC3.Models.Solicitud> DataContactos { get; set; }

        public DbSet<Simulacro_PC3.Models.Categoria> DataCategorias { get; set; }

    }
}