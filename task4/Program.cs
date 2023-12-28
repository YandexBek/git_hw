int n = 8961569;
int i = 1;
int num = n % 10;
while (i <= n)
{
    num = n % 10;
    Console.Write($"{num}, ");
    n = n / 10;
}