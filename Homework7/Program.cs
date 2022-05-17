//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
/*
double [,]CreateRandomArray(int m,int n)
{
    double[,] array = new double [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().NextDouble()*100 - 10;
            Console.Write("{0,6:F2}", array[i,j]);
        }
        Console.WriteLine();
    }       
    return array;
}
Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m <= 0 || n <= 0)
{
    Console.Write("Inccorect number!");
}
else CreateRandomArray(m,n);

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void FindElementInArray(int [,] array)
{
    Console.Write("Input element horizontal position: ");
    int x = Convert.ToInt32(Console.ReadLine())-1;
    Console.Write("Input element vertical position: ");
    int y = Convert.ToInt32(Console.ReadLine())-1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (x < 0 | x > array.GetLength(0) - 1 | y < 0 | y > array.GetLength(1) - 1)
                {
                    Console.WriteLine("Элемент не существует");
                }
            else
            {
                Console.WriteLine("Значение элемента массива = {0}", array[x, y]);
            }
            Console.ReadLine();  
            
        }
              
    }
}
int [,] matrix = new int [10,10];
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j<matrix.GetLength(1); j++)
    {
        matrix [i,j] = new Random().Next(0,10);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
FindElementInArray(matrix);
*/

void FindElementInArray (int [,] array)
{
    Console.Write("Input element horizontal position: ");
    int x = Convert.ToInt32(Console.ReadLine()) -1; // вычетаем 1, т.к. пользователь вводит позицию элемента, начиная с 1, а не 0.
    Console.Write("Input element vertical position: ");
    int y = Convert.ToInt32(Console.ReadLine()) -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (x < 0 | x > array.GetLength(0) - 1 | y < 0 | y > array.GetLength(1) - 1)
        {
            Console.WriteLine("No element in array!");
        }
        else
        {
            Console.WriteLine("Requested element = " + array[x, y]);
            break;
        }   
    }
}

Console.Write("Input number of strings: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [str,rows];
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix [i,j] = new Random().Next(0,10);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
FindElementInArray(matrix);


