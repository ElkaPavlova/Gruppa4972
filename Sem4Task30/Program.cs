// Задача №30
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// 1) Длина массива -> ReaData
// 2) Генерация массива -> GenArr
// 3) Печать массива -> PrintArr

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
        arr[i] = rnd.Next(0, 2);
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


//int ReadData(string msg) // вводим данные
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }
// int[] randomArray(int len){
//     int[] rA = new int[len];
//     for(int i = 0; i < len; i++)
//     {
//         rA[i] = new Random().Next(0, 2);
//     }
//     return rA;
// }
// void outPutArray(int[] arr){
//     Console.Write("[");
//     for(int i = 0; i < arr.Length - 1; i++){
//         Console.Write(arr[i] + ",");
//     }
//     Console.WriteLine( arr[arr.Length - 1] +"]");
// }
// int len = ReadData("Введите длину массива ");
// outPutArray(randomArray(len));