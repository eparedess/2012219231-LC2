using _2012219231_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231_PER.Configuration
{
    public class BusConfiguration : EntityTypeConfiguration<Bus>
    {
        public BusConfiguration()
        {
            //Table Configurations

            ToTable("Buses");
            HasKey(a => a.BusId);


            //Relation Configurations

            //HasMany(c => c.Tripulacions)
            //    .WithRequired(c => c.Bus)
            //    .HasForeignKey(c => c.BusId);

            //HasRequired(c => c.Transporte)
            //    .WithMany(c => c.Buses)
            //    .HasForeignKey(c => c.TransporteId);

            //HasMany(c => c.Encomiendas)
            //    .WithRequired(c => c.Bus)
            //    .HasForeignKey(c => c.BusId);
        }
    }
}

