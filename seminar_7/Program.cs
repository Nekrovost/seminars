// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
int[,] createRandome2dArray(int rows, int cols, int minValue, int maxValue)
{
    int[,] array=new int[rows, cols];

    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<cols; j++)
        {
            array[i,j]=new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
}

void show2dArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите кол-во строк: ");
int rows=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int cols=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите минимальное значение элемента матрицы: ");
int minValue=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите максимальное значение элемента матрицы: ");
int maxValue=Convert.ToInt16(Console.ReadLine());
int[,] newArray=createRandome2dArray(rows, cols, minValue, maxValue);
show2dArray(newArray);
*/


// Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
// по формуле: Aij = i + j. Выведите полученный массив на экран.
/*
int[,] massiv(int rows, int cols)
{
    int[,] array=new int[rows, cols];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<cols; j++)
        {
            array[i,j]=i+j+2;
        }
    }
    return array;
}
void show2dArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк: ");
int a=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int b=Convert.ToInt16(Console.ReadLine());
int[,] newArray=massiv(a, b);
show2dArray(newArray);
*/

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.
/*
int[,] createRandome2dArray(int rows, int cols, int minValue, int maxValue)
{
    int[,] array=new int[rows, cols];

    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<cols; j++)
        {
            array[i,j]=new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
}

void show2dArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] qaud(int[,] array)
{
    int i1=array.GetLength(0);
    int j1=array.GetLength(1);
    for(int i=0; i<i1; i++)
        {
            for(int j=0; j<j1; j++)
            {
                if((i+j)%2==0)
                {
                array[i,j]=array[i,j]*array[i,j];
                }
            }
        }
    return array;
}

Console.Write("Введите кол-во строк: ");
int rows=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int cols=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите минимальное значение элемента матрицы: ");
int minValue=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите максимальное значение элемента матрицы: ");
int maxValue=Convert.ToInt16(Console.ReadLine());
int[,] newArray=createRandome2dArray(rows, cols, minValue, maxValue);
show2dArray(newArray);
qaud(newArray);
show2dArray(newArray);
*/

// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной
// диагонали (с индексами (0,0); (1;1) и т.д.
/*
int[,] createRandome2dArray(int rows, int cols, int minValue, int maxValue)
{
    int[,] array=new int[rows, cols];

    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<cols; j++)
        {
            array[i,j]=new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
}

void show2dArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

int diagonal(int[,] array)
{
    int sum=0;
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            if(i==j)
            {
                sum=sum+array[i,j];
            }
        }
    }
    return sum;
}

Console.Write("Введите кол-во строк: ");
int rows=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int cols=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите минимальное значение элемента матрицы: ");
int minValue=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите максимальное значение элемента матрицы: ");
int maxValue=Convert.ToInt16(Console.ReadLine());
int[,] newArray=createRandome2dArray(rows, cols, minValue, maxValue);
show2dArray(newArray);
Console.WriteLine(diagonal(newArray));
*/




// HOMEWORK


//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
int[,] createRandome2dArray(int rows, int cols, int minValue, int maxValue)
{
    int[,] array1=new int[rows, cols];
    int[,] array2=new int[rows, cols];

    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<cols; j++)
        {
            array1[i,j]=new Random().Next(minValue, maxValue+1);
            array2[i,j]=new Random().NextDouble();
            array1[i,j]=array1[i,j]+array2[i,j];
        }
    }
    return array1;
}

void show2dArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите кол-во строк: ");
int rows=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int cols=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите минимальное значение элемента матрицы: ");
int minValue=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите максимальное значение элемента матрицы: ");
int maxValue=Convert.ToInt16(Console.ReadLine());
int[,] newArray=createRandome2dArray(rows, cols, minValue, maxValue);
show2dArray(newArray);
*/


// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
// Тут не было сказано, что мы сами задаём массив, но я его +- задал так, чтобы никто не знал какие элементы там есть. Рекомендую тыкать на удачу)))))
int[,] createRandome2dArray()
{
    int  rows=new Random().Next(1, 10);
    int  cols=new Random().Next(1, 10);
    int[,] array1=new int[rows, cols];
    int[,] array2=new int[rows, cols];

    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<cols; j++)
        {
            array1[i,j]=new Random().Next(-1000, 1000);
        }
    }
    return array1;
}

void show2dArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

void element(int[,] array, int a, int b)
{
    if(a>array.GetLength(0) || b>array.GetLength(1) || a<1 || b<1)
    {
        Console.WriteLine("Не повезло, не фортануло. Элемента с такими значениями нет");
    }
    else
    {
        Console.WriteLine($"{array[a-1, b-1]} - число из массива с позицией [{a},{b}]");
    }
}

Console.Write("Введите первое число: ");
int num1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2=Convert.ToInt32(Console.ReadLine());
int[,] newArray=createRandome2dArray();
show2dArray(newArray);
element(newArray, num1, num2);
*/

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] createRandome2dArray(int rows, int cols, int minValue, int maxValue)
{
    int[,] array=new int[rows, cols];

    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<cols; j++)
        {
            array[i,j]=new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
}

void show2dArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

void arifmet(int[,] array)
{
    for(int j=0; j<array.GetLength(1); j++)
    {
        double sum=0;
        for(int i=0; i<array.GetLength(0); i++)
        {
            sum=sum+array[i,j];
        }
        Console.WriteLine($"{sum/array.GetLength(0)} - это сумма {j+1} столбца");
    }
}

Console.Write("Введите кол-во строк: ");
int rows=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int cols=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите минимальное значение элемента матрицы: ");
int minValue=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите максимальное значение элемента матрицы: ");
int maxValue=Convert.ToInt16(Console.ReadLine());
int[,] newArray=createRandome2dArray(rows, cols, minValue, maxValue);
show2dArray(newArray);
arifmet(newArray);
*/