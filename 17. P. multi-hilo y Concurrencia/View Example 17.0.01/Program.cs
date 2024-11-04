
internal class Program
{
    private static Random random;

    public static void EjecutarSincronico()
    {
        Queue<Action> tareas = new();
        tareas.Enqueue(() => EjecutarTarea("SINC-A"));
        tareas.Enqueue(() => EjecutarTarea("SINC-B"));
        tareas.Enqueue(() => EjecutarTarea("SINC-C"));
        tareas.Enqueue(() => EjecutarTarea("SINC-D"));
        tareas.Enqueue(() => EjecutarTarea("SINC-E"));
        tareas.Enqueue(() => EjecutarTarea("SINC-F"));
        tareas.Enqueue(() => EjecutarTarea("SINC-G"));
        tareas.Enqueue(() => EjecutarTarea("SINC-H"));
        tareas.Enqueue(() => EjecutarTarea("SINC-I"));
        tareas.Enqueue(() => EjecutarTarea("SINC-J"));
        tareas.Enqueue(() => EjecutarTarea("SINC-K"));
        tareas.Enqueue(() => EjecutarTarea("SINC-L"));
        tareas.Enqueue(() => EjecutarTarea("SINC-M"));
        tareas.Enqueue(() => EjecutarTarea("SINC-N"));

        foreach (Action tarea in tareas)
            tarea();
    }

    public static void EjecutarTarea(string codigo)
    {
        int tiempo = random.Next(1000, 5000);
        Thread.Sleep(tiempo);
        Console.WriteLine($"{DateTime.Now:T} - Tarea {codigo} completada en {tiempo} ms.");
    }

    private static void Main(string[] args)
    {
        random = new Random();

        EjecutarSincronico();

        Console.WriteLine("Finalizaron todas las tareas!");

    }
}
