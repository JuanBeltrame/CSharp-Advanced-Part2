﻿using Library_Example_19._0._01;

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
Console.WriteLine();

Console.WriteLine("-----Property Pattern-----");
PropertyPattern.GreetPerson(new Person("Bob", 30));
PropertyPattern.PrintPersonInfo(new Person("Bob", 30));
Console.WriteLine();

Console.WriteLine("-----Null Pattern-----");
NullPattern.Caso01();
NullPattern.Caso02();
Console.WriteLine();

Console.WriteLine("-----Var Pattern-----");
VarPattern.PrintObjectDetails(1);
Console.WriteLine(VarPattern.DescribeType(1));
Console.WriteLine();

Console.WriteLine("-----Declaration Pattern-----");
DeclarationPattern.PrintObjectDetails(1);
DeclarationPattern.PrintObjectDetails("Hello World");
DeclarationPattern.PrintObjectDetails(DateTime.Now);
Console.WriteLine(DeclarationPattern.DescribeType(1));
Console.WriteLine(DeclarationPattern.DescribeType("Hello World"));
Console.WriteLine(DeclarationPattern.DescribeType(DateTime.Now));
Console.WriteLine();

Console.WriteLine("-----Tuple Pattern-----");
TuplePattern.PrintTupleDetails((1, 2), "TwoIntegers");
TuplePattern.PrintTupleDetails((1, 2, 3), "ThreeIntegers");
TuplePattern.PrintTupleDetails((1, 2, 3, 4), "FourIntegers", "FourIntegers");
TuplePattern.VerificarPares(4, 5);

Console.WriteLine("-----Discard Pattern-----");
// Llamada al método estático Describe (no requiere instancia de la clase).
string resultado1 = DiscardPattern.Describe("Hello World!");
Console.WriteLine($"Describe con string: {resultado1}");

string resultado2 = DiscardPattern.Describe(42);
Console.WriteLine($"Describe con int: {resultado2}");

string resultado3 = DiscardPattern.Describe(3.14);
Console.WriteLine($"Describe con double: {resultado3}");  // Tipo desconocido

// Para los métodos no estáticos, creamos una instancia de la clase.
DiscardPattern discardExample = new DiscardPattern();

// Llamada a CheckIfInt (método de instancia).
discardExample.CheckIfInt();

// Llamada a DeconstructExample (método de instancia).
discardExample.DeconstructExample();

Console.ReadLine();