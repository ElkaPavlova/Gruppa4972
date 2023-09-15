// Задача 25. Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.

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

long MyPow (int A, int B)
{
    long res = 1;
    while (B > 0) // пока число В больше чем 0
    {
        res = res * A;
        B = B - 1;
    }
    return res;
}

int numA = ReadData("Введите число А: ");
int numB = ReadData("Введите число В: ");

long result = MyPow(numA, numB);

PrintResult("Число А в степени числа В = " + result);