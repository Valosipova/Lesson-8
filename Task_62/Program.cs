// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
            {
                Console.Write($" {array[i, j]} ");
            }
            else 
            {
                Console.Write($"{array[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}

void CreateHelicalArray(int[,] array)
{
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
        temp += 1;

        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j += 1;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i += 1;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j -= 1;
        else
            i -= 1;
    }
}

const int arraySize = 4;
int[,] squareMatrix = new int[arraySize, arraySize];

CreateHelicalArray(squareMatrix);
ShowArray(squareMatrix);
