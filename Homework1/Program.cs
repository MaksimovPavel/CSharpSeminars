/* Задача 1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input integer number 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Input integer number 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB)
{
    Console.WriteLine("Max = " + numberA);
}
else
{
    Console.WriteLine("Max = " + numberB);
}

*/
//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input integer number 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer number 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer number 3: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;

if(numberA > max) max = numberA;
if(numberB > max) max = numberB;
if(numberC > max) max = numberC;
{
    Console.WriteLine("Max = " + max);
}
