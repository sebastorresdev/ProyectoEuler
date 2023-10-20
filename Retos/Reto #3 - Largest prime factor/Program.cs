/*
    # Reto #3 - Largest Prime Factor
    # Dificultad: Facil / Solucion: 13/09/2023
*/

/*
* El factores primos de 13195 son 5, 7, 13 y 29
* Cual es el mayor factor primo de 600851475143
*/

namespace ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        long num = 600851475143;
        Console.WriteLine(GetLargestPrimeFactor(num));

    }
    static long GetLargestPrimeFactor(long n)
    {
        for (long i = (long)Math.Sqrt(n); i > 2; i--)
            if (n % i == 0 && IsPrime(i)) return i;

        return n;
    }

    static bool IsPrime(long n)
    {
        if (n <= 1) return false;

        for (long i = 2; i * i <= n; i++)
            if(n % i == 0) return false;

        return true;
    }
}