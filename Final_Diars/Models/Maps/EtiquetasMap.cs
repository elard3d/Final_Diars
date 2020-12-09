using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Diars.Models.Maps
{
    public class EtiquetasMap : IEntityTypeConfiguration<Etiquetas>
    {
        public void Configure(EntityTypeBuilder<Etiquetas> builder)
        {
            builder.ToTable("Etiquetas");
            builder.HasKey(o => o.idEtiqueta );
        }
    }
}
