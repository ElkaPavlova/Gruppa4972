// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1,1) и т.д.)

int ReadData(string line) // вводим данные
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
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

int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder) //заполняем массив случайными числами
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

void PrintResult(string msg) // печатаем результат
{
    Console.WriteLine(msg);
}

int MainDiagSum(int[,] matrix)
{
    int n = matrix.GetLength(0) < matrix.GetLength(1)? matrix.GetLength(0): matrix.GetLength(1);
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        sum+=matrix[i,i];
    }
    return sum;
}

int row = ReadData("введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArray(row,column,8,1);
Print2DArray(arr2D);
Console.WriteLine($"Сумма главной диаганали {MainDiagSum(arr2D)}");