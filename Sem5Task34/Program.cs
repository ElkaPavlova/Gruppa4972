// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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

int CountEvn(int[] arr) // считаем количество четных чисел в массиве
    {
        int count = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i]%2 == 0) 
            {
            count++;
            }
        }
        return count;

    }

int[] array = GenArray(20, 100, 999); // генерируем массив
PrintArr(array); // печатаем массив
int res = CountEvn(array); // считаем четные числа
PrintResult("Количество четных чисел в массиве - "+res); // выводим результат