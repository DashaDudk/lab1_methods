using MainProgram.Methods;
using MainProgram;
using System.Xml.Linq;

Console.WriteLine("Solution to the equation: x^3-7x-6 = 0 " +
    "            Initial approximation: x0 = 3.4");
double x0 = 3.4;

Console.Write("Enter the value of epsilon: ");
string input = Console.ReadLine();

Console.WriteLine("  NEWTHON METHOD\n");

if (double.TryParse(input, out double epsilon))
{
    var counter = new Newton_s(x0, epsilon);
    Helper.CountValue(counter);

    x0 = -1.5;

    Console.WriteLine("  SIMPLE ITERATION METHOD\n");
    var counter1 = new SimpleIteration(x0, epsilon);

    Helper.CountValue(counter1);
}

else {
    Console.WriteLine("Incorrect value of epsilon.");
}