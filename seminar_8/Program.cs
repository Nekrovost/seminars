// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

void changeStroki(int[,] array, int a1, int a2)
{
    if(a1>=0 && a1<array.GetLength(0) && a2>=0 && a2<array.GetLength(0) && a1!=a2)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            int temp=array[a1,j];
            array[a1,j]=array[a2,j];
            array[a2,j]=temp;
        }
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
Console.Write("Введите номер строки: ");
int first=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите номер строки: ");
int second=Convert.ToInt16(Console.ReadLine());
int[,] newArray=createRandome2dArray(rows, cols, minValue, maxValue);
show2dArray(newArray);
changeStroki(newArray,first-1,second-1);
show2dArray(newArray);
*/




// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. (тут для массива n*n, то есть квадратного, надо менять относительно главной диагонали элементы)
/*
int[,] createRandome2dArray(int rows, int minValue, int maxValue)
{
    int[,] array=new int[rows, rows];

    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<rows; j++)
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

void changeMasive(int[,] array)
{
    int count=0;
    for(int j=0; j+count<array.GetLength(1); j++)
    {
    for(int i=0; i+count<array.GetLength(0); i++)
        {
        int temp=array[i+count,j+count];
        array[i+count,j+count]=array[j+count,i+count];
        array[j+count,i+count]=temp;
        }
    count++;
    }
}
Console.Write("Введите кол-во строк: ");
int rows=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите минимальное значение элемента матрицы: ");
int minValue=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите максимальное значение элемента матрицы: ");
int maxValue=Convert.ToInt16(Console.ReadLine());
int[,] newArray=createRandome2dArray(rows, minValue, maxValue);
show2dArray(newArray);
changeMasive(newArray);
show2dArray(newArray);
*/


// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
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

void printArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    Console.Write(array[i]+" ");

    Console.WriteLine();
    Console.WriteLine();
}

int[] minZnach(int[,] array)
{
   int[] results=new int[2];

   for(int i=0; i<array.GetLength(0); i++)
   {
    for(int j=0; j<array.GetLength(0); j++)
    {
        if(array[i,j]<array[results[0],results[1]])
        {
            results[0]=i;
            results[1]=j;
        }
    }
   }
   return results;
}

int[,] showDuckArray(int[,] array1, int[] array2)
{
    int count1=0;
    int count2=0;
    int[,] array=new int[array1.GetLength(0)-1, array1.GetLength(1)-1];
    for(int i=0; i<array.GetLength(0); i++)
    {
        if(i==array2[0])
        count1++;
        for(int j=0; j<array.GetLength(1); j++)
        {
            if(j==array2[1])
            count2++;
            array[i,j]=array1[i+count1, j+count2];
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
int[] numbers=minZnach(newArray);
printArray(numbers);
newArray=showDuckArray(newArray,numbers);
show2dArray(newArray);
*/


// HOMEWORK


// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

int[,] ypor(int[,] array)
{
    int temp=0;
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int count1=0; count1<array.GetLength(1)-1; count1++)
        {
            for(int j=0; j<array.GetLength(1)-1; j++)
            {
                if(array[i,j]<array[i,j+1])
                {
                    temp=array[i,j];
                    array[i,j]=array[i,j+1];
                    array[i,j+1]=temp;
                }
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
newArray=ypor(newArray);
show2dArray(newArray);
*/


// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int[] sumMassive(int[,] array)
{
    int sum=0;
    int[] sumElements=new int[array.GetLength(0)];
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            sum=sum+array[i,j];
        }
        sumElements[i]=sum;
        sum=0;
    }
    return sumElements;
}

void printArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    Console.Write(array[i]+" ");

    Console.WriteLine();
    Console.WriteLine();
}

void minStroka(int[] array)
{
    int min=0;
    for(int i=1; i<array.Length; i++)
    {
        if(array[min]>array[i])
        {
            min=i;
        }
    }
    Console.WriteLine($"{min+1} - это строка, где сумма элементов минимальна");
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
int[] newMassive=sumMassive(newArray);
printArray(newMassive);
minStroka(newMassive);
*/


// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int[,] matrix(int[,] array1, int[,] array2)
{
    int[,] array= new int[array1.GetLength(0),array2.GetLength(1)];
    for(int i=0; i<array1.GetLength(0); i++)
    {
        for(int j=0; j<array1.GetLength(0); j++)
        {
            for(int n=0; n<array1.GetLength(0); n++)
            {
                array[i,j]=array1[i,n]*array2[n,j]+array[i,j];   // rbk vb gkbfpt
            }
        }
    }
    return array;
}

Console.Write("Введите кол-во строк (1): ");
int rows1=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите кол-во столбцов (1): ");
int cols1=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите минимальное значение элемента матрицы (1): ");
int minValue1=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите максимальное значение элемента матрицы (1): ");
int maxValue1=Convert.ToInt16(Console.ReadLine());
int[,] newArray1=createRandome2dArray(rows1, cols1, minValue1, maxValue1);
show2dArray(newArray1);

Console.Write("Введите кол-во строк (2): ");
int rows2=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите кол-во столбцов (2): ");
int cols2=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите минимальное значение элемента матрицы (2): ");
int minValue2=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите максимальное значение элемента матрицы (2): ");
int maxValue2=Convert.ToInt16(Console.ReadLine());
int[,] newArray2=createRandome2dArray(rows2, cols2, minValue2, maxValue2);
show2dArray(newArray2);

int[,] newArray3=matrix(newArray1, newArray2);
show2dArray(newArray3);
*/


// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] createRandome3dArray(int rows, int cols, int dols, int minValue, int maxValue)
{
    int[,,] array=new int[rows, cols, dols];
    int[] array1=new int[89];
    for(int k=0; k<array1.Length; k++)
    {
        array1[k]=10+k;
    }
    int count=0;
    

    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<cols; j++)
        {
            for(int n=0; n<dols; n++)
            {
                array[i,j,n]=array1[new Random().Next(0, array1.Length+1-count)]; // xedcnde. 'nj yt vj`? z ,jktt lde[ xfcjd gjnhfnbk yf nj xnj,s ghblevfnm rfr 'nj vj;yj cltkfnm? ;tcnm z negjq///
                for(int k=0; k<(array.Length-count); k++)
                {
                    if(array1[k]<array1[k+1])
                    {
                        int temp=array1[k];
                        array1[k]=array1[k+1];
                        array1[k+1]=temp;
                    }
                }
            }
        }
        count++;
    }
    return array;
}

void show3dArray(int[,,] array)
{
    for(int n=0; n<array.GetLength(2); n++)
    {
        for(int i=0; i<array.GetLength(1); i++)
        {
            Console.WriteLine();
            for(int j=0; j<array.GetLength(0); j++)
            {   
                Console.Write($"{array[i,j,n]} ({i},{j},{n})  ");
            }
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите кол-во строк: ");
int rows=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int cols=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите кол-во фиг знает как назвать? глубина?: ");
int dols=Convert.ToInt16(Console.ReadLine());


int[,,] newArray=createRandome3dArray(rows, cols, dols, 10, 100);
show3dArray(newArray);
*/


// Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int[,] createRandome2dArray(int rows)
{
    int[,] array=new int[rows, rows];

        //i,j   i, j+size-1
        //i+1, j+size-1     i+size-1, j+size-1
        //i+size-1, j+size-2    i+size-1, j
        //i+size-2, j   i+1, j
    int q=1;
    int count=rows*rows+1;

    int sliz=1;

    int count1=0;
    int count2=0;
    int count3=0;
    int count4=0;

    int j=0;
    int i=0;

        if(i==0 && j==0)
        {
            while(j<array.GetLength(1))
            {
                array[i,j]=q;
                q++;
                j++;
            }  
        i++;
        count1++;
        }

        if(j==array.GetLength(1))
        {
            while(i<array.GetLength(0))
            {
                array[i,j-1]=q;
                q++;
                i++;        
            }
        j--;
        count2++;
        }

        if(j==array.GetLength(1)-1 && i==array.GetLength(0))
        {
            while(j>0)
            {
                array[i-1,j-1]=q;
                q++;
                j--;        
            }
        i--;
        count3++;
        }

        if(j==0 && i==array.GetLength(0)-1)
        {
            while(i>1)
            {
                array[i-1,j]=q;
                q++;
                i--;
            }
        j=1;
        i=1;
        count4++;
        }

        if(i==1 && j==1)
        {
            while(j<array.GetLength(1)-count4)
            {
                array[i,j]=q;
                q++;
                j++;
            }
        count2++;
        i++;
        i=2;
        j=2;
        }

        if(i==2 && j==2)
        {
            while(j>0)
            {
                array[i,j]=q;
                q++;
                j--; 
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


Console.Write("Введите размерность массива n*n: ");
int razmer=Convert.ToInt16(Console.ReadLine());
int[,] newArray=createRandome2dArray(razmer);
show2dArray(newArray);


// честно, не смог придумать нормальный способ как сделать эту улитку, как должно работать понимаю, а вот чтобы это было по человечески не смог сделать
*/