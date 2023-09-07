//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");    
int num1 = int.Parse(Console.ReadLine()?? "0");

Console.WriteLine("Введите второе число: "); 
int num2 = int.Parse(Console.ReadLine()?? "0");

Console.WriteLine("Введите третье число: "); 
int num3 = int.Parse(Console.ReadLine()?? "0");

int max = num1;
if (max < num2) 
{
    max=num2;
}

if(max < num3)
{
    max=num3;
}
Console.WriteLine("Max = "+max);

