// See https://aka.ms/new-console-template for more information
double d, p;
Console.WriteLine("Enter the diameter: ");
d = double.Parse(Console.ReadLine());
p = 3.1416 * d;
Console.WriteLine("The perimeter of the circle is:" + p);
Console.ReadLine();
Console.ReadKey();
