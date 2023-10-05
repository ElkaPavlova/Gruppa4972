// Задача 64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в
// промежутке от N до 1. Выполнить с помощью рекурсии.

int ReadData(string line) // Ввод данных
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void NatureNumber(int num) // метод, который выводит натуральные числа от N до 1
{
    Console.Write(num+" ");
    if(num<=1)
    {

    }
    else
    {
       NatureNumber (num-1);
    }
}

int num = ReadData("Введите число N: ");
NatureNumber (num);