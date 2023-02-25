// Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
/*
int[] createRandomArray(int size, int minValue, int maxValue)
{
    int[] array=new int[size];  // задали массив где определили размер size

    for(int i=0; i<size; i++)
    {
        array[i]=new Random().Next(minValue, maxValue+1); // заполнили рандомными числами
    }
    return array;
}

void printArray(int[] array)
{
    for(int i=0; i<array.Length; i++)   // последняя фигня это как раз размер массива
    Console.Write(array[i]+" ");

    Console.WriteLine();
}

int sumNegative(int[] array)
{
    int sum=0;
    for(int i=0; i<array.Length; i++)
    {
        if (array[i]<0)
        {
            sum=sum+array[i];
        }
    }
    return sum;
}

Console.Write("Введите кол-во элементов для массива: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента для массива: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента для массива: ");
int max=Convert.ToInt32(Console.ReadLine());

int[] newArray=createRandomArray(size, min, max);
printArray(newArray);
Console.WriteLine(sumNegative(newArray));
*/




// Напишите программу заменs элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] createRandomArray(int size, int minValue, int maxValue)
{
    int[] array=new int[size];  // задали массив где определили размер size

    for(int i=0; i<size; i++)
    {
        array[i]=new Random().Next(minValue, maxValue+1); // заполнили рандомными числами
    }
    return array;
}

void printArray(int[] array)
{
    for(int i=0; i<array.Length; i++)   // последняя фигня это как раз размер массива
    Console.Write(array[i]+" ");

    Console.WriteLine();
}

void revers(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        array[i]=array[i]*(-1);
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

Console.Write("Введите кол-во элементов для массива: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента для массива: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента для массива: ");
int max=Convert.ToInt32(Console.ReadLine());
int[] newArray=createRandomArray(size, min, max);
printArray(newArray);
revers(newArray);
*/




// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int[] createRandomArray(int size, int minValue, int maxValue)
{
    int[] array=new int[size];  // задали массив где определили размер size

    for(int i=0; i<size; i++)
    {
        array[i]=new Random().Next(minValue, maxValue+1); // заполнили рандомными числами
    }
    return array;
}

void printArray(int[] array)
{
    for(int i=0; i<array.Length; i++)   // последняя фигня это как раз размер массива
    Console.Write(array[i]+" ");

    Console.WriteLine();
}

void count(int[] array, int num)
{
    int a=0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]==num && a<1)
        a++;
    }
    if(a>0)
    Console.WriteLine("Тут есть твоё число");
    else
    Console.WriteLine("Иди нахер");
}

Console.Write("Введите кол-во элементов для массива: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента для массива: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента для массива: ");
int max=Convert.ToInt32(Console.ReadLine());
int[] newArray=createRandomArray(size, min, max);
printArray(newArray);
Console.Write("Введите число, которое необходимо найти в массиве: ");
int num=Convert.ToInt32(Console.ReadLine());
count(newArray, num);
*/



// Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
/*
int[] createRandomArray(int size, int minValue, int maxValue)
{
    int[] array=new int[size];  // задали массив где определили размер size

    for(int i=0; i<size; i++)
    {
        array[i]=new Random().Next(minValue, maxValue+1); // заполнили рандомными числами
    }
    return array;
}

void printArray(int[] array)
{
    for(int i=0; i<array.Length; i++)   // последняя фигня это как раз размер массива
    Console.Write(array[i]+" ");

    Console.WriteLine();
}

int summaHuyma(int[] array, int a, int b)
{
    int sum=0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]>=a && array[i]<=b)
        {
            sum=sum+array[i];
        }
        else
        {
            sum=sum+0;
        }
    }
    return sum;
}

Console.Write("Введите кол-во элементов для массива: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента для массива: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента для массива: ");
int max=Convert.ToInt32(Console.ReadLine());
int[] newArray=createRandomArray(size, min, max);
printArray(newArray);
Console.Write("Введите минимальное значение из отрезка: ");
int a1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение из отрезка: ");
int b1=Convert.ToInt32(Console.ReadLine());
int result=summaHuyma(newArray, a1, b1);
Console.WriteLine(result);
*/




// MY HOMEWORK

// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
bool proverka(int minValue, int maxValue)
{
    if(minValue>99 && minValue<1000 && maxValue>99 && maxValue<1000 && minValue<maxValue)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int[] createRandomArray(int size, int minValue, int maxValue)
{
    int[] array=new int[size];

    for(int i=0; i<size; i++)
    {
        array[i]=new Random().Next(minValue, maxValue+1);
    }
    return array;
}

void printArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    Console.Write(array[i]+" ");

    Console.WriteLine();
}

int schet(int[] array)
{
    int a=0;
    for(int i=0; i<array.Length; i++)
    {
        if (array[i]%2==0)
        {
            a++;
        }
        else
        {
            a=a+0;
        }
    }
    return a;
}

Console.Write("Введите кол-во элементов для массива: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное трёхзначное значение элемента для массива: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное трёхзначное значение элемента для массива: ");
int max=Convert.ToInt32(Console.ReadLine());

bool result=proverka(min, max);

if(result)
{
    int[] newArray=createRandomArray(size, min, max);
    printArray(newArray);
    int otvet=schet(newArray);
    Console.WriteLine("Колличество чётных чисел в массиве "+otvet);
}
else
{
    Console.WriteLine("Нецензурная брань, введите трёх значные числа в правильном порядке");
}
*/


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] createRandomArray(int size, int minValue, int maxValue)
{
    int[] array=new int[size];

    for(int i=0; i<size; i++)
    {
        array[i]=new Random().Next(minValue, maxValue+1);
    }
    return array;
}

void printArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    Console.Write(array[i]+" ");

    Console.WriteLine();
}

int summa(int[] array)
{
    int sum=0;
    for(int i=1; i<array.Length; i=i+2)
    {
        sum=sum+array[i];
    }
    return sum;
}

Console.Write("Введите кол-во элементов для массива: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента для массива: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента для массива: ");
int max=Convert.ToInt32(Console.ReadLine());
int[] masive=createRandomArray(size, min, max);
printArray(masive);
int summarno=summa(masive);
Console.WriteLine("Сумма всех элементов нечётных позиций - "+summarno);
*/


// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
int[] createRandomArray(int size, int minValue, int maxValue)
{
    int[] array=new int[size];

    for(int i=0; i<size; i++)
    {
        array[i]=new Random().Next(minValue, maxValue+1);
    }
    return array;
}

void printArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    Console.Write(array[i]+" ");

    Console.WriteLine();
}

int minimum(int[] array, int minValue, int maxValue)
{
    int min=maxValue;
    int max=minValue;
    for(int i=0; i<array.Length; i++)
    {
        if(min>array[i])
        min=array[i];
    }
    return min;
}
int maximum(int[] array, int minValue, int maxValue)
{
    int min=maxValue;
    int max=minValue;
    for(int i=0; i<array.Length; i++)
    {
        if(max<array[i])
        max=array[i];
    }
    return max;
}

Console.Write("Введите кол-во элементов для массива: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента для массива: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента для массива: ");
int max=Convert.ToInt32(Console.ReadLine());

int[] newArray=createRandomArray(size, min, max);
printArray(newArray);

int a=minimum(newArray, min, max);
int b=maximum(newArray, min, max);
Console.WriteLine($"Ловите разницу между минимальным {a} и максимальным {b} элементами массива. Ответ: {b-a}");
*/