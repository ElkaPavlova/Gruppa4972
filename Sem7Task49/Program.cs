// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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

void Update2DArray(int[,] mtrx) //заменяем элементы с четными индексами на их квадраты
{
for (int i = 0; i < mtrx.GetLength(0); i = i+2)
    {
        for (int j = 0; j < mtrx.GetLength(1); j = j+2)
        {
        
            mtrx[i,j] = mtrx[i,j]*mtrx[i,j];
            // mtrx[i,j]*=mtrx[i,j]; тоже самое что и строчка выше
        }
    }
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int[,] arr2D = Fill2DArray(row,column,100,10);
Print2DArray(arr2D);
Update2DArray(arr2D);
Print2DArray(arr2D);