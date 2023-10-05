//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int ReadData(string line) // Ввод данных
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int SumMN(int m, int n, int res) // Считаем сумму чисел от M до N
{
    if (m == n) {
        return res;
    } 
    else
    {
        res = SumMN(m+1, n, res+m+1);
        return res;
    }
}

// тело программы
int m = ReadData("Введите число М: ");
int n = ReadData("Введите число N: ");
int sum = SumMN(m, n, m);
Console. WriteLine("Сумма чисел от " + m + " до " + n + " = " + sum);