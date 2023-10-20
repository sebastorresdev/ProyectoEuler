namespace ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(SmallestMultiple(20));
    }

    private static long SmallestMultiple(int n)
    {
        long mcm = 1;
        for (int i = 2; i <= n; i++)
        {
            mcm = MCM(mcm, i);
        }
        return mcm;
    }

    static long MCD(long a, long b) => b == 0 ? a : MCD(b, a % b);

    static long MCM(long a, long b) => a * b / MCD(a, b);
}