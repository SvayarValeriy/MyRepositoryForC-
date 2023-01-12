/*
//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.



int x1 = ReadInt("Введите х для точки А1: ");
int y1 = ReadInt("Введите y для точки А2: ");
int z1 = ReadInt("Введите z для точки А3: ");
int x2 = ReadInt("Введите х для точки В1: ");
int y2 = ReadInt("Введите y для точки В2: ");
int z2 = ReadInt("Введите z для точки В3: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;

double distance = Math.Sqrt(A * A + B * B + C * C);
distance = Math.Round(length, 2);
Console.WriteLine("Расстояние = " + distance);


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

*/


/*
//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
// чисел от 1 до N.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <=n; i++)
{
  Console.Write($"{i * i * i}, ");
}


//Второй вариант, с применением math, только не получилось сделать вывод в 1 строку.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <=n; i++)
{
  Console.WriteLine(Math.Pow(i, 3));
}

*/