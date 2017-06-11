using _2012219231_ENT.Entities;
using _2012219231_PER.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231_PER.Configuration
{
    public class EncomiendaRepository : Repository<Encomienda>, IEncomiendaRepository
    {

        public EncomiendaRepository(DbContext context) : base(context)
        {
        }
    }
}
