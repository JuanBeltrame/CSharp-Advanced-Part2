using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library_Example_19._0._01
{
    public class TypePattern
    {
        public static void PrintLenght(object obj)
        {
            if (obj is string str)
                Console.WriteLine($"The string has {str.Length} characters. ");
            else if (obj is ICollection collection)
                Console.WriteLine($"The collection has {collection.Count} items. ");
        }

        public static void PrintType(object obj)
        {
            if (obj is string or int)
                Console.WriteLine($"Type: {obj.GetType().Name}, Value: {obj}");
        }

        public static void Caso03(List<object> lista)
        {
            foreach (var item in lista)
            {
                if (item is int numero)
                    Console.WriteLine($"Encontré un entero: {numero}");
                else if (item is string cadena)
                    Console.WriteLine($"Encontré una cadena con longitud {cadena.Length}");
                else
                    Console.WriteLine($"Tipo desconocido: {item.GetType().Name}");
            }
        }

        
    }
}
