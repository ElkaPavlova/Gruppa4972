// Задача №20. Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine()?? "0");
//     return num;
// }

// double Calc2DDist(int x1, int x2, int y1, int y2)
// {
//     double res = MathSqrt((x2-x1)*(x2-x1)+(y1-y2)*(y1-y2));
//     return res;
// }

// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }

// int x1 = ReadData("Введите координаты первой точки: x = ");
// int y1 = ReadData("y = ");
// int x2 = ReadData("Введите координаты второй точки: x = ");
// int y2 = ReadData("y = ");

// double res = Calc2DDist(x1, y1, x2, y2);

// PrintResult("Расстояние между точками"+res);

double ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    Double value = int.Parse(Console.ReadLine() ?? "0");
    return value;
}

double distance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
}

void PrintResult(string msg) // печатаем результат
{
    Console.WriteLine(msg);
}

double x1 = ReadData("Введите x1: ");
double x2 = ReadData("Введите X2: ");
double y1 = ReadData("Введите y1: ");
double y2 = ReadData("Введите y2: ");
PrintResult("Расстояние: " + distance(x1, y1, x2, y2));