using _2012219231_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231_PER.Configuration
{
    public class ServicioConfiguration : EntityTypeConfiguration<Servicio>
    {
        public ServicioConfiguration()
        {
            //Table Configurations

            ToTable("Servicios");
            HasKey(a => a.ServicioId);


            //Map<Transport>(m => m.Requires("Discriminator").HasValue("Transportes"));
            //Map<Encomienda>(m => m.Requires("Discriminator").HasValue("Encomiendas"));
        }
    }
}
