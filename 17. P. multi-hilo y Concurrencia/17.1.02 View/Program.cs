using _17._1._02_Library;

internal class Program
{
    private static void Main(string[] args)
    {
        Caja.DelegadoClienteAtendido clienteAtendido = (caja, cliente) =>
        {
            Console.WriteLine($"El cliente {cliente} ha sido atendido en la caja {caja.NombreCaja}");
        };
    }
}