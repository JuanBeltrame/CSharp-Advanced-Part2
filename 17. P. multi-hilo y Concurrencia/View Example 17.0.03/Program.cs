internal class Program
{
    static void Tarea()
    {
        Console.WriteLine("La tarea ha comenzado");
        Thread.Sleep(10000);
        Console.WriteLine("La tarea ha finalizado");
    }

    static void Reloj(DateTime dateTime)
    {
        while (true)
        {
            Console.WriteLine($"Tiempo transcurrido{dateTime}");
            Thread.Sleep(1000);
        }
    }

    private static void Main(string[] args)
    {
        // METODO 1
        //Task tareaHiloSecundario = new Task(Tarea);
        //tareaHiloSecundario.Start();
        //tareaHiloSecundario.Wait();

        // METODO 2
        //Action action = () => { Reloj(DateTime.Now); };
        //Task tareaHiloSecundario = new(action);

        // METODO 3
        Task tareaHiloSecundario = new(() => { Reloj(DateTime.Now); });
        tareaHiloSecundario.Start();
        
        ConsoleKey teclaPresionada;

        do
        {
            teclaPresionada = Console.ReadKey().Key;
            Console.WriteLine($"Presiono {teclaPresionada}");
        }
        while (teclaPresionada != ConsoleKey.Spacebar);
        Console.WriteLine("El main principal finalizo");
    }
}