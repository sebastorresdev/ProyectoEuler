static long CalculateRoutes(int dx, int dy)
{
    if (dx < 0 || dy < 0) throw new Exception("los numeros x e y tienen que ser mayor o igual a cero");

    var grid = new long[dx + 1, dy + 1];

    for (int y = 0; y <= dx; y++) grid[0, y] = 1;
    for (int x = 0; x <= dy; x++) grid[x, 0] = 1;

    for (int y = 1; y <= dx; y++)
        for (int x = 1; x <= dx; x++)
            grid[x, y] = grid[x - 1, y] + grid[x, y - 1];

    return grid[dx, dy];
}

Console.WriteLine(CalculateRoutes(20, 20));