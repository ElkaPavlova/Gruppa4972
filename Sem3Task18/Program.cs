// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// 1) вести номер четверти -> ReadData()
// 2) ответить на вопрос
// 3) вывести ответ -> PtintResult

// Вводим данные

// string QuterBorderAsk(int numQuter)
// {
//     if(numQuter == 1) return "x > 0, y > 0";
//     if(numQuter == 2) return "x > 0, y < 0";
//     if(numQuter == 3) return "x < 0, y < 0";
//     if(numQuter == 4) return "x < 0, y > 0";
//     return StringEmpty;
// }

// int numQuter = ReadData("Введите номер четверти: ");

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

string QuterBorderAsk(int numQuter) // по координатам точки определяем номер четверти
{
    if(numQuter == 1) return "x > 0 и y > 0";
    if(numQuter == 2) return "x < 0 и y > 0";
    if(numQuter == 3) return "x < 0 и y < 0";
    if(numQuter == 3) return "x > 0 и y < 0";
    return "empty";
}

void PrintResult(string msg) // печатаем результат
{
    Console.WriteLine("Координаты находятся в диапазоне следующих значений: "+ msg);
}
