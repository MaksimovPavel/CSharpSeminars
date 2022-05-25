//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
/*
NaturalNums(3,7);
void NaturalNums(int n, int m)
{
    if( n <= m)
    {
        NaturalNums(n, m - 1);
        Console.Write(m + " ");
    }
}
*/
//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр

int digitsSum(int number)
{
    int sum = 0;
    if(number==0) 
    return 0;
    else sum = number % 10 + digitsSum(number/10);
    return sum;
}
Console.Write("Input number: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write(digitsSum(numA));
