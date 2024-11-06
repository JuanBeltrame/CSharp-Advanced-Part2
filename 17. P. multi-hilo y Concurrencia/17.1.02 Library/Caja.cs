namespace _17._1._02_Library
{
    public class Caja
    {
        public delegate void DelegadoClienteAtendido(Caja caja, string cliente);
        private static Random random;
        private Queue<string>? clientesALaEspera;
        private string? nombreCaja;

        static Caja() => random = new();

        public Caja(string? nombreCaja, DelegadoClienteAtendido delegadoClienteAtendido)
        {
            clientesALaEspera = new();
            this.nombreCaja = nombreCaja;
        }

        public string NombreCaja => nombreCaja!;

        public int CantidadDeClientesALaEspera => clientesALaEspera!.Count;
    }
}
