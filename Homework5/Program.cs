//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int myfunc(int number, int degree)
{
    int result = number;
    for(int i = 1; i < degree; i++)
    {
        result *= number;
    }
    return result;
}
Console.Write("Input number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int numB = Convert.ToInt32(Console.ReadLine());
if (numB < 0)
{
    Console.Write("Input natural number!");
    //numB = -numB; либо такой вариант 
}
else
Console.Write( numA + "," + numB + " -> "  + myfunc(numA,numB));


//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int FindSumOfNum (int numA)
{
    int sum = 0;
    int num = numA;
    while (num > 0) 
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
Console.Write("Input number: ");
int numA = Convert.ToInt32(Console.ReadLine());
if(numA < 0)
    numA = -numA;
FindSumOfNum(numA);
Console.Write("Sum of digits is = " + FindSumOfNum(numA));
*/
//Задача 3:Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] CreateRandomArray()
{
    int[] array = new int [8];
    for(int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(1,1000); 
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
}
int[] myArray = CreateRandomArray();
ShowArray(myArray);
