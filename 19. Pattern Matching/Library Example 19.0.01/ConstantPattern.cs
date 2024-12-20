using System.Timers;

namespace Library_Example_19._0._01
{
    public class ConstantPattern
    {
        public static void Caso1()
        {
            object valor = 10;
            if (valor is 10) // Constant Pattern
                Console.WriteLine("valor es exactamente 10.");
        }

        public static void Caso02()
        {
            object dato = "Hola";
            string mensaje = dato switch
            {
                null => "El valor es nulo",
                42 => "El valor es 42",
                "Hola" => "El valos es la cadena 'Hola'",
                _ => "Otro valor"
            };

            Console.WriteLine(mensaje);
        }


    }
}
