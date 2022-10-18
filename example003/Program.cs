//14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.Clear();

Console.Write("Введите первое число: ");
int number = int.Parse(Console.ReadLine()!);

if (number % 23 == 0 && number % 7 == 0)
{
    Console.WriteLine($"{number} одновременно кратно 7 и 23");
}
else
{
    Console.WriteLine($"{number} не кратно 7 и 23");
}

