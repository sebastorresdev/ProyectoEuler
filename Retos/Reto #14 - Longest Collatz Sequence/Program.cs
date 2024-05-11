long maxNumber = 1;
long maxCount = 1;
const long LIMIT_MAX = 1_000_000;

Dictionary<long, long> sequence = new()
{
    {1, 1}
};


for(long n = 1; n < LIMIT_MAX; n++)
{
    long tmp = n;
    long count = 0;
    while(true)
    {
        if (sequence.TryGetValue(tmp, out long value))
        {
            count += value;
            break;
        }
        if (tmp == 1) break;
        if (tmp % 2 == 0) tmp /= 2;
        else tmp = 3*tmp + 1;
        count++;
    }

    if (maxCount < count)
    {
        maxNumber = n;
        maxCount = count;
    }

    sequence[n] = count;
}

Console.WriteLine(maxNumber);