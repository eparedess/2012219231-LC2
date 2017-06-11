using _2012219231_ENT.Entities;
using _2012219231_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231_PER.Repositories
{
    public class LugarViajeRepository : Repository<LugarViaje>, ILugarViajeRepository
    {

        public LugarViajeRepository(TransporteDbContext context) : base(context)
        {
        }

    }
}
