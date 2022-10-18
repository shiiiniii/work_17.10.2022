// 	3. Задать номер четверти, показать диапазоны для возможных координат

Console.Clear();
Console.Write("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine()!);
if( number == 1)
{
    Console.WriteLine("Диапозоны возможных координат: x > 0 и y > 0");
}
if(number == 2)
{
    Console.WriteLine("Диапозоны возможных координат: x < 0, а y > 0");
}
if(number == 3)
{
    Console.WriteLine("Диапозоны возможных координат: x < 0 и y < 0");
}
if(number == 4)
{
    Console.WriteLine("Диапозоны возможных координат: x > 0, а y < 0");
}