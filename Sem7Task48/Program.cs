// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.

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

int[,] Fill2DSumIndex(int row, int colomn) // заполняем массив, каждое число в ячейке = сумма его индексов
{
    int[,] arr = new int[row, colomn];
    for(int i=0; i < row; i++)
    {
        for(int j=0; j < colomn; j++)
        {
            arr[i,j] = i + j;
        }
    }
    return arr;
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int[,] arr2D = Fill2DSumIndex(row,column);
Print2DArray(arr2D);