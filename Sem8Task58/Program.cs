// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

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

void Print2DArrays(int[,] matrix, int[,] matrix2) // печатаем результат
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");

        for (int j = 0; j < matrix.GetLength(1); j++) // печатаем первый массив
        {
            Console.Write(matrix[i,j]+" ");
        }

        Console.Write(" ]  [ ");

        for (int j = 0; j < matrix2.GetLength(1); j++) // печатаем второй массив
        {
            Console.Write(matrix2[i,j]+" ");
        }

        Console.Write("] ");

        Console.WriteLine();
    }
}

int[,] MatrixToMatrix(int[,] arr, int[,] arr2) // Метод перемножения двух матриц
{
    int[,] resultMatrix = new int[arr.GetLength(0), arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            for (int z = 0; z < arr.GetLength(1); z++)
            {
                resultMatrix[i, j] += arr[i, z] * arr2[z, j];
            }
        }
    }

    return resultMatrix;
}

Console.Write("Укажите размер массива в строках: ");
int sizeY = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите размер массива в столбцах: ");
int sizeX = Convert.ToInt32(Console.ReadLine());

int[,] arr2D = Fill2DArray(sizeX,sizeY,1,10);
int[,] arr2D_2 = Fill2DArray(sizeX,sizeY,1,10);
int[,] resultMatrix = MatrixToMatrix(arr2D, arr2D_2);

Print2DArrays(arr2D, arr2D_2);

Console.WriteLine("\n\r");

Print2DArray(resultMatrix);