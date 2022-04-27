//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
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


