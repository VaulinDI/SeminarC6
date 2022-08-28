// Задать двумерный массив следующим правилом: Aₘₙ = m+n
int m = 10;
int n = 12;
double[,] array = new double[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = i + j;
        Console.Write("{0}\t", array[i, j]);
    }
    Console.WriteLine();
}