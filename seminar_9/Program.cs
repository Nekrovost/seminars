// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void showNums(int num)
{
    if(num>1)
    showNums(num-1);
    Console.WriteLine(num+"");
}
showNums(5);
*/


// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр
/*
int sumNum(int num)
{
    if(num/10!=0)
    return sumNum(num/10)+num%10;
    return num;
}

Console.WriteLine(sumNum(-1234));
*/

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void showNums(int m, int n)
{
    if(m<n)
    {
    Console.WriteLine(m+" "); 
    showNums(m+1, n);
    }  
    if(m>n)
    {
    Console.WriteLine(m+" "); 
    showNums(m-1, n);        
    }
}
showNums(10, 5);
*/


// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
/*
double step(double a, double b)
{
    double num=a;
    if(b!=1)
    return step(num*a, b-1);
    return num;
}
Console.WriteLine(step(10, 2));
*/


// HOMEWORK

// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void showNums(int num)
{
    Console.WriteLine(num+"");
    if(num>1)
    showNums(num-1);
    if(num<1)
    showNums(num+1);
}
Console.Write("Введите число N: ");
int chislo=Convert.ToInt32(Console.ReadLine());
showNums(chislo);
*/

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int summaChisel(int m, int n)
{
    if(m==n) return m;
    else
    {
        if(m<n)
        {
        return summaChisel(m+1, n)+m;
        }
        else
            {
                return summaChisel(m-1, n)+m;
            }
    }
}

Console.Write("Введите первое число: ");
int chislo1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int chislo2=Convert.ToInt32(Console.ReadLine());
int summa=summaChisel(chislo1, chislo2);
Console.WriteLine($"Сумма чисел от {chislo1} до {chislo2} равна {summa}");
*/

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int mikasa(int m, int n)
{
    if(m==0) return n+1;
    else
    {
        if(n==0) return mikasa(m-1,1);
        else
        return mikasa(m-1, mikasa(m, n-1));
    }
}

Console.Write("Введите первое число: ");
int chislo1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int chislo2=Convert.ToInt32(Console.ReadLine());
int akerman=mikasa(chislo1, chislo2);
Console.WriteLine(akerman);  // не понял прикола, почему у 4,5 не выводится, пишет что-то про защиту стека...
*/