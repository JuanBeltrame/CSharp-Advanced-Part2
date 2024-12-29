using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Example_19._0._01
{
    public class VarPattern
    {
        public static void PrintObjectDetails(object obj)
        {
            if (obj is var x)
                Console.WriteLine($"Object type: {x.GetType().Name}, Value: {x}");
        }
        public static string DescribeType(object obj)
        {
            return obj switch
            {
                int i => $"Integer: {i}",
                string s => $"String: {s}",
                var x => $"Unknown type: {x.GetType().Name}"
            };
        }
    }
}
