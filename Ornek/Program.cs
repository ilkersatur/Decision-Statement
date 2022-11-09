Console.WriteLine("ax^2 + b + c");
Console.Write("a = ");
double a = double.Parse(Console.ReadLine());
Console.Write("b = ");
double b = double.Parse(Console.ReadLine());
Console.Write("c = ");
double c = double.Parse(Console.ReadLine());

double delta = (b * b) - (4 * a * c);

if (delta > 0)
{
    Console.WriteLine(" iki kök vardır ");
    double x1 = ((-b) - delta) / (2 * a);
    double x2 = ((-b) + delta) / (2 * a);
    Console.WriteLine($"x1= {x1} ve x2= {x2}");
}
else if (delta == 0)
{
    Console.WriteLine(" tek kök vardır ");
    double x1 = ((-b) - delta) / (2 * a);
    Console.WriteLine($"x= {x1}");
}
else
{
    Console.WriteLine(" reel sayı yok ");
}