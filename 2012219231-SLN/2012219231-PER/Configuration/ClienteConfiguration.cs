using _2012219231_ENT.Entities;
using _2012219231_PER.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231_PER.Configuration
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            //Table Configurations

            ToTable("Clientes");
            HasKey(a => a.ClienteId);


            //Relation Configurations

            //HasMany(c => c.Ventas)
            //    .WithRequired(c => c.Cliente)
            //    .HasForeignKey(c => c.ClienteId);

            //HasRequired(c => c.Transporte)
            //    .WithMany(c => c.Clientes)
            //    .HasForeignKey(c => c.TransporteId);
        }
    }
}
