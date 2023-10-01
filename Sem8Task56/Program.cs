// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int FindMinSummLine(int[,] arr) // Метод поиска строки с наименьшей суммой элементов
{
    int numOfLine = 0;

    int summLine = 0;
    int summLinePrev = 0;

    for (int j=0; j < arr.GetLength(1); j++) // Считаем что первая строка и есть строка с минимальной суммой элеметнов
    {
        summLinePrev += arr[0,j];
    }

    for (int i=1; i < arr.GetLength(0); i++)  // Сравниваем суммы элементов оставшихся строк
    {
        summLine = 0;
        for (int j=0; j < arr.GetLength(1); j++)
        {
            summLine += arr[i,j];
        }

        if (summLine < summLinePrev) { // Если сумма сравниваемой строки элементов меньше чем предыдущая - запоминаем сумму и номер строки
            summLinePrev = summLine;
            numOfLine = i;
        }
    }

    return numOfLine;
}

int[,] arr2D = Fill2DArray(5,3,1,10);

Print2DArray(arr2D);

Console.WriteLine("\n\r");

Console.WriteLine("Номер строки с минимальной суммой значений: " + FindMinSummLine(arr2D));