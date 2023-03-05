// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.

//1. Заполняем массив
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

//2. Выводим массив
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

//3. Метод для выведения числа строк и столбцов из терминала
int Value(string text)
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

//4. Метод для поиска числа в массиве
bool FindFigure(int[,] matrix, int figure)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == figure)
            {
                return true;
            }
        }
    }

    return false;
}

//5. Метод для поиска позиции числа в массиве
int[] FindPosition(int[,] matrix, int number)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)
            {
                return new int[] { i, j };
            }
        }
    }

    return new int[] { 0, 0 };
}

void Find()
{
    int rows = Value("Кол-во строк в матрице: ");
    int columns = Value("Кол-во столбцов в матрице: ");
    int findNumber = Value("Искомое число: ");

    int[,] matrix = new int[rows, columns];
    FillMatrix(matrix, 0, 10);
    Console.WriteLine(PrintMatrix(matrix));

    bool check = FindFigure(matrix, findNumber);

    if (check)
    {
        int[] pos = FindPosition(matrix, findNumber);
        Console.WriteLine($"row: {pos[0]}  column:{pos[1]}");
    }
    else
    {
        System.Console.WriteLine("Такого элемента нет.");
    }

}

Find();
Console.WriteLine();