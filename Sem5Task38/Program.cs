// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// метод для генерации массива с заданными параметрами

double[] GenArray(int length)
{
    double[] arr = new double[length];
    
    for (int i = 0; i < length; i++)
    {
        Random rand = new Random();
        arr[i] = Math.Round(rand.NextDouble()*100, 2);
    }
    return arr;
}

void PrintArr(double[] arr) //печатаем массив
{
    Console.Write("[");
    for (int i=0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i] + "  ");
    }
Console.WriteLine((arr[arr.Length-1]) + "]");
}

double[] MaxMinNumber(double[] arr) // поиск максимального и минимального чисел в массиве
{
    double numMax = arr[0];
    double numMin = arr[0];
    
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > numMax)
        {
            numMax = arr[i];
        }
        else if (arr[i] < numMin)
        {
            numMin = arr[i];
        }
    }
    double[] newArray = new double[2];
    newArray[0] = numMin;
    newArray[1] = numMax;
    return newArray;
}

double MinMaxDiff(double min, double max) // ищем разницу между максимальным и минимальным числами
{
    double diff = max - min;
    return  Math.Round(diff, 2);
}

void PrintResult(string msg)  // печатаем результат
{
    Console.WriteLine(msg);
}

double[] array = GenArray(6); // генерируем массив
PrintArr(array); // печатаем массив
double[] arrNew = MaxMinNumber(array);
PrintResult("Разница между максимальным и минимальным числом - " + MinMaxDiff(arrNew[0], arrNew[1]));