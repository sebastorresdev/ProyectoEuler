namespace ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(GetLargestPalindromo());
    }

    private static int GetLargestPalindromo()
    {
        int largestPalindromo = 0;
        for (int i = 999; i >= 100; i--)
        {
            for (int j = i; j >= 100; j--)
            {
                int n = i * j;
                if (IsPalindrome(n))
                {
                    largestPalindromo = Math.Max(largestPalindromo, n);
                    break;
                }
            }
        }
        return largestPalindromo;
    }

    static bool IsPalindrome(int num)
    {
        int tmp = num;
        int r, reverse = 0;
        while (tmp > 0)
        {
            r = tmp % 10;
            tmp /= 10;
            reverse = reverse * 10 + r;
        }
        return num == reverse;
    }
}