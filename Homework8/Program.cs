//Задайте двумерный массив. 
//Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

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
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < arr.GetLength(1); k++) 
                {
                    if (arr[i,j] > arr[i,j+1])
                    {
                        int temp = arr[i,j];
                        arr[i,j] = arr[i,j+1];
                        arr[i,j+1] = temp;
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


