﻿// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

void Variant1()
{
Console.WriteLine("Способ 1");
System.Random numberGenerator = new System.Random(); //обращаемся к ядру той среды, где мы работаем, просим ОС сгенерировать случайное число
int number = numberGenerator.Next(10,100);
Console.WriteLine(number);

int firstDigit = number/10; // 34/10 = 3
int secondDigit = number%10; // 34$10 = 4

if(firstDigit>secondDigit){
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(secondDigit);
}
}

void Variant2()
{
Console.WriteLine("Способ 2");
System.Random numberGenerator1 = new System.Random(); 
int number1 = numberGenerator1.Next(10,100);
Console.WriteLine(number1);

Console.WriteLine((number1/10>number1%10)?(int)(number1/10):(int)(number1%10)); //доделать!!!
}

void Variant3()
{
Console.WriteLine("Способ 3");
System.Random numberGenerator = new System.Random(); //обращаемся к ядру той среды, где мы работаем, просим ОС сгенерировать случайное число
int number = numberGenerator.Next(10,100);
Console.WriteLine(number);

char[] digitChar = number.ToString().ToCharArray();
Console.WriteLine(digitChar[0]>digitChar[1]?digitChar[0]:digitChar[1]);
// <условие>?<ариант1>:<вариант2>
}

Variant2();

