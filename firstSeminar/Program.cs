// int num1 = 45; //только целые числа
// double bigNum = 12.23413; // любые числа
// bool isEven = true; // логическая переменная либо 1 либо 0
// string word = "flower"; // чито текстовая запись, символы могут быть любые
// char symbol = '%'; //хранит только какой-то символ

// int num2=12734;

// Console.WriteLine("My numbers are " + num1 +" and "+num2+" and its good");
// Console.WriteLine($"My numbers are {num1} and {num2} and its good");

// Console.Write("Input an integer number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Your number is "+num);

//Homework1

// Task 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.WriteLine("Input the first number: ");
int num1=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Input the second number: ");
int num2=Convert.ToInt16(Console.ReadLine());

int quad2=num2*num2;

if (num1==quad2)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}
*/



// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Input a positive number ");
int num=Convert.ToInt16(Console.ReadLine());

int current=-num;

while (current<=num) 
{
    Console.Write(current+" ");
    current=current+1;
}
*/

/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*
Console.WriteLine("Input the first number: ");
int num1=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Input the first number: ");
int num2=Convert.ToInt16(Console.ReadLine());

if (num1==num2)
{
    Console.WriteLine("Числа равны");
}
else
    if (num1>num2)
    {
        Console.WriteLine("Большее число "+num1);
        Console.WriteLine("Меньшее число "+num2);
    }
    else
    {
        Console.WriteLine("Большее число "+num2);
        Console.WriteLine("Меньшее число "+num1);
    }
*/



/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*
Console.WriteLine("Input the first number: ");
int num1=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Input the first number: ");
int num2=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Input the third number: ");
int num3=Convert.ToInt16(Console.ReadLine());
int max=num1;
if (max<num2)
    {max=num2;}
if (max<num3)
    {max=num3;}
Console.WriteLine("Наибольшее число "+max);
*/


/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/
/*
Console.Write("Введите число: ");
double num=Convert.ToDouble(Console.ReadLine());
if (num % 2>0)
{
    Console.WriteLine($"Число {num} - нечётное");
}
else
{
    Console.WriteLine($"Число {num} - чётное");
}
*/


/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/



Console.Write("Введите число: ");
int num=Convert.ToInt16(Console.ReadLine());
