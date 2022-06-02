//Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
/*

int SumOfDiagonal(int[,] quad)
{
    int sum = 0;

    for(int i = 0; i < quad.GetLength(0); i++)
    {
        sum += quad[i,i];
    }

    return sum;
}


Console.Write("Input size of matrix: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[size,size];

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(SumOfDiagonal(matrix));
*/

//Задача 47. Задайте двумерный массив размером m×n,
//     заполненный случайными вещественными числами.
/*
Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m,n];

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().NextDouble();
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//           и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
Console.Write("Input size of matrix: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[size,size];

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
Console.Write("Input I: ");
int I = Convert.ToInt32(Console.ReadLine());
Console.Write("Input J: ");
int J = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(matrix.GetValue(I, J));
*/
//Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
int Sred(int[,] quad)
{
    int sum = 0;

    for(int i = 0; i < quad.GetLength(0); i++)
    {
        sum = 0;
        for(int j = 0; j < quad.GetLength(0); j++)
            sum += quad[i, j];
        double Sr = sum / quad.GetLength(0);
        Console.WriteLine(Sr);
    }
    
}


Console.Write("Input size of matrix: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[size,size];

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(Sred(matrix));