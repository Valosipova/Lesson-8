// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

void CreateRandomArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void ShowArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] firstMatr, int[,] secondMatr, int[,] resultMatr)
{
    for (int i = 0; i < resultMatr.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatr.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatr.GetLength(1); k++)
            {
                sum += firstMatr[i, k] * secondMatr[k, j];
            }
            resultMatr[i, j] = sum;
        }
    }
}

Console.Write("Введите количество строк 1-го массива: ");
int rowsFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1-го массива: ");
int columnsFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк 2-го массива: ");
int rowsSecondMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 2-го массива: ");
int columnsSecondMatrix = Convert.ToInt32(Console.ReadLine());

if (columnsFirstMatrix != rowsSecondMatrix)
{
    Console.WriteLine("Невозможно умножить матрицы");
    return;
}

int[,] firstMatrix = new int[rowsFirstMatrix, columnsFirstMatrix];
CreateRandomArray(firstMatrix);
Console.WriteLine($"Первая матрица:");
ShowArray(firstMatrix);

int[,] secondMatrix = new int[rowsSecondMatrix, columnsSecondMatrix];
CreateRandomArray(secondMatrix);
Console.WriteLine($"Вторая матрица:");
ShowArray(secondMatrix);

int[,] resultMatrix = new int[rowsFirstMatrix, columnsSecondMatrix];

MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"Произведение матриц:");
ShowArray(resultMatrix);
