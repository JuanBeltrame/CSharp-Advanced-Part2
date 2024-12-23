using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Example_19._0._01
{
    public record Person(string Name, int Age);
    public class PropertyPattern
    {
        public static void GreetPerson(Person person)
        {
            switch (person)
            {
                case { Name: "Alice", Age: 25 }:
                    Console.WriteLine("Hello,  Alice!");
                    break;
                case { Name: "Bob", Age: 30 }:
                    Console.WriteLine("Hello,  Bob!");
                    break;
                default:
                    Console.WriteLine("Hello, stranger!");
                    break;
            }
        }

        public static void PrintPersonInfo(Person obj)
        {
            if (obj is Person { Name: string name, Age: >= 18 and <= 65 })
                Console.WriteLine($"Name: {name}, Age: {obj.Age}");
        }
    }
}
