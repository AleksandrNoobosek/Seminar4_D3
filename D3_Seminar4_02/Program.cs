
// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

void FillArray(int[] array,int min,int max)
{
for (int index = 0; index < array.Length; index++)
                                                   // Если один оператор то {} писать не обязательно
    array[index] = new Random().Next(min,max);  //заполненных числами из [0,9]
}

void PrintArray(int[] array)
{
    for(int index = 0 ; index < array.Length; index++) 

        Console.Write($"{array[index]} ");  // Если один оператор то {} писать не обязательно
}

int SumPosArr(int[]array)
{
int sumpos = 0;   
    for(int index = 0; index < array.Length; index++ )
    {
        if (array[index]>=0)
        {
            sumpos = sumpos + array[index];
        }
   
    }
    return sumpos;
   
}

int SumNegArr(int[]array)
{
int sumneg = 0;   
    for(int index = 0; index < array.Length; index++ )
    {
        if (array[index]<0)
        {
            sumneg = sumneg + array[index];
        }
    
    }
    return sumneg;
}

int size = 12;                                    //Задать массив из 12 элементов
Console.WriteLine("Задан массив из 12 элементов!");
int[] array = new int[size];

FillArray(array,0,10);  //заполненных числами из [0,9]

Console.Write("Ваш массив: "); 


PrintArray(array);
Console.WriteLine();

int Pos = SumPosArr(array);

Console.WriteLine("");
Console.WriteLine($"Cумма положительных элементов массива равна {Pos}");  //сумма положительных элементов массива
Console.ReadKey();



int Neg = SumNegArr(array);

Console.WriteLine("");
Console.WriteLine($"Cумма отрицательных элементов массива равна {Neg}"); //сумма отрицательных элементов массива
Console.ReadKey();