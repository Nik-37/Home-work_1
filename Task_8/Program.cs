/// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int N;
int i = 1;
string line_N;

Console.WriteLine("Введите число N: ");
line_N = Console.ReadLine();
N = Convert.ToInt32(line_N);

while(i <= N)
{
  if(i % 2 == 0)
  {
    Console.WriteLine(i);
  }

  i = i + 1;
}