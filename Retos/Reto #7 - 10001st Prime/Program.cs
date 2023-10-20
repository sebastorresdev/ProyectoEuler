using System.ComponentModel.Design;

namespace ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(StPrime(10001));
    }

    private static long StPrime(int n)
    {
        if (n == 1) return 2;
        int count = 1;
        int number = 1;
        while (count < n)
        {
            number += 2;
            if (IsPrime(number))
                count++;
        }
        return number;
    }

    private static bool IsPrime(int n)
    {
        if (n < 2) return false;
        if (n == 2 || n == 3) return true;

        for (int i = 2; i * i <= n; i++)
            if (n % i == 0) return false;

        return true;
    }
}