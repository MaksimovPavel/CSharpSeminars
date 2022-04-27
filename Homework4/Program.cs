//Задача 1.Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*

int[] CreateRandomArray(int size)
{
    int[] array = new int [size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100,1000);
    }

    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
void FindEvenElements(int[] array) 
{
    int evenElemAmmount = 0;

    for(int i = 0; i <array.Length; i++)
    {
        if(array[i] % 2 == 0)
            evenElemAmmount += 1;
    }
    Console.WriteLine("Ammount of even elements is " + evenElemAmmount);
}

Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size);
ShowArray(myArray);
FindEvenElements(myArray);

//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int [size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
void SumOfOddElements(int[] array) 
{
    int sum = 0;

    for(int j = 0; j <array.Length; j+=2)
    {
        sum += array[j];
    }
    Console.WriteLine("Sum of elements with odd index is " + sum);
}

Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
SumOfOddElements(myArray);

*/
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] array = new double[10]; // [10 - количество элементов массива]

Random random = new Random();
for (int i = 0; i < 10; i++)
    {
        array[i] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write("{0,6:F2}", array[i]);
    }
    Console.WriteLine();
void FindDifOfMaxMin(double[] array) 
{
    double max = array[0];
    double min = array[0];
    double sum = 0;
    for (int i = 0; i < 10; i++)
    {
        if(array[i] > max)
            max = array[i];
        else if(array[i] < min)
            min = array[i];
            sum = max - min;
    }
    Console.WriteLine("Max = {0,4:F2}",max);
    Console.WriteLine("Min = {0,4:F2}",min);
    Console.WriteLine("Difference = {0,4:F2}",sum);
}
FindDifOfMaxMin(array);



