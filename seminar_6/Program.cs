// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
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

void reversArray(int[] array)
{
    for(int i=0, j=array.Length-1; i<j; i++, j--)
    {
        int temp=array[i];
        array[i]=array[j];
        array[j]=temp;
    }
}

Console.Write("Введите кол-во элементов для массива: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента для массива: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента для массива: ");
int max=Convert.ToInt32(Console.ReadLine());
int[] newArray=createRandomArray(size, min, max);
printArray(newArray);
reversArray(newArray);
printArray(newArray);
*/


// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины. bool
/*
bool tre(int a, int b, int c)
{
    if(a+b<c || b+c<a || a+c<b)
    return false;
    else
    return true;
}
Console.Write("Введите длину первой стороны: ");
int a1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину второй стороны: ");
int b1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину третей стороны: ");
int c1=Convert.ToInt32(Console.ReadLine());

bool result=tre(a1, b1, c1);
if(a1>0 && b1>0 && c1>0)
{
    if (result)
    Console.WriteLine("Это треугольник (Отсылка на роддом (У вас мальчик/девочка))");
    else
    Console.WriteLine("Не повезло не фортануло, но это не треугольник");
}
else
Console.WriteLine("Ты дебил, дебил, дебилище, вводи положительные числа");
*/


// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: a и b. void
/*
// без проверок, было лень
int[] fib(int N, int a, int b)
{
    int[] array=new int[N+2];
    array[0]=a;
    array[1]=b;
    for(int i=0; i<N; i++)
    {
        array[i+2]=array[i]+array[i+1];
    }
    return array;
}
void printArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    Console.Write(array[i]+" ");

    Console.WriteLine();
}
Console.Write("Введите длину фиб: ");
int N1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первый элемент: ");
int a1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй элемент: ");
int b1=Convert.ToInt32(Console.ReadLine());
int[] newArray=fib(N1, a1, b1);
printArray(newArray);
*/


// Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования.
/*
int[] copyArray(int[] mas)
{
    int j=mas.Length;
    int[] mas123=new int[j];
    for(int i=0; i<j; i++)
    mas123[i]=mas[i];
    return mas123;
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

Console.Write("Введите кол-во элементов для массива: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента для массива: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента для массива: ");
int max=Convert.ToInt32(Console.ReadLine());
int[] newArray=createRandomArray(size, min, max);
printArray(newArray);
copyArray(newArray);
printArray(newArray);
*/


// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
/*
string ConvertToBin(int number)
{
string res="";
int remainder;
while (number>0)
{
remainder = number % 2;
number = number / 2;

if (remainder>0) res="1"+res;
else res="0"+res;
}

return res;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ConvertToBin(number));
*/






// HOMEWORK



// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. (решить без массива, данные сохранять не надо)
/*
int pol( int kolvo)
{
    int count=0;
    for(int i=0; i<kolvo; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        int num=Convert.ToInt32(Console.ReadLine());
        if (num>0)
        count++;
    }
    return count;
}


Console.WriteLine("Введите количество чисел: ");
int N=Convert.ToInt32(Console.ReadLine());

if(N<=0)
Console.WriteLine("Ты шо хочешь ввести не положительное число? Иди-ка в угол");
else
Console.WriteLine(pol(N));
*/


// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void peresechenie(double b1, double k1, double b2, double k2)
{
    double x=0;
    if(b1==b2 && k1==k2)
    Console.WriteLine("Прямые имеют пересечение на всей прямой");
    else
    {
        if(b1==b2 && k1!=k2)
        Console.WriteLine($"Точка пересечения (0;{b1})");
        else
        {
            if(k1==k2 && b1!=b2)
            Console.WriteLine("Прямые параллельны друг другу, точек пересечения нет");
            else
            {
                if(k1!=k2 && b1!=b2)
                {
                    x=(b2-b1)/(k1-k2);
                    Console.WriteLine($"Точка пересечения двух прямых ({x};{k1*x+b1})");
                }
            }
        }
    }
}

Console.WriteLine("Введите b1: ");
double b1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2=Convert.ToDouble(Console.ReadLine());
peresechenie(b1, k1, b2, k2);
*/