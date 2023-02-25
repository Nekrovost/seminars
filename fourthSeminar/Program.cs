// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int sum(int a)
{
    int sum=0;
    for(int count=0; count<a; count++)
    {
        sum=sum+count;
    }
    Console.WriteLine(sum);
    return sum;
}


Console.Write("Введите число А: ");
int sum1=Convert.ToInt32(Console.ReadLine());
sum(sum1);
*/

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int lenght(int num)
{
    int a=0;
    for(int ten=10; num>0; a++)
    {
        num=num/ten;
    }
    return a;
}

Console.Write("Write your number, honey: ");
int myNumber=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"It's your number, honey {myNumber} and this lenght number {lenght(myNumber)}");
*/

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int proizvedenie(int num)
{
    int a=1;
    for(int b=1; b<=num; b++)
    {
        a=a*b;
    }
    return a;
}

Console.Write("Write your number, honey: ");
int myNumber=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"It's your number, honey {myNumber} and this proizvedenie number {proizvedenie(myNumber)}");\
*/





// Заполнение и создание массива
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

Console.Write("Введите кол-во элементов для массива: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента для массива: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента для массива: ");
int max=Convert.ToInt32(Console.ReadLine());

int[] newArray=createRandomArray(size, min, max);
printArray(newArray);
*/


//My HOMEWORK

//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int stepen(int a, int b)
{
    int c=a;
    for(int i=1; i<b; i++)
    {
        a=a*c;
    }
    Console.WriteLine(a);
    return a;
}

Console.Write("Введите первое число: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b=Convert.ToInt32(Console.ReadLine());

stepen(a, b);
*/



// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int dlina(int num)
{
    int i=0;
    while( num>0)
    {
        num=num/10;
        i++;
    }
    return i;
}
int sum(int num, int lenght)
{
    int ten=10;
    int sum1=0;
    int a=0;
    for(int i=0; i<lenght; i++)
    {
        a=num%ten;
        num=num/ten;
        sum1=sum1+a;
    }
    Console.WriteLine(sum1);
    return sum1;
}

Console.Write("Введите число: ");
int chislo=Convert.ToInt32(Console.ReadLine());
int b=dlina(chislo);
sum(chislo, b);
*/



// Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] createArray(int size)
{
    int[] array=new int[size];
    for(int i=0; i<size; i++)
    {
        Console.Write($"Введите {i+1} число массива: ");
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void printArray(int[] array)
{
    for(int i=0; i<array.Length; i++)   // последняя фигня это как раз размер массива
    Console.Write(array[i]+" ");

    Console.WriteLine();
}
Console.Write("Введите кол-во элементов для массива: ");
int size=Convert.ToInt32(Console.ReadLine());
int[] newArray=createArray(size);
printArray(newArray);
*/