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