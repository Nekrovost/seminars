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

Console.Write("Input a positive number ");
int num=Convert.ToInt16(Console.ReadLine());

int current=-num;

while (current<=num) 
{
    Console.Write(current+" ");
    current=current+1;
}


