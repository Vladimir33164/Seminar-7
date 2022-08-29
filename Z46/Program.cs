//Задача 46: Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами.

//m = 3, n = 4.
//1 4 8 19
//5 -2 33 -2
//77 3 8 1


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
// m - строчки, n - столбцы
int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++) // строчки
    {
        // j, m , k 
        for (int j = 0; j < matrix.GetLength(1); j++) // cтолбцы
        {
            matrix[i, j] = new Random().Next(11);
        }
    }
    return matrix;
}

int[,] result = GetArray(rows, columns); // числа от 0 до 10 в двумерном массиве

void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) // GetLength(0)  - строчки
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++) //GetLength(1)  -столбцы
        {
            Console.Write(inputMatrix[i, m] + "\t"); // "\t" - Tab
        }
        Console.WriteLine();
    }
}

PrintArray(result);