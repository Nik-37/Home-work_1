// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a;
int b;
int c;
int max = 0;
string line_a;
string line_b;
string line_c;

Console.WriteLine("Введите число a: ");
line_a = Console.ReadLine();
Console.WriteLine("Введите число b: ");
line_b = Console.ReadLine();
Console.WriteLine("Введите число c: ");
line_c = Console.ReadLine();

a = Convert.ToInt32(line_a);
b = Convert.ToInt32(line_b);
c = Convert.ToInt32(line_c);

if (a>max) max = a;
if (b>max) max = b;
if (c>max) max = c;

Console.WriteLine("max = ");
Console.WriteLine(max);