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
*/
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

    int[] array = new int [10];
    int result = 0;
    int num = number;
    while (num> 0)
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
    for (int i = 0; i < 10; i++)
    {
        Console.Write(array[i] + "");
    }
}
ShowArray(array);

int[] NewArray(int[] array)
{
    int newSize = array.Length;
    int[] newArray = new int[newSize];

    for (int i = 0, j = array.Length; i < newSize; i++, j--)
    {
        newArray[i] = array[j];
    }
    return NewArray;
}
int[] newArray = new int [10];
ShowArray(newArray);