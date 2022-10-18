
// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void FillArray(int[] array,int min,int max)
{
for (int index = 0; index < array.Length; index++)
                                                   // Если один оператор то {} писать не обязательно
    array[index] = new Random().Next(min,max);   // // В одномерном массиве из 123 чисел
}

void PrintArray(int[] array)
{
    for(int index = 0 ; index < array.Length; index++)

        Console.Write($"{array[index]} ");
}

int SegmentNumbers(int[] array)
{
int count = 0;
                                                        //Console.Write("Укажите начало отрезка: ");
    int FromNum = 10;                                   //int.Parse(Console.ReadLine() ?? "0");
                                                        //Console.Write("Укажите конец отрезка: ");
    int ToNum = 99;                                     //int.Parse(Console.ReadLine() ?? "0");
                                                        //Console.WriteLine($"Ваш отрезок [{FromNum},{ToNum}] ");
    for(int index = 0; index < array.Length; index++)
    {
        if (FromNum<=array[index] && array[index]<=ToNum) // найти количество элементов из отрезка [10,99]
        {
            count = count + 1;
        }
    }    
    return count;
}

                                                 //Console.Write ("Введите размер массива:  ");
int size = 123; //int size = int.Parse(Console.ReadLine() ?? "0"); 
Console.WriteLine();  // В одномерном массиве из 123 чисел

Console.WriteLine($"Размер массива равен: {size} ");
Console.WriteLine();

int[] array = new int[size];

FillArray(array,99,255); 

Console.WriteLine("Ваш массив: ");   

PrintArray(array);
Console.WriteLine();

int segment = SegmentNumbers(array);  // найти количество элементов из отрезка [10,99]

Console.WriteLine("");
Console.WriteLine($"Rоличество элементов из отрезка [10,99] состовляет {segment}"); // Console.WriteLine($"Rоличество элементов из заданного отрезка состовляет {segment}");
Console.ReadKey();

/*
int count = 0;
for(int index = 0; index < array.Length; index++)
{
    if (10<=array[index] && array[index]<=99)
    {
        count = count + 1;
    }
}
*/