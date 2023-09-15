// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

int ReadData(string msg) // метод, который вводит число
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

void PrintResult(string msg) // печатаем результат
{
    Console.WriteLine(msg);
}

int SumDigit (int num) //метод, считающий сумму цифр в веденном числе
{
    int res = 0;
    while(num > 0)
    {
        res = res + num % 10; // к res прибавляем последнюю цифру числа
        num = num/10;
    }
    return res;
}

int number = ReadData("Введите число: ");
int result = SumDigit(number);

PrintResult("Сумма цифр в этом числе - " + result);