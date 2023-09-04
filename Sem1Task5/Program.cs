//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

int NumN = int.Parse(Console.ReadLine()??"0");
int evNumN = (-1)*NumN;

while (evNumN < NumN)
{
   Console.Write (evNumN + ", ");
   evNumN++;
}
  Console.WriteLine (NumN);