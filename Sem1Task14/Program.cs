// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

Console.WriteLine("Введите число: ");

int num = (int.Parse(Console.ReadLine()??"1"));

if ((num%7 == 0) && (num%23 == 0))
{
    Console.WriteLine ("Это число кратно 7 и 23");
}
else
{
    Console.WriteLine ("Это число не кратно 7 и 23");
}