//homework for the first session

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2) Console.WriteLine($"{num1} большее число, а {num2} - меньшее "  );
else if(num1 == num2) Console.WriteLine($"{num1} равно {num2} "  );
else Console.WriteLine($"{num1} меньше число, а {num2} - большее "  );
*/


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max) max = num2;
if(num3 > max) max = num3;

Console.WriteLine($"Максимальным из трех введенных чисел является {max}");
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0) Console.WriteLine($"Введённое число, {number} является четным. ");
else Console.WriteLine("Данное число нечетное. ");
*/



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 1;            
while (current <= number)
{
	if (current % 2 == 0) Console.Write(current + "  ");
	current ++;
}
*/