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
*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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
Console.Write("Input max umber: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
SumOfOddElements(myArray);