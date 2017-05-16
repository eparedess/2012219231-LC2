using _2012219231_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231_PER
{
    public class a12206149DbContext : DbContext
    {
        public DbSet<Administrativo> Administrativo { get; set; }
    }
}

