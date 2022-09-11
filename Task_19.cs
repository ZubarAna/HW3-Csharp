Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

while(n < 10000 && n > 1000000)
{
    Console.Write("Попробуй еще раз");
    n = Convert.ToInt32(Console.ReadLine());
}

if(n / 10000 == n % 10 && n / 1000 % 10 == n % 100 / 10)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");