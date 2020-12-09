using Final_Diars.Models.Maps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Diars.Models.BD
{
    public class NotasContext: DbContext
    {
        public NotasContext(DbContextOptions<NotasContext> options) : base(options) { }

        public DbSet<Notas> notas{ get; set; }
        public DbSet<Etiquetas> etiquetas{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new NotasMap());
            modelBuilder.ApplyConfiguration(new EtiquetasMap());
        }
    }
}
