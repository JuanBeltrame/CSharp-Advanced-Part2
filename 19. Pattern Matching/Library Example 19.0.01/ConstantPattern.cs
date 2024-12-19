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
    }
}
