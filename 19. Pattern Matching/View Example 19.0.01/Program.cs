using Library_Example_19._0._01;
using System;

Console.WriteLine("-----CONSTANT PATTERN-----");
ConstantPattern.Caso01();
ConstantPattern.Caso02();
Console.WriteLine();

Console.WriteLine("-----TYPE PATTERN-----");
TypePattern.PrintLenght("Hello Word");
TypePattern.PrintLenght(new List<int>[1, 2, 3]);
TypePattern.PrintType(1);
TypePattern.PrintType("1");
TypePattern.Caso03(new List<object> { 42, "C# Rocks!", DateTime.Now });
Console.WriteLine();

Console.WriteLine("-----PROPERTY PATTERN-----");
PropertyPattern.GreetPerson(new Person("Bob", 30));
PropertyPattern.PrintPersonInfo(new Person("Bob", 30));
Console.WriteLine();

Console.WriteLine("-----NULL PATTERN-----");
NullPattern.Caso01();
NullPattern.Caso02();
Console.WriteLine();

Console.WriteLine("-----VAR PATTERN-----");
VarPattern.PrintObjectDetails(1);
Console.WriteLine(VarPattern.DescribeType(1));
Console.WriteLine();

Console.WriteLine("-----DECLARATION PATTERN-----");
DeclarationPattern.PrintObjectDetails(1);
DeclarationPattern.PrintObjectDetails("Hello World");
DeclarationPattern.PrintObjectDetails(DateTime.Now);
Console.WriteLine(DeclarationPattern.DescribeType(1));
Console.WriteLine(DeclarationPattern.DescribeType("Hello World"));
Console.WriteLine(DeclarationPattern.DescribeType(DateTime.Now));
Console.WriteLine();

Console.WriteLine("-----POSITIONAL PATTERN-----");
Coordinates point1 = new Coordinates(3, 5);
Coordinates point2 = new Coordinates(-1, 1);

if (point1 is (3, 5)) // Se cumple si X = 3 e Y = 5
    Console.WriteLine("Coordenadas (3, 5)");

if (point1 is (var xValue, var yValue))
    // También puedes capturar los valores en variables si deseas procesarlas:
    Console.WriteLine($"x: {xValue}, y: {yValue}");

static string identify_pattern(Coordinates sample) => sample switch
{
    // switchs statement that return corresponding return values
    Coordinates(1, 1) => "Point lies in the first quadrant of cartesian plane.",
    Coordinates(-1, 1) => "Point lies in the second quadrant of cartesian plane.",
    Coordinates(-1, -1) => "Point lies in the third quadrant of cartesian plane.",
    Coordinates(1, -1) => "Point lies in the fourth quadrant of cartesian plane.",
    _ => "Hmm, I am not sure about this point. You will have to plot it and find out!",
};
Console.WriteLine(identify_pattern(point2));
Console.WriteLine();


Console.WriteLine("-----TUPLE PATTERN-----");
TuplePattern.PrintTupleDetails((1, 2), "TwoIntegers");
TuplePattern.PrintTupleDetails((1, 2, 3), "ThreeIntegers");
TuplePattern.PrintTupleDetails((1, 2, 3, 4), "FourIntegers", "FourIntegers");
TuplePattern.VerificarPares(4, 5);
Console.WriteLine();

Console.WriteLine("-----DISCARD PATTERN-----");
string resultado1 = DiscardPattern.Describe("Hello World!");
Console.WriteLine($"Describe con string: {resultado1}");
string resultado2 = DiscardPattern.Describe(42);
Console.WriteLine($"Describe con int: {resultado2}");
string resultado3 = DiscardPattern.Describe(3.14);
Console.WriteLine($"Describe con double: {resultado3}");  // Tipo desconocido
DiscardPattern.CheckIfInt();
DiscardPattern.DeconstructExample();
Console.ReadLine();