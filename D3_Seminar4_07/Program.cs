 
 //В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void FillArray(double[]array)
{
Random random = new Random();

    for (int index = 0; index< array.Length; index++)
    {
        array[index]= random.NextDouble() * 100;
    }
 
}

void PrintArray(double[]array)
{
    for (int index = 0; index< array.Length; index++)
    {
        Console.Write($"{array[index]}\t");
        Console.Write(" ");
    }
}

void DifferenceMaxMin (double[]array)
{
double max = array[0];
double min = array[0];
    for (int index = 0; index< array.Length; index++)
    {
        if(array[index]>max)
        { 
            max = array[index];  // максимальным
        }
        else if(array[index]<min)
        {
            min = array[index]; // минимальным
        }
    
    }
    Console.WriteLine("");
    Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементом равнa  {max-min}"); //найдите разницу между максимальным и минимальным элементом

}

                                                                //Console.Write("Введите размер массива: ");     
int size = 44; //В Указанном массиве вещественных чисел           //int.Parse(Console.ReadLine() ?? "0");
double[] array = new double[size];

FillArray(array);
Console.WriteLine($"your array: ");

PrintArray(array);
Console.WriteLine("");

DifferenceMaxMin (array);  //найдите разницу между максимальным и минимальным элементом
Console.WriteLine("");

Console.ReadKey();