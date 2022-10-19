// Найти расстояние между точками в пространстве 2D/3D
Console.Clear();
Console.Write("Вы хотите найти расстояние между точками в пространстве 2D или 3D? Напишите пространство: ");
string space = Console.ReadLine();
if(space.ToLower() == "2d")
{
    Console.Write("Введите Xa: ");
    double Xa = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите Xb: ");
    double Xb = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите Ya: ");
    double Ya = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите Yb: ");
    double Yb = Convert.ToDouble(Console.ReadLine());
    double result = Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2));
    Console.WriteLine($"Расстояние между точками = {result}");
}
else
{
   Console.Write("Введите Xa: ");
   double Xa = Convert.ToDouble(Console.ReadLine());
   Console.Write("Введите Xb: ");
   double Xb = Convert.ToDouble(Console.ReadLine());
   Console.Write("Введите Ya: ");
   double Ya = Convert.ToDouble(Console.ReadLine());
   Console.Write("Введите Yb: ");
   double Yb = Convert.ToDouble(Console.ReadLine());
   Console.Write("Введите Za: ");
   double Za = Convert.ToDouble(Console.ReadLine());
   Console.Write("Введите Zb: ");
   double Zb = Convert.ToDouble(Console.ReadLine());
   double result = Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2) + Math.Pow((Zb - Za), 2));
   Console.WriteLine($"Расстояние между точками = {result}");
}

