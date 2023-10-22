using System.Diagnostics;

Stopwatch stopwatch = new();
stopwatch.Start();


long targetDivisors = 500;
long n = 1;

while (true)
{
    long triangleNumber = n * (n + 1) / 2;

    // Descompone el número en factores primos
    long temp = triangleNumber;
    long divisors = 1;
    for (long i = 2; i * i <= temp; i++)
    {
        long count = 0;
        while (temp % i == 0)
        {
            temp /= i;
            count++;
        }
        divisors *= (count + 1);
    }
    if (temp > 1)
    {
        divisors *= 2;
    }

    if (divisors > targetDivisors)
    {
        Console.WriteLine($"El número triangular {triangleNumber} tiene {divisors} divisores.");
        break;
    }

    n++;
}

stopwatch.Stop();
long seconds = stopwatch.ElapsedMilliseconds;
Console.WriteLine("Tardo {0}", seconds);