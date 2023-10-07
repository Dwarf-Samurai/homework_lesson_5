/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double[] ArrayReadNumbers (int length, int min, int max)
{
    double[] arr = new double[length];
    Random rand = new Random();
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rand.NextDouble() + rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]:F2}, ");
        else Console.Write($"{arr[i]:F2}");
    }
}

double MaxAndMinElements(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    double sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) 
        max = arr[i];
        if (min > arr[i])
        min = arr[i];
    }
    sum = max - min;
    Console.Write($" => {max:F2} - {min:F2}");
    return sum;
    
}

double[] array = ArrayReadNumbers(5, 1, 10);

Console.Write("[");
PrintArray(array);
Console.Write("]");

double Difference = MaxAndMinElements(array);
Console.WriteLine($" = {Difference:F2}");