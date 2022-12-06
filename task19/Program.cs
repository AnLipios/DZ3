Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if ((num > 9999) && (num < 100000))
{
    int a = num / 100;
    int e = a % 10;
    int n = num / 10000;
    int m = num % 10000;
    int b = num / 1000 - n * 10;
    int r = num / 10 - n*1000 - b*100 - e*10;
    if ((n==m) || (b==r))
    {
        Console.WriteLine("Это палиндром");
    }
    else
{
    Console.WriteLine("Нет");
}
}