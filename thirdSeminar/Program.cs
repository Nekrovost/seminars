﻿// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void ShowDiapozone(int quad)
{
    if(quad==1) 
        Console.WriteLine("x>0 and y>0");
    else
        if (quad==2)
            Console.WriteLine("x<0 and y>0");
        else
            if (quad==3)
                Console.WriteLine("x<0 and y<0");
            else
                if (quad==4)
                    Console.WriteLine("x>0 and y<0");
                else
                Console.WriteLine("Uncorrect input");
}

Console.Write("Введи номер четверти: ");
int quadrant=Convert.ToInt32(Console.ReadLine());
ShowDiapozone(quadrant);
*/


// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int chetvert(int x, int y)
{
    if (x==0 || y==0 || (x==0 && y==0))
        Console.WriteLine("Error");
    else
        if (x>0 && y>0)
            Console.WriteLine("Первая четверть");
        else
            if (x<0 && y>0)
                Console.WriteLine("Вторая четверть");
            else
                if(x<0 && y<0)
                    Console.WriteLine("Третья четверть");
                else
                    if(x>0 && y<0)
                        Console.WriteLine("Четвёртая четверть");
    return x;
    return y;
}

Console.Write("Введите х координату: ");
int x=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите у координату: ");
int y=Convert.ToInt32(Console.ReadLine());

chetvert(x,y);
*/



//  Напишите программу, которая принимает на вход координаты
//  двух точек и находит расстояние между ними в 2D пространстве.
/*
double distance(double x1, double y1, double x2, double y2)
{
    double distance1=x1-x2;
    double distance2=y1-y2;
    double distance3=distance1*distance1+distance2*distance2;
    double distance4=Math.Sqrt(distance3);
    Console.WriteLine("Расстояние между точками "+distance4);
    return distance4; 
}

Console.Write("Введите координату х1: ");
double x1=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату у1: ");
double y1=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату х2: ");
double x2=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату у2: ");
double y2=Convert.ToDouble(Console.ReadLine());
distance(x1, y1, x2, y2);
*/


//  Напишите программу, которая принимает на вход число (N) 
//  и выдаёт таблицу квадратов чисел от 1 до N.

/*
void quad( int n)
{
    int m=1;
        while (m<n+1)
            {Console.WriteLine(m+" - "+(m*m));
            m=m+1;}
}

Console.Write("Введите число N: ");
int N=Convert.ToInt32(Console.ReadLine());
quad(N);
*/




// HOMEWORK



// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (Сказали для числа произвольной длинны)
/* ---- херня, не работает, без понятия как массив вытащить из функции плюс где-то точно есть ошибка, ниже нормальное решение будет
int dlina(int num)
{
    int lenght=0;
    int full=num;
    while (num>0)
    {
       num=num/10;
       lenght++;
    }
    return lenght;
}
int elements(int array)
{
   int ten=10;
   int[] array=new int[lenght];
   int nulik=0;
   while(nulik<lenght-1)
   {
    array[nulik]=(full/Math.Pow(ten,nulik))%ten;
    nulik++;
   }
   return array;
}
void chet(int array)
{
    int m=0;
    while (m<lenght-1)
    {
        if(array[m]==array[lenght-1])
        {m++;
        lenght=lenght-1;}
        else
        m=lenght*10;
    }
    if(m<lenght)
    return true;
    else
    return false;
}
void neChet(int array)
{
    int m=0;
    int dlina=lenght;
    while (m<=(lenght-1)/2)
    {
        if(array[m]=array[dlina-1])
        {m++;
        dlina--;}
        else
        m=lenght*10;
    }
    if(m<lenght)
    return true;
    else
    return false;
}

Console.Write("Введите число N: ");
int N=Convert.ToInt32(Console.ReadLine());
int lenght=dlina(N);
int[] array= new int[lenght]; 
array=elements(N);
if (lenght%2==0)
     chet(array);
else
    neChet(array);
*/

/*    // намучился как незнамо кто, чувствую что дальше мне дороги нет
int opOpRazvorot(int num)
{
    int lenght=0;
    int full=num;
    while (full>0)
    {
       full=full/10;
       lenght++;
    }
    int count=0;
    int c=lenght;
    int a=0;
    double b=0;
    while(count<lenght)
    {
        a=num%10;
        num=num/10;
        b=b+a*Math.Pow(10,c-1); // в цикл надо эту ... завернуть, а то так получаем тип дабл (забиваем нашёл как сделать)
        c=c-1;
        count++;
               Console.WriteLine(b);
    }
    int e=Convert.ToInt32(b);
    return e;
}
bool sravnenie(int num, int reversNum)
{
    if(num==reversNum)
    return true;
    else
    return false;
}

Console.Write("Введите число N: ");
int N=Convert.ToInt32(Console.ReadLine());
int reversNum=opOpRazvorot(N);
bool result=sravnenie(N, reversNum);
if (result)
Console.Write($"Число {N} является палиндромом");
else
Console.Write($"Число {N} не является палиндромом");
*/



// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance1=x1-x2;
    double distance2=y1-y2;
    double distance3=z1-z2;
    double distance4=Math.Sqrt(distance1*distance1+distance2*distance2+distance3*distance3);
    Console.WriteLine("Расстояние между двумя точками равно "+distance4);
    return distance4;
}
Console.Write("Введите координату х1: ");
double x1=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату у1: ");
double y1=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z1: ");
double z1=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату х2: ");
double x2=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату у2: ");
double y2=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z2: ");
double z2=Convert.ToDouble(Console.ReadLine());
distance(x1, y1, z1, x2, y2, z2);
*/



// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void cube(int n)
{
    int num=1;
    while (num<=n)
    {
        Console.WriteLine(num+" - "+(num*num*num));
        num++;
    }
}

Console.Write("Введите число: ");
int chislo=Convert.ToInt32(Console.ReadLine());
cube(chislo);
*/