using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Diars.Models.Maps
{
    public class NotaEtiquetaMap : IEntityTypeConfiguration<NotaEtiqueta>
    {
        public void Configure(EntityTypeBuilder<NotaEtiqueta> builder)
        {
            builder.ToTable("NotaEtiqueta");
            builder.HasKey(o => o.idNotaEtiqueta);
        }
    }
}
