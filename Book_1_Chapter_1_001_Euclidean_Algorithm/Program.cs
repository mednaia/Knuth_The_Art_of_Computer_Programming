// Даны два целых положительных числа m и n.
//Найти НОД.
Console.WriteLine("Input the first number:");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"m={m}");
Console.WriteLine("Input the second number:");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"n={n}");
while(m!=n)
{
    if(m>n)
    {
        m=m-n;
    }
    else
    {
        n=n-m;
    }
}
int nod = n;
Console.WriteLine($"Greatest common divisor = {nod}");