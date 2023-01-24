/*
Console.Write("Set the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
FillArrayRandomNumbers(array);
OutputArray(array);
int count = 0;

for (int j = 0; j < array.Length; j++)
if (array[j] % 2 == 0)
count++;

Console.WriteLine($"All even numbers {count} ");

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
    
}

void OutputArray(int[] array)

{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}
*/


/*
Console.Write("Set the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
OutputArray(numbers);

int sum = 0;
for (int j = 0; j < numbers.Length; j+=2)
    sum = sum + numbers[j];

    Console.WriteLine($"Sum of elements in even positions = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)    
        numbers[i] = new Random().Next(1, 11);
        
}
void OutputArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        Console.Write(numbers[i] + " ");
        
    Console.WriteLine();
}
*/


/*
Console.Write("Set the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];

FillArrayRandomNumbers(numbers);
OutputArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        max = numbers[i];
        
    if (numbers[i] < min)
        min = numbers[i];
        
}

Console.WriteLine($"Difference between maximum and minimum array element = {Math.Round(max - min, 2)}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        
}
void OutputArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        Console.Write(numbers[i] + " ");
        
    Console.WriteLine();
}
*/
