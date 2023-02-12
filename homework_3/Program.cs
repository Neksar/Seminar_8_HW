// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int InputNumbers(string str)
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

int[,] FillRandomMatrix(int rows, int colums, int left, int right)
{
    int[,] matrix = new int[rows, colums];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i, j] = rand.Next(left, right);
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    return matrix;
}

int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
{
    int[,] multiplication = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < multiplication.GetLength(0); i++)
    {
        for (int j = 0; j < multiplication.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                multiplication[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return multiplication;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int number1 = InputNumbers("Введите количество строк матрицы: ");
int number2 = InputNumbers("Введите количество столбцов матрицы: ");
int number3 = InputNumbers("Введите количество столбцов второй матрицы: ");
int left = InputNumbers("Введите левую границу значения элементов: ");
int right = InputNumbers("Введите правую границу значения элементов: ");

int[,] matrix1 = FillRandomMatrix(number1, number2, left, right);
System.Console.WriteLine();
int[,] matrix2 = FillRandomMatrix(number2, number3, left, right);
System.Console.WriteLine();
System.Console.WriteLine("Произведение матриц равно");
int[,] multiplication = MultiplicationMatrix[matrix1, matrix2];
PrintArray(multiplication);