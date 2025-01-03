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