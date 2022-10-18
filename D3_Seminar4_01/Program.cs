
//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void FillArray(int[] array,int min,int max)
{
for (int index = 0; index < array.Length; index++)
                                                   // Если один оператор то {} писать не обязательно
    array[index] = new Random().Next(min,max); // заполненных нулями и единицами
}

void PrintArray(int[] array)
{
    for(int index = 0; index < array.Length; index++)

        Console.Write($"{array[index]} ");
}
                                                   
Console.WriteLine();

int size = 8;   // //Задать массив из 8 элементов
Console.WriteLine("Задан массив из 8 элементов ");

int[] array = new int[size];

Console.WriteLine();
FillArray(array,0,2); // заполненных нулями и единицами

Console.Write("Ваш массив: "); 

PrintArray(array); //вывести их на экран
Console.WriteLine();
Console.ReadKey();