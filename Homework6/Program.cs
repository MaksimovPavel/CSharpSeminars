// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int [] CreateArray(int size)
{
    int [] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Input " + i + " element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());

    }
    return array;
}

void FindPosElements(int[]array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        sum++;
    }
    Console.Write("Possitive elements: " + sum);
}
Console.Write("Input amount of numbers: ");
int size = Convert.ToInt32(Console.ReadLine());
int[]array = CreateArray(size);
FindPosElements(array);

//Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int num = number;
string s = "";
while (num > 0)
{
s = ((num % 2 == 0) ? "0" : "1") + s;
num /= 2;
}
Console.Write("Number in 2 system is:" +s);
Console.ReadKey();


Console.Write("Input number to convert - ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int [10];
int result = 0;
int num = number;
while(num > 0)
{
    for(int i = 0; i < 10; i++)
    {
        result = num % 2;
        num /= 2;
        array[i] = result;
    }
} 

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int[] ReverseArray(int[] array) // 1 -4 3 -2 6 -1 5 3 8 -5
{
    int newSize = array.Length;
    int[] newArray = new int[newSize];

    for (int i = 0, j = array.Length - 1; i < newSize; i++,j--)
    {
        newArray[i] = array[j];
    }
    return newArray;
}

int[] newArr = ReverseArray(array);
ShowArray(array);
ReverseArray(array);
Console.Write("result is: " );
ShowArray(newArr);
*/

//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
string Calculator(int num, string binary)
{
    if(num<=1)
    {
        string d = Convert.ToString(num);
        binary = d+binary;
        return binary;
    }
    return Calculator(num / 2, Convert.ToString(num - 2 * (num/2)) + binary);
}
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
string bin = "";
Console.WriteLine("Number in binary system: " + Calculator(number,bin));

/*
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
int h1 = 1;
int h2 = 1;
    //Представил уравнения в другом виде:
    //k1*x - h1*y1 + b1 = 0;
    //k2*x - h2*y2 + b2 = 0;
    // double pCrossX = ((h1 * b2) - (h2 * b1)) / ((k1 * h2) - (k2 * h1)); 
    // double pCrossY = (k2 * b1 - k1 * b2) / (k1 * h2 - k2 * h1);
    // инфу по нахождению точек пересечения взял с сайта https://www.interestprograms.ru/source-codes-tochka-peresecheniya-dvuh-pryamyh-na-ploskosti
double num = (h1 * b2) - (h2 * b1);
double num1 = (k1 * h2) - (k2 * h1);
double pCrossX = (num / num1);

double number = (k2 * b1) - (k1 * b2);
double number1 = (k1 * h2) - (k2 * h1);
double pCrossY = (number / number1);

Console.Write("Кординаты точки перечесечения на оси X: " + pCrossX);
Console.WriteLine();
Console.Write("Кординаты точки перечесечения оси Y: " + pCrossY);
*/