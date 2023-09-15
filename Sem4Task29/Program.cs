// Задача 29. Напишите программу, которая задает массив из 8 элементов и выводит их на экран.

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

int[] GenArr(int len) //генерируем массив
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for(int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(0, 15);
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

PrintArr(GenArr(ReadData("Введите размер массива: ")));