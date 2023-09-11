//  Задача No16
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// мое решение
// Console.WriteLine("Введите два числа: "); 
// int oneNum = int.Parse(Console.ReadLine());
// int twoNum = int.Parse(Console.ReadLine());

// if (oneNum == twoNum*twoNum) 
// {
//     Console.WriteLine("Первое число является квадратом второго");
// }
// else if (twoNum == oneNum*oneNum)
// {
//     Console.WriteLine("Второе число является квадратом первого");
// }
// else 
// {
//     Console.WriteLine("Числа не квадраты друг друга...");
// }

int numA = int.Parse(Console.ReadLine() ?? "0");
int numB = int.Parse(Console.ReadLine() ?? "0");

bool test1 = (numA == numB*numB);
bool test2 = (numB == numA*numA);

if (test1) Console.WriteLine("Первое квадрат второго");
if (test2) Console.WriteLine("Второе квадрат первого");
if (!(test1||test2))  // логическая "или", если тест1 и тест2 не выполнились, то делаем то, что ниже
{
    Console.WriteLine("Числа не квадраты друг друга");
}