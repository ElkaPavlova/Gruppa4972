// int numA = int.Parse(Console.ReadLine)??"0";
// int numB = int.Parse(Console.ReadLine)??"0";

// if(numB*numB==numA) {

//     Console.WriteLine("Первое число квадрат второго");
// }
// else{
//     Console.WriteLine("Первое число не квадрат второго");
// }

Console.WriteLine("Введите число 1:");
int num1 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите число 2:");
int num2 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(num1 == Math.Pow(num2, 2) ? "Да" : "Нет");