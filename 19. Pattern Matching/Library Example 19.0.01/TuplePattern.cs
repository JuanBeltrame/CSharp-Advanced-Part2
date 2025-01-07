using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library_Example_19._0._01
{
    public class Persona
    {
        public int Edad { get; set; }
        public string? Ciudad { get; set; }
    }

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

        public static void VerificarPares(int a, int b)
        {
            if ((a, b) is (1, 2))
                Console.WriteLine("a es 1 y b es 2");
            else
                Console.WriteLine("Combinación diferente");
        }

        public string EvaluarEstado1(int edad, bool esEstudiante)
        {
            if ((edad, esEstudiante) is ( >= 18, true))
            {
                return "Adulto y Estudiante";
            }
            else if ((edad, esEstudiante) is ( >= 18, false))
            {
                return "Adulto sin Estudio";
            }
            else if ((edad, esEstudiante) is ( < 18, _))
            {
                return "Menor de Edad";
            }
            else
            {
                return "Estado desconocido";
            }
        }

        public string EvaluarEstado2(int edad, bool esEstudiante) => (edad, esEstudiante) switch
        {
            ( < 18, _) => "Menor de edad",
            ( >= 18, true) => "Adulto Estudiante",
            ( >= 18, false) => "Adulto"
        };

        public void ClasificarPuntuaciones(int math, int science)
        {
            switch ((math, science))
            {
                case ( >= 90, >= 90):
                    Console.WriteLine("Excelente en ambas materias");
                    break;
                case ( >= 90, _):
                    Console.WriteLine("Excelente en Matemáticas");
                    break;
                case (_, >= 90):
                    Console.WriteLine("Excelente en Ciencias");
                    break;
                default:
                    Console.WriteLine("Buen desempeño general");
                    break;
            }
        }

        
        public void EvaluarPersona(Persona persona)
        {
            if ((persona.Edad, persona.Ciudad) is ( >= 18, "Madrid"))
            {
                Console.WriteLine("Adulto viviendo en Madrid");
            }
            else
            {
                Console.WriteLine("Otro caso");
            }
        }


    }
}



