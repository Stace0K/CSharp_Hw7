// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//1. Заполняем массив
void FillMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble (new Random().Next (-40, 40) / 10.0);
        }
    }
}

//2. Выводим массив
string PrintMatrix(double[,] matrix)
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

//3. Метод для выведения числа строк и столбцов из терминала
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

//4. Вывод

void Matrix()
{
    int rows = GetValue("Кол-во строк в матрице: ");
    int columns = GetValue("Кол-во столбцов в матрице: ");

    double[,] matrix = new double[rows, columns];
    FillMatrix(matrix);
    Console.WriteLine(PrintMatrix((matrix)));
}

Matrix();