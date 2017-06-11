using _2012219231_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012219231_PER.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly TransporteDbContext _Context;

        public IAdministrativoRepository Administrativos { get; private set; }
        public IBusRepository Buses { get; private set; }
        public IClienteRepository Clientes { get; private set; }
        public IEncomiendaRepository Encomiendas { get; private set; }
        public ILugarViajeRepository LugarViajes { get; private set; }
        public ITransporteRepository Transportes { get; private set; }
        public ITripulacionRepository Tripulaciones { get; private set; }
        public IVentaRepository Ventas { get; private set; }



        public UnityOfWork()
        {

        }

        public UnityOfWork(TransporteDbContext context)
        {
            _Context = new TransporteDbContext();

            Administrativos = new AdministrativoRepository(_Context);
            Buses = new BusRepository(_Context);
            Clientes = new ClienteRepository(_Context);
            Encomiendas = new EncomiendaRepository(_Context);
            LugarViajes = new LugarViajeRepository(_Context);
            Transportes = new TransporteRepository(_Context);
            Tripulaciones = new TripulacionRepository(_Context);
            Ventas = new VentaRepository(_Context);

        }


        public void Dispose()
        {
            _Context.Dispose();
        }

        public void StateModified(object Entity)
        {
            _Context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
        }

        public int SaveChanges()
        {
            return _Context.SaveChanges();

        }
    }
}
