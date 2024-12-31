using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Example_19._0._01
{
    public class NullPattern
    {
        public static void Caso01()
        {
            object valor = null!;
            if (valor is null) // Null Pattern
                Console.WriteLine("valor es nulo.");
        }
        public static void Caso02()
        {
            object dato = null!;
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
