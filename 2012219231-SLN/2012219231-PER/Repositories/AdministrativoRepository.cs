﻿using _2012219231_ENT.Entities;
using _2012219231_ENT.IRepositories;
using _2012219231_PER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;



namespace _2012219231_PER.Repositories
{
    public class AdministrativoRepository : Repository<Administrativo>, IAdministrativoRepository
    {

        public AdministrativoRepository(TransporteDbContext context) : base(context)
        {
        }

    }
}

