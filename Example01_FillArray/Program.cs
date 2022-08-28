// Показать двумерный массив размером m×n заполненный вещественными числами
int m = 4;
int n = 5;
double[,] array = new double[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().NextDouble() * 100;
        Console.Write("{0,0:F1}\t", array[i, j]);
    }
    Console.WriteLine();
}