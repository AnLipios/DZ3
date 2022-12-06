Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int i = 1;
 while (i <= n )
 {
    Console.WriteLine($"{Math.Pow(i, 3)}");
    i++;
 }