
//Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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

void ProductPairs (int[] array)
{
int j = array.Length-1;                    //Парой считаем первый и последний элемент
    for (int index = 0; index<j; index++) // array.Length/2
    {
        int count = array[index]*array[j];  //Найти произведение пар чисел в одномерном массиве.
        Console.WriteLine($"Произведение чисел первого элемента {array[index]} и второго элемента {array[j]} равно {count}"); //Парой считаем первый и последний элемент
        Console.WriteLine(" ");
    j=j-1;
    }
}



Console.Write ("Введите размер массива:  ");
int size = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

Console.WriteLine($"Размер массива равен: {size} ");
Console.WriteLine();

int[] array = new int[size];

FillArray(array,1,15);

Console.WriteLine("Ваш массив: ");   

PrintArray(array);
Console.WriteLine(" ");
Console.WriteLine();
ProductPairs (array); //Найти произведение пар чисел в одномерном массиве.

Console.ReadKey();