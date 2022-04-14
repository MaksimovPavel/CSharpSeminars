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