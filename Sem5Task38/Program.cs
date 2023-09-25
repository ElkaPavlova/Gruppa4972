// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

//double[] GenArray(int length, double lowBorder, double highBorder) // метод для генерации массива с заданными параметрами

double[] GenArray(int length)
{
    double[] arr = new double[length];
    
    for (int i = 0; i < length; i++)
    {
        //arr[i] = Random.NextDouble(lowBorder, highBorder + 1);

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

// double SearchMax(double[] arr)
// {
//     double maximum = arr[0];
//     for(int i = 1; i < arr.Length; i++)
//     {
//         if(arr[i] > maximum)
//         {
//             maximum = arr[i];
//         }
//     }
//     return maximum;
// }
double[] MaxMinNumber(double[] arr)
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
    //Console.WriteLine("min - " + numMin + ", max - " + numMax);
    return newArray;
}

double MinMaxDiff(double min, double max)
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

//Console.WriteLine(SearchMax(array));
//Console.WriteLine("min - " + MaxMinNumber(array) + ", max - " + numMaxMaxMinNumber(array));
//PrintResult("Сумма элементов, стоящих на нечётных позициях - "+res); // выводим результат


//Нашла решение в интернете:
// Console.Write(«Введите количество элементов массива: «);
// int a = Convert.ToInt32(Console.ReadLine());
// double[] randomArray = new double[a];

// void mas(int a)
// {
// Random rand = new Random();
// for (int i = 0; i < a; i++)
// {
// randomArray[i] = rand.NextDouble();
// Console.Write($»{randomArray[i]:F2} «);
// }

// }

// double raz(double[] randomArray)
// {
// double min = randomArray[0];
// double max = randomArray[0];
// int i = 1;
// while (i < randomArray.Length)
// {
// if (max<randomArray[i])
// max = randomArray[i];
// if (min>randomArray[i])
// min = randomArray[i];
// i = i + 1;
// }
// return max-min;
// }

// mas(a);
// Console.Write($»\nРазница между максимальным и минимальным элементов массива: {raz(randomArray):F2}»);