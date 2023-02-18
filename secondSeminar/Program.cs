// SEMINAR

// Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.
/*
int CutNumber(int number)
{
    int hundreds=number/100;
    int units=number%10;
    int result=hundreds*10+units;
    return result;
}

int RandNumber= new Random().Next(100,999);
int newNumber=CutNumber(RandNumber);
Console.WriteLine($"new version of {RandNumber} is {newNumber}");
*/



// Напишите программу, которая принимает на вход число и 
// проверяет, кратно ли оно одновременно a и b.
/*
bool IsMultiplyed(int num,int a, int b)
{
    if (num % a==0 && num % b==0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Введите число для проверки: ");
int num=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите первый делитель: ");
int a=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите второй делитель: ");
int b=Convert.ToInt16(Console.ReadLine());

bool result=IsMultiplyed(num, a, b);
if (result)
{
    Console.WriteLine($"Ваше число {num} делится на {a} и {b}");
}
else
{
    Console.WriteLine($"Ваше число {num} не делится на {a} и {b}");
}
*/



// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
/*
int MaxNumber(int num)
{
    int a=num%10;
    int b=num/10;
    if (a>b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
int RandNumber=new Random().Next(10,99);
Console.WriteLine(RandNumber);
int number=MaxNumber(RandNumber);
Console.WriteLine($"В числе {RandNumber} самое большое число {number}");
*/

// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
/*
bool squad(int a, int b)
{
    if(a==b*b || b==a*a)
    return true;
    else
    return false;
}
Console.Write("Введите первое число: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b=Convert.ToInt32(Console.ReadLine());
bool result=squad(a, b);
if (result)
{
    Console.WriteLine("Одно из чисел является квадратом другого");
}
else
{
    Console.WriteLine("Числа не являются квадратами друг друга");
}
*/


// HOMEWORK

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondNumber(int num)
{
    int a=(num-num % 10)/10;
    int b=a%10;
    return b;
}
Console.Write("Введите трёхзначное число: ");
int chislo=Convert.ToInt32(Console.ReadLine());
if (chislo>99 && chislo<1000)
{
    int answer=SecondNumber(chislo);
    Console.WriteLine($"Вы ввели число {chislo} его второй разряд равен {answer}");
}
else
{
    Console.WriteLine("Вы ввели не трёхзначное число.");
    Console.WriteLine("При следующем запуске программы введите трёхзначное число");
}
*/




// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
int ThirdNumber(int num)
{
    int lenght=0;
    int num1=num;
    while (num1>0)
    {
        num1=num1/10;
        lenght=lenght+1;
    }
    while (lenght-3>0)
    {
        num=num/10;
        lenght=lenght-1;
    }
    int result=num%10;
    return result;
}
Console.Write("Введи число: ");
int chislo=Convert.ToInt32(Console.ReadLine());
if (chislo>99)
{
    int answer=ThirdNumber(chislo);
    Console.WriteLine($"Вы ввели число {chislo}, его третий разряд слева равен {answer}");
}
else
{
    Console.WriteLine("Error. При запуске программы необходимо было ввести число, в котором три и более разрядов.");
}
*/






// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool WorkOrNotWork(int num)
{
    if (num>5)
    return true;
    else
    return false;
}
Console.Write("Введите число, обозначающее день недели: ");
int chislo=Convert.ToInt32(Console.ReadLine());
bool answer=WorkOrNotWork(chislo);
if (chislo>7)
    Console.WriteLine("День недели не может привышать семи");
else
    if (answer)
        Console.WriteLine("Выходной");
    else
        Console.WriteLine("Не выходной");
*/