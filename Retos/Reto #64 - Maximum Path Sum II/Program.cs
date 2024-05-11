var read = File.ReadAllLines("0067_triangle.txt");

var content = read.Select(line => line.Split(' ').Select(d => Convert.ToInt32(d)).ToArray())
                  .ToArray();

for (int i = content.Length - 1; i > 0; i--)
{
    for (int j = 0; j < content[i].Length - 1; j++)
    {
        content[i - 1][j] = Math.Max(content[i][j] + content[i - 1][j], content[i][j + 1] + content[i - 1][j]);
    }
}

Console.WriteLine(content[0][0]);