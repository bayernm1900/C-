Console.Write("Введите трехзначиное число ");
 int numbers = int.Parse(Console.ReadLine());
 Console.WriteLine(numbers);

 int a = numbers / 100;
 int b = numbers % 10;
 int c = numbers / 10 % 10;
 Console.WriteLine(c);