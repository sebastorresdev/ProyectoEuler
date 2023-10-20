namespace ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(SumSquareDifference(100));
    }

    private static long SumSquareDifference(int n)
    {
        long squareSum = (long)Math.Pow((n * (n + 1) / 2), 2);
        long sumSquare = n * (2 * n + 1) * (n + 1) / 6;
        return squareSum - sumSquare;
    }
}