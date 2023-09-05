// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: "); //Считываем данные с консоли
int inputNum = int.Parse(Console.ReadLine()?? "0");

Console.WriteLine("Введите второе число: "); //Считываем данные с консоли
int inputNum2 = int.Parse(Console.ReadLine()?? "0");

if (inputNum > inputNum2)
{
Console.WriteLine("Max = "+inputNum);
Console.WriteLine("Min = "+inputNum2);
}
else if (inputNum==inputNum2)
{
   Console.WriteLine("Числа равны!"); 
}
else
{
Console.WriteLine("Max = "+inputNum2);
Console.WriteLine("Min = "+inputNum);
}





