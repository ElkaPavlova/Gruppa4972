// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

int ReadData(string line) // вводим данные
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,] Fill2DArray(int countRow, int countColumn, int downBorder, int topBorder) ///заполняем массив случайными числами
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i,j] = rnd.Next(downBorder,topBorder);
        }
    }

    return array2D;
}

void Print2DArray(int[,] matrix) // печатаем результат
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
    }
}

// Array.Sort(intArray);

void SortArr(int[,] arr) // Метод сортироовки строк в двумерном массиве
{
    int[] buf= new int[arr.GetLength(1)];

    for (int i=0; i < arr.GetLength(0); i++)
    {
        for (int j=0; j < arr.GetLength(1); j++)
        {
            buf[j] = arr[i,j];
        }
        Array.Sort(buf); // Вызов стандартного метода сортироки одномерного массива

        for (int j=0; j < arr.GetLength(1); j++) // Пересохранение отсортированной строки в двумерном массиве
        {
            arr[i,j] = buf[j];
        }
    }
}

int[,] arr2D = Fill2DArray(3,4,1,10);

Print2DArray(arr2D);

SortArr(arr2D);

Console.WriteLine("\n\r");

Print2DArray(arr2D);