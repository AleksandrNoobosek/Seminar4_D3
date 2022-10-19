//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

void FillArray(int[] array,int min,int max)
{
for (int index = 0; index < array.Length; index++)
                                                   // Если один оператор то {} писать не обязательно
    array[index] = new Random().Next(min,max);     //заполнить случайными положительными трёхзначными числами
}

void PrintArray(int[] array)
{
    for(int index = 0 ; index < array.Length; index++)

        Console.Write($"{array[index]} ");
}

int EvenNumbers(int []array)
{
int countpos = 0;
    for(int index = 0; index < array.Length; index++)
        {
        if (array[index]%2==0)
            countpos = countpos + 1;
        }
    return countpos;
}

int OddNumbers(int []array)
{
int countneg = 0;
    for(int index = 0; index < array.Length; index++)
        {
        if (array[index]%2!=0)
            countneg = countneg + 1;
        }
    return countneg;
}


Console.Write ("Введите размер массива:  ");
int size = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

Console.WriteLine($"Размер массива равен: {size} ");
Console.WriteLine();

int[] array = new int[size];  //Задать массив

FillArray(array,100,1000); //заполнить случайными положительными трёхзначными числами

Console.Write("Ваш массив: ");   

PrintArray(array);
Console.WriteLine();

int even = EvenNumbers(array);
int odd = OddNumbers(array);

Console.WriteLine(); 
Console.WriteLine($"Кол-во четных чисел равно {even} ");  //Показать количество четных чисел
Console.WriteLine(); 
Console.WriteLine($"Кол-во нечетных чисел равно {odd} "); //Показать количество нечетных чисел
Console.ReadKey();