//Задайте двумерный массив. 
//Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
/*
int[,] CreateRandomArray(int n, int m)
{
    int[,] array = new int [n,m];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,100);
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(array[i,j] + " "); 
        }
        Console.WriteLine();
    }
    Console.WriteLine(); 
}
int [,] ReplaceArrayElements (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = j + 1; k < arr.GetLength(1); k++) 
                {
                    if (arr[i,j] > arr[i,k])
                    {
                        int temp = arr[i,j];
                        arr[i,j] = arr[i,k];
                        arr[i,k] = temp;
                    }
                }
        }
    }
    return arr;
}
Console.Write("Input number of strings: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandomArray(n,m);
ShowArray(myArray);
ShowArray(ReplaceArrayElements(myArray));

// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] CreateRandomArray()
{
    int[,] array = new int [4,3];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(array[i,j] + " "); 
        }
        Console.WriteLine();
    }
    Console.WriteLine(); 
}

void FindMinString (int [,] array)
{
    int sum = int.MaxValue;
    int index = 0;
    for (int i = 0; i < 4; i++)
    {
        int temp = 0;
        for (int j = 0; j < 3; j++)
        {
            temp += array[i,j];
        }
        if (temp < sum)
        {
            sum = temp;
            index = i;
        }
    }
    Console.WriteLine("Наименьшая строка: " + index + " Сумма - " + sum);
    Console.WriteLine();
    for (int i = 0; i < 3; i++)
    {
        Console.Write(array[index,i] + " ");
    }
}

int[,] myArray = CreateRandomArray();
ShowArray(myArray);
FindMinString(myArray);
*/

//Заполните спирально массив 4 на 4.


int[,] array = new int[4, 4];

FillArraySnail(array);
PrintArray(array);

void FillArraySnail(int[,] array)
{
    int directionRight = 0,
        directionLeft = 1,
        directionUp = 3,
        directionDown = 4,
        direction = directionRight,
        row = 0,
        column = 0,
        stepRow = 0,
        stepColumn = 1,
        minRow = 1,
        maxRow = array.GetLength(0) - 1,
        minColumn = 0,
        maxColumn = array.GetLength(1) - 1;

    for (int step = 1; step <= array.Length; step++)
    {
        array[row, column] = step;
        if (direction == directionRight && column == maxColumn)
        {
            maxColumn--;
            direction = directionDown;
            stepRow = 1;
            stepColumn = 0;
        }
        else if (direction == directionDown && row == maxRow)
        {
            maxRow--;
            direction = directionLeft;
            stepRow = 0;
            stepColumn = -1;
        }
        else if (direction == directionLeft && column == minColumn)
        {
            minColumn++;
            direction = directionUp;
            stepRow = -1;
            stepColumn = 0;
        }
        else if (direction == directionUp && row == minRow)
        {
            minRow++;
            direction = directionRight;
            stepRow = 0;
            stepColumn = 1;
        }
        row += stepRow;
        column += stepColumn;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}
