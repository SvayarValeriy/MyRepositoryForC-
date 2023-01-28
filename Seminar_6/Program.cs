//Homework for sixth seminar

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

/*
Console.Write("enter value b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("enter value k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("enter value b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("enter value k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x1 = (b1 - b2);
double x2 = (k2 - k1);

double x = x1 / x2;
double y = k2 * x + b2;

if (x2 == 0) Console.WriteLine($"lines do not intersect");

else Console.WriteLine($"Intersection point coordinates: {x}  {y}");
*/

// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int count = 0;
Console.Write("How many numbers will we enter?: ");
int m = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    Console.Write("Type a number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0) count++;    
}
Console.WriteLine("numbers greater than zero: " + count);
Console.WriteLine();
*/