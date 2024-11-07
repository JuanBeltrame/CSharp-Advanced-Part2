namespace _17._1._02_Library
{
    public class Caja
    {
        public delegate void DelegadoClienteAtendido(Caja caja, string cliente);
        private DelegadoClienteAtendido delegadoClienteAtendido;
        private static Random random;
        private Queue<string>? clientesALaEspera;
        private string? nombreCaja;

        static Caja() => random = new();

        public Caja(string? nombreCaja, DelegadoClienteAtendido delegadoClienteAtendido)
        {
            clientesALaEspera = new();
            this.nombreCaja = nombreCaja;
            this.delegadoClienteAtendido = delegadoClienteAtendido;
        }

        public string NombreCaja => nombreCaja!;

        public int CantidadDeClientesALaEspera => clientesALaEspera!.Count;

        internal void AgregarCliente(string cliente) => clientesALaEspera!.Enqueue(cliente);
        
        internal Task IniciarAtencion() => Task.Run(AtenderClientes);
       
        private void AtenderClientes()
        {
            do
            {
                if (clientesALaEspera!.Any())
                {
                    string cliente = clientesALaEspera!.Dequeue();
                    delegadoClienteAtendido?.Invoke(this, cliente);
                    Thread.Sleep(random.Next(1000, 5000));
                }
            } while (true);
        }
    }
}
