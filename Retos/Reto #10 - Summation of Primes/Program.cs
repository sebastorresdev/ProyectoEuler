// suma de los primos debajo de 2 millones

using System.Diagnostics;

Stopwatch stopwatch = new();
stopwatch.Start();

// Uso del algoritmode criba de Eratóstenes

int count = 2000000;
bool[] isPrime = new bool[count];
long sum = 0;

for (int i = 2; i < count; i++)
{
    if (!isPrime[i])
    {
        sum += i;
        for (int j = i * 2; j < count; j += i)
        {
            isPrime[j] = true;
        }
    }
}

Console.WriteLine(sum);

stopwatch.Stop();

long seconds = stopwatch.ElapsedMilliseconds;
Console.WriteLine("Se demora {0} Millisegundos", seconds);
