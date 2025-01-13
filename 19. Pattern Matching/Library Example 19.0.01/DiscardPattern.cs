using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Example_19._0._01
{
    public class DiscardPattern
    {
        // Campo de ejemplo
        static object valor = 100;

        /// <summary>
        /// Ejemplo de discard pattern en un switch expression.
        /// </summary>
        public static string Describe(object obj)
        {
            return obj switch
            {
                string s => $"Cadena: {s}",
                int i => $"Entero: {i}",
                // El discard pattern coincide con cualquier tipo o valor, 
                // y no se guarda el valor en ninguna variable
                _ => "Tipo desconocido"
            };
        }

        /// <summary>
        /// Ejemplo de discard pattern en un 'if' usando 'is'.
        /// </summary>
        public static void CheckIfInt()
        {
            if (valor is int _)
            {
                // Sabemos que 'valor' es un entero, 
                // pero no necesitamos capturar su valor en una variable.
                System.Console.WriteLine("El valor es un número entero.");
            }
            else
            {
                System.Console.WriteLine("El valor no es un número entero.");
            }
        }

        /// <summary>
        /// Ejemplo de discard pattern en la deconstrucción de una tupla.
        /// Usamos '_' para descartar el segundo valor.
        /// </summary>
        public static void DeconstructExample()
        {
            // Supongamos que tenemos un método local que devuelve una tupla (nombre, apellido, edad).
            (string nombre, string apellido, int edad) = ObtenerPersona();

            // Aquí descartamos 'apellido' porque no lo necesitamos.
            //            ↓ (nombre, _, edad)
            (string name, _, int personAge) = (nombre, apellido, edad);

            System.Console.WriteLine($"Nombre: {name}, Edad: {personAge}");
        }

        /// <summary>
        /// Método auxiliar que devuelve una tupla (nombre, apellido, edad).
        /// </summary>
        private static (string, string, int) ObtenerPersona()
        {
            // Ejemplo de datos simulados
            return ("Juan", "Pérez", 30);
        }
    }

}
