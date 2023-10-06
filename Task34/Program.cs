// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


using System.Data;

int[] ThreeDigitArray (int length, int min, int max) // Создали шаблон массива
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int EvenNumbera(int[] arr)
{
    int even = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2==0) 
        even = even + 1;
    }
    return even;

}

int[] array = ThreeDigitArray(5, 100, 999);

Console.Write("[");
PrintArray(array);
Console.Write("]");

int EvenNumbers = EvenNumbera(array);
Console.WriteLine($" -> {EvenNumbers}");
