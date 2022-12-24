/*
int CutNumber(int number)
{
    int sot = number / 100;
    int ed = number % 10;

    int result = sot * 10 + ed;
    return result;
}

int randNumber = new Random().Next(100, 1000);
int newNumber = CutNumber(randNumber);

Console.WriteLine($"New version of a number {randNumber} is {newNumber}");
*/
/*
bool MultipleOfFirst(int number1, int number2)
{
    if(number2 % number1 == 0)
        return true;
    else
        return false;
}

Console.WriteLine("Данная программа принимает 2 числа и определяет, является ли второе число кратным первому.");
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(MultipleOfFirst(num1, num2))
    Console.WriteLine("Второе число кратно первому!");
else
    Console.WriteLine("Второе число не является кратным первому.");
    */
/*

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int FindSecDig(int num)
{
    int sec = num / 10 % 10;
    return sec;
}

Console.WriteLine("Находим и выводим второй знак от введенного трехзначного числа. ");
Console.Write("Введите трехзначное число: ");

int newnum = Convert.ToInt32(Console.ReadLine());
int desired = FindSecDig(newnum);
if(newnum > 999 || newnum < 100)
    Console.WriteLine("Некорректный ввод. Вводите только трехзначное число!");
else
    Console.WriteLine($"Вторая цифра введенного вами числа {newnum} - {desired}");



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int FindThirdDig(int num)
{
	while (num >= 1000) num /= 10;
        int result = num % 10;
        return result;
}
Console.WriteLine("Находим и выводим третью цифу от введенного числа. ");
Console.Write("Enter a number: ");
int newnum = Convert.ToInt32(Console.ReadLine());
int desired = FindThirdDig(newnum);
if (newnum < 100)
        Console.WriteLine("Третьей цифры нет!");
else
    Console.WriteLine($"Третья цифра введенного вами числа {newnum} - {desired}");



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

void CheckingTheDayOfTheWeek (int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7) Console.WriteLine($"{dayNumber} -> да");

    else if (dayNumber < 1 || dayNumber > 7) Console.WriteLine("Такого дня недели не существует");
    
    else Console.WriteLine($"{dayNumber}  -> нет");
}

Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

CheckingTheDayOfTheWeek(dayNumber);


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// Вариант 2
bool CheckingTheDayOfTheWeek(int dayWeek)
{
    if(dayWeek == 6 || dayWeek == 7)
        return true;
    else
        return false;
}

Console.WriteLine("Определяем, является ли день выходным.");
Console.Write("Введите цифру дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
CheckingTheDayOfTheWeek(dayNumber);

if (dayNumber < 1 || dayNumber > 7)
    Console.WriteLine("Такого дня недели не существует.");
else if(CheckingTheDayOfTheWeek(dayNumber))
    Console.WriteLine($"{dayNumber} -> да");
else
    Console.WriteLine($"{dayNumber}  -> нет");
*/