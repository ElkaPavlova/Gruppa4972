// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

void PrintFibNum(int num) //выводим числа Фибоначи
{
    int buf = 0;
    int first = 0;
    int second = 1;
    Console.Write(first + "-" + second);

    for(int i = 2; i < num; i++)
    {
        Console.Write("-" + (first + second));
        buf = first + second;
        first = second;
        second = buf;
    }
    Console. WriteLine();
}
//****************************

int number = ReadData("Введите число: ");
PrintFibNum(number);