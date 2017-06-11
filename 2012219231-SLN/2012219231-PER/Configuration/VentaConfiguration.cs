using _2012219231_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231_PER.Configuration
{
    public class VentaConfiguration : EntityTypeConfiguration<Venta>
    {
        public VentaConfiguration()
        {
            //Table Configurations

            ToTable("Ventas");
            HasKey(a => a.VentaId);


            //Relation Configurations

            //HasRequired(c => c.Administrativo)
            //    .WithMany(c => c.Ventas)
            //    .HasForeignKey(c => c.AdministrativoId);

            //HasMany(c => c.Servicios)
            //    .WithRequired(c => c.Venta)
            //    .HasForeignKey(c => c.VentaId);
        }
    }
}
