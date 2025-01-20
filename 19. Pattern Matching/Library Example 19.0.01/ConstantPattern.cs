using System.Timers;

namespace Library_Example_19._0._01
{
    public class ConstantPattern
    {
        public enum TrafficLight
        {
            Red,
            Yellow,
            Green
        }

        public static void GetTrafficLightAction(TrafficLight currentLight)
        {
            if (currentLight is TrafficLight.Red)
                Console.WriteLine("Stop! The light is red.");
            else if (currentLight is TrafficLight.Yellow)
                Console.WriteLine("Caution! The light is yellow.");
            else if (currentLight is TrafficLight.Green)
                Console.WriteLine("Go! The light is green.");
            else
                Console.WriteLine("Unknown light.");
        }

        public static TrafficLight GetTrafficLigt(TrafficLight currentLight) => currentLight switch
        {
            TrafficLight.Red => TrafficLight.Yellow,
            TrafficLight.Yellow => TrafficLight.Green,
            TrafficLight.Green => TrafficLight.Red,
            _ => throw new ArgumentException("Invalid traffic light.")
        };

        public static void Caso01()
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
