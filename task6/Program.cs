Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
if (N < 100)
{
    Console.WriteLine("Третья цифра отсутствует");
}
else
{
while ( N >= 1000)
{
    N = N /10;
}
int thirdNumner = N % 10;
Console.WriteLine($"Третья цифра: { thirdNumner }");

}