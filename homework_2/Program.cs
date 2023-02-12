// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int InputRowsColums(string str)
{
    int number;
    string? text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Вы ввели не число");
    }
    return number;
}

int[,] FillRandomMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i, j] = rand.Next(0, 10);
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    return matrix;
}

int[] SumStringMatrix(int[,] matrix)
{
    int[] sumStringMatrix = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumStringMatrix[i] += matrix[i, j];
        }
    }
    return sumStringMatrix;
}

int FindMinElement(int[] array)
{
    int index = 0;
    int minElement = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (minElement > array[i])
        {
            minElement = array[i];
            index = i;
        }
    }return index + 1;
}

int row = InputRowsColums("Введите количество строк массива: ");
int colum = InputRowsColums("Введите количество столбцов массива: ");
int[,] matrix = FillRandomMatrix(row, colum);
System.Console.WriteLine();
int[] sumSringMatrix = SumStringMatrix(matrix);
int numb = FindMinElement(sumSringMatrix);
System.Console.WriteLine($"Строка с минимальной суммой элементов - {numb}");