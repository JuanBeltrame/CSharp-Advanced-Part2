using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library_Example_19._0._01
{
    public class TuplePattern
    {
        public static void PrintTupleDetails(object obj, params string[] messages)
        {
            // Ensure the correct number of messages for the specific tuple type
            switch (obj)
            {
                case ValueTuple<int, int> tuple when messages.Length == 1 && messages[0] == "TwoIntegers":
                    Console.WriteLine($"Tuple with two integers: {tuple.Item1}, {tuple.Item2}");
                    break;
                case ValueTuple<int, int, int> tuple when messages.Length == 1 && messages[0] == "ThreeIntegers":
                    Console.WriteLine($"Tuple with three integers: {tuple.Item1}, {tuple.Item2}, {tuple.Item3}");
                    break;
                case ValueTuple<int, int, int, int> tuple when messages.Length == 1 && messages[0] == "FourIntegers":
                    Console.WriteLine($"Tuple with four integers: {tuple.Item1}, {tuple.Item2}, {tuple.Item3}, {tuple.Item4}");
                    break;
                case ValueTuple<int, int, int, int, int> tuple when messages.Length == 1 && messages[0] == "FiveIntegers":
                    Console.WriteLine($"Tuple with five integers: {tuple.Item1}, {tuple.Item2}, {tuple.Item3}, {tuple.Item4}, {tuple.Item5}");
                    break;
                case ValueTuple<int, int> tuple when messages.Length == 2 && messages[0] == "TwoIntegers" && messages[1] == "TwoIntegers":
                    Console.WriteLine($"Tuple with two integers: {tuple.Item1}, {tuple.Item2}");
                    break;
                case ValueTuple<int, int, int> tuple when messages.Length == 2 && messages[0] == "ThreeIntegers" && messages[1] == "ThreeIntegers":
                    Console.WriteLine($"Tuple with three integers: {tuple.Item1}, {tuple.Item2}, {tuple.Item3}");
                    break;
                case ValueTuple<int, int, int, int> tuple when messages.Length == 2 && messages[0] == "FourIntegers" && messages[1] == "FourIntegers":
                    Console.WriteLine($"Tuple with four integers: {tuple.Item1}, {tuple.Item2}, {tuple.Item3}, {tuple.Item4}");
                    break;
                case ValueTuple<int, int, int, int, int> tuple when messages.Length == 2 && messages[0] == "FiveIntegers" && messages[1] == "FiveIntegers":
                    Console.WriteLine($"Tuple with five integers: {tuple.Item1}, {tuple.Item2}, {tuple.Item3}, {tuple.Item4}, {tuple.Item5}");
                    break;
                // Add more cases as needed for further lengths of messages
                default:
                    Console.WriteLine("Unknown tuple type or invalid message count");
                    break;
            }
        }
    }
}



