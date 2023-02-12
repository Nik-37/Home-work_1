// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a; 
int b;
int max;
string line_a;
string line_b;

Console.WriteLine("Введите число a: ");
line_a = Console.ReadLine();
Console.WriteLine("Введите число b: ");
line_b = Console.ReadLine();

a = Convert.ToInt32(line_a);
b = Convert.ToInt32(line_b);

if (a > b)
{
  max = a;
} 
else 
{
max = b;
}
Console.WriteLine("max = ");
Console.WriteLine(max);