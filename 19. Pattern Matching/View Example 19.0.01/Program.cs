using Library_Example_19._0._01;

Console.WriteLine("-----Constant Pattern-----");
ConstantPattern.Caso01();
ConstantPattern.Caso02();
Console.WriteLine();

Console.WriteLine("-----Type Pattern-----");
TypePattern.PrintLenght("Hello Word");
TypePattern.PrintLenght(new List<int>[1, 2, 3]);
TypePattern.PrintType(1);
TypePattern.PrintType("1");
TypePattern.Caso03(new List<object> { 42, "C# Rocks!", DateTime.Now });

Console.WriteLine("-----Property Pattern-----");
PropertyPattern.GreetPerson(new Person("Bob", 30));
PropertyPattern.PrintPersonInfo(new Person("Bob", 30));


