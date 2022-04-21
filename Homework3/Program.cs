/*
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void polindrom (int number)
{
    int num = number;
    int num1 = num / 10000;
    int num2 = num / 1000 % 10;
    int num4 = num / 10 % 10;
    int num5 = num % 10;
    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine("Число палиндром");
    }
    else
    {
        Console.WriteLine("Число не палиндром");
    }
}
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
polindrom(num);


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double DotDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
}
// Первая точка
Console.WriteLine("Введите координату x первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
// Вторая точка
Console.WriteLine("Введите координату x второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Расстояние между точками = " + Sqrt(x1,y1,z1,x2,y2,z2));


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

void CubNumber(int N)
{
    int count = 1;
    Console.Write(N + "-> ");
    while (count <= N)
    {
        Console.Write(count*count*count + " ");
        count++;
    }
}

Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num >0)
    CubNumber(num);
else
    Console.Write("Введите положительное число!");

*/
