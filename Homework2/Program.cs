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

void ShowNumber (int num)
{
    if (num >= 100 && num <1000)
    {
    int n = num % 10;    
    Console.Write(num + " -> ");
    Console.Write(n);
    }
    if (num >= 1000 && num <= 9999)
    {
    int n = num / 10 % 10;    
    Console.Write(num + " -> ");
    Console.Write(n);
    }
    if (num >= 10000 && num <= 99999)
    {
    int n = num / 10 % 10;    
    Console.Write(num + " -> ");
    Console.Write(n);
    }
    else
    {
        Console.Write("No third number");
    }
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNumber(num);

*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
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
    

