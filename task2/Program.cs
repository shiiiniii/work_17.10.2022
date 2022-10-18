// По двум заданным числам проверять является ли одно квадратом другого

Console.Clear();
Console.WriteLine("Программа, которая проверяет, является ли одно заданное Вами число квадратом другого, заданного Вами часла");
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
int sqr = number2 * number2;
if (sqr == number1)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}
