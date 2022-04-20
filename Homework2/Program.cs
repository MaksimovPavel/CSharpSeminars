//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
void ShowNumber (int num)
{
    int firstNum = num / 10;
    int secondNum = firstNum % 10;

    Console.Write(num + " -> ");
    Console.Write(secondNum);
    
}
int num = new Random().Next(100, 999);
ShowNumber(num);


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void CounterOfDigits (int num)
{
int amountOfNumber = 0; 
int counter = num;
while (counter>0)
    {
    amountOfNumber++;
    counter = counter / 10;
    }

counter = 1;
int result = num;
    if (amountOfNumber > 2)
    {
        while (counter < amountOfNumber - 2 )
        {
            result = result /10;
            counter++;
        }
        Console.Write("Third number is: " + result %10);
    }   
    else
    {
        Console.Write("No third number");
    }
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
CounterOfDigits (num);



//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


void Weekdaycheck (int day)
{
if(day > 7 || day <1)
{
    Console.Write("Incorrect day");
}
else
{
    if(day == 6 || day == 7)
        Console.WriteLine("Woo-hoo it's weekend!");
    if(day == 1 || day == 2 || day == 3 || day == 4 || day == 5)
        Console.WriteLine("It's a weekday");
}
}
Console.Write("Input number of weekday: ");
int day = Convert.ToInt32(Console.ReadLine());
Weekdaycheck (day);

*/