﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine("ведите число: "); //Считываем данные с консоли
int N = int.Parse(Console.ReadLine()?? "0"); // превращаем строку в число, присваиваем переменной и проверяем на null

if(N%2 == 0) //проверяем равен ли остаток от деления нулю
{
    Console.WriteLine("Это число четное");
}
else
{
    Console.WriteLine("Это число нечетное");
}