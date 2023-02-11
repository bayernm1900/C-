Console.Write("Введите первое число ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите третье число ");
int z = int.Parse(Console.ReadLine());
int max = x;
if (x > y) max = x;
if (x > z) max = x;
if (y > x) max = y;
if (y > z) max = y;
if (z > x) max = z;
if (z > y) max = z;
{
    System.Console.WriteLine(max);
}