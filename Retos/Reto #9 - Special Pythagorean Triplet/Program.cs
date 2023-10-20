for (int a = 1; a < 333; a++)
{
    for (int b = a + 1; b < 500; b++)
    {
        int c = 1000 - a - b;
        if (a*a + b*b == c*c)
        {
            Console.WriteLine(a*b*c);
            break;
        }
    }
}