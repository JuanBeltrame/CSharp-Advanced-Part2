using _17._1._02_Library;

internal class Program
{
    private static void Main(string[] args)
    {
        Caja.DelegadoClienteAtendido clienteAtendido = (caja, cliente) =>
        {
            string mensaje = $"{DateTime.Now:HH:mm:ss} - Hilo {Task.CurrentId} - {caja.NombreCaja} " +
            $"- Atendiendo a {cliente}. Quedan {caja.CantidadDeClientesALaEspera} clientes en esta caja";
            Console.WriteLine(mensaje);
        };

        List<Caja> cajas = new()
        {
            new Caja ("Caja 01", clienteAtendido),
            new Caja("Caja 02", clienteAtendido)
        };

        Negocio negocio = new(cajas);

        Console.WriteLine("Asignando cajas...");
        List<Task> hilos = negocio.ComenzarAtencion();
        Task.WaitAll(hilos.ToArray());
    }
}