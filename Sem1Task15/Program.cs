// №15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
Console.WriteLine("Введите число от 1 до 7: ");
int den = int.Parse(Console.ReadLine()??"0");

if (den<=5)
{
    Console.WriteLine(den + " - рабочий");
}
else if (den<=7)
{
    Console.WriteLine(den + " - выходной");
}
