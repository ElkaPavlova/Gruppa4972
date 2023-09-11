// №13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Ведите число:");

string num = Console.ReadLine();

char[] arr = num.ToCharArray(); //создаем массив из введенного числа

//Console.WriteLine((arr[2]) ?? "Третьей цифры нет");

if (arr.Length >= 3) // условие - если длина массива больше или равна 3
{
    Console.WriteLine(arr[2]); //то вывести третий элемент
}  
else 
{
    Console.WriteLine("Третьей цифры нет");
}