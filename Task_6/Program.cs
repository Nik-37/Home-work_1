// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int a;
string line_a;

Console.WriteLine("Введите число а");
line_a = Console.ReadLine();
a = Convert.ToInt32(line_a);

if (a % 2 == 0)
{
Console.WriteLine("четное число");
}
else
{
Console.WriteLine("нечетное число");
}