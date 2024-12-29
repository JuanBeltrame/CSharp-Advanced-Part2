using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Example_19._0._01
{
    public class DeclarationPattern
    {
        public static void PrintObjectDetails(object obj)
        {
            if (obj is int i)
                Console.WriteLine($"Object type: {i.GetType().Name}, Value: {i}");
            else if (obj is string s)
                Console.WriteLine($"Object type: {s.GetType().Name}, Value: {s}");
            else
                Console.WriteLine($"Unknown type: {obj.GetType().Name}");
        }
    }
}
