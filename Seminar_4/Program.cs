
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
Console.WriteLine("Type a number");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
    int num = i % 10;
    i /= 10;
    sum += num;
}
Console.WriteLine("The sum of all the digits in the number is: " + sum);
*/
/*
//Задача 25: (Как я её понял) Напишите программу которая принимает на вход два числа А и b
//и возводит A в степень В.
//Вообще, что то у меня туго заходит си шарп

Console.Write("Type a number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Type a number B: ");
int b = Convert.ToInt32(Console.ReadLine());

int Step = 1;
for (int i = 0; i < b; i++)
{
    Step *= a;
}
Console.WriteLine($"{a} to the power of {b} is, {Step}");
*/


//Задача 29: Напишите программу, которая задаёт массив из m элементов
// и выводит их на экран.

//Наверное не все как надо сделано. Например вывод массива без скобок и не разделен запятыми.
// Ниже вариант без применения метода. 

/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i != array.Length; i++)
    {
        Console.Write($"Введите значение для элемента [{i}]: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Введите размерность массива: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray(m);
ShowArray(newArray);

*/

/*
Console.Write("Введите размерность массива: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] array = new int[m];
    for (int i = 0; i != array.Length; i++)
    {
        Console.Write($"Введите значение для элемента [{i}]: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}   
ShowArray(array);
*/