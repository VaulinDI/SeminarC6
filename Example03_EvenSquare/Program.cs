// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
int m = 4;
int n = 5;
int[,] array = new int[m, n];

void FillArray()
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 100);
        Console.Write("{0}\t", array[i, j]);
    }
    Console.WriteLine();
}
}

void EvenSquare()
{
for (int x = 0; x < array.GetLength(0); x++)
{
    for (int y = 0; y < array.GetLength(1); y++)
    {
        if (x % 2 == 0 && y % 2 == 0)
        {
            array[x, y] = array[x, y] * array[x, y];
        }
        Console.Write("{0}\t", array[x, y]);
    }
    Console.WriteLine();
}
}

FillArray();
Console.WriteLine();
EvenSquare();