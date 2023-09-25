// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] GenArray(int length, int lowBorder, int highBorder) // метод для генерации массива с заданными параметрами
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(lowBorder, highBorder + 1);
    }
    return arr;
}

void PrintArr(int[] arr) //печатаем массив
{
    Console.Write("[");
    for (int i=0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i] + ",");
    }
Console.WriteLine((arr[arr.Length-1]) + "]");
}

void PrintResult(string msg)  // печатаем результат
{
    Console.WriteLine(msg);
}

int SumNegPos(int[] arr) // считаем сумму чисел, стоящих на нечетных позициях
{
    int sum = 0;
    for(int i = 1; i < arr.Length; i = i + 2) // начинаем с элемента с индексом 1
    {
        sum = sum + arr[i];
    }
    return sum;
}

int[] array = GenArray(6, 1, 20); // генерируем массив
PrintArr(array); // печатаем массив
int res = SumNegPos(array); // подсчет суммы чисел, стоящих на нечетной позиции
PrintResult("Сумма элементов, стоящих на нечётных позициях - "+res); // выводим результат