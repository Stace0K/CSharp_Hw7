// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillMatrix(int[,] matrix, int min, int max)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
}

string PrintMatrix(int[,] matrix)
{
    string result = string.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    return result;
}

int GetValue(string text)
{
    int value = 0;

    bool flag = false;
    while (!flag)
    {
        Console.Write(text);
        flag = int.TryParse(Console.ReadLine(), out value);
    }

    return value;
}

void MatrixColumnsAverage()
{
    int rows = GetValue("Кол-во строк в матрице: ");
    int columns = GetValue("Кол-во столбцов в матрице: ");

    int[,] matrix = new int[rows, columns];
    FillMatrix(matrix, 1, 101);
    Console.WriteLine(PrintMatrix((matrix)));
    Console.Write("Среднее арифметическое чисел в столбцах: ");

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];       
        }
        Console.Write($"{sum / matrix.GetLength(0)} ");
    }
}

MatrixColumnsAverage();

