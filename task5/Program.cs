Console.Write("Введите число от 1 до 7: ");
int N = int.Parse(Console.ReadLine());
if ((N >= 1) && (N <=7))
{
    if (N == 6 || N == 7)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}