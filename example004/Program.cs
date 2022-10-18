//16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.Clear();

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

if (a * a == b||b * b == a)
{
    Console.Write($"да является");
}
else
{
    Console.WriteLine($"нет не является");
}
