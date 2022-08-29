//Задача 49: Задайте двумерный массив. Найдите элементы, у 
//которых оба индекса чётные, и замените эти элементы на их 
//квадраты.

//Например, изначально массив
//выглядел вот так:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть 
//вот так:
//1 4 7 2
//5 81 2 9
//8 4 2 4

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
for (int i = 0; i < matrix.GetLength(0); i++) // строчки
{
    // j, m , k 
    for (int j = 0; j < matrix.GetLength(1); j++) // cтолбцы
    {
        matrix[i, j] = new Random().Next(11); // [0;10]
        Console.Write(matrix[i, j] + "\t"); // "\t"
    }
    Console.WriteLine();
}

Console.WriteLine("Result array:");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            Console.Write((matrix[i, j] * matrix[i, j] )+ "\t");
        }
        else Console.Write(matrix[i, j] + "\t"); // "\t"
    }
   Console.WriteLine();
}