
// Найти сумму чисел одномерного массива стоящих на нечетной позиции

void FillArray(int[] array,int min,int max)
{
for (int index = 0; index < array.Length; index++)
                                                   // Если один оператор то {} писать не обязательно
    array[index] = new Random().Next(min,max);
}

void PrintArray(int[] array)
{
    for(int index = 0 ; index < array.Length; index++)

        Console.Write($"{array[index]} ");
}

int SumOddArr(int[] array)
{
int SumOdd = 0;
    for(int index = 0;index < array.Length; index++)
    {
    if (index%2==1)                           // стоящих на нечетной позиции
        {
            SumOdd = SumOdd + array[index]; //Найти сумму чисел одномерного массива 
        }
    }
    return SumOdd;
}

Console.Write ("Введите размер массива:  ");
int size = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

Console.WriteLine($"Размер массива равен {size} ");
Console.WriteLine();

int[] array = new int[size];

FillArray(array,1,4);

Console.Write("Ваш массив: ");   

PrintArray(array);
Console.WriteLine();

int result = SumOddArr(array); //Найти сумму чисел одномерного массива 

Console.WriteLine();
Console.WriteLine($"Cуммa чисел одномерного массива стоящих на нечетной позиции равна {result}");

Console.ReadKey();