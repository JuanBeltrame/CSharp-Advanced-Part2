using NameGenerator.Generators;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._1._02_Library
{
    public class Negocio
    {
        private static RealNameGenerator? realNameGenerator;
        private ConcurrentQueue<string> clientes;
        private List<Caja> cajas;

        static Negocio() => realNameGenerator = new();

        public Negocio (List<Caja> cajas)
        {
            this.cajas = cajas;
            clientes = new();
        }

        public void ComenzarAtencion()
        {
            foreach(Caja caja in cajas)
                caja.IniciarAtencion();

            Task taskSimulacionClientes = Task.Run(GenerarClientes);
            Task taskAsignacionCajas = Task.Run(AsignarCajas);
        }

        private void GenerarClientes()
        {
            do
            {
                string cliente = realNameGenerator!.Generate();
                clientes.Enqueue(cliente);
            }
            while (true);
        }

        private void AsignarCajas()
        {
            cajas.OrderBy(c => c.CantidadDeClientesALaEspera);
            Caja caja = cajas.FirstOrDefault();
        }
    }
}
