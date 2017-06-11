using _2012219231_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
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


        }
    }
}

