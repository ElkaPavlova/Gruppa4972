// Задача №10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int num = new Random().Next(100,1000); //выбираем случайное число из промежутка 
Console.WriteLine(num);

char[] arr = num.ToString().ToCharArray();
Console.WriteLine(arr[1]);