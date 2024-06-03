using System;

class Program
{
static void Main()
{
    Console.WriteLine("Введите строки через пробел:");
    string[] array1 = Console.ReadLine().Split(' ');
    string[] array2 = new string[array1.Length];

    SecondArrayWithIF(array1, array2);
    PrintArray(array2);
}

    }

    static void SecondArrayWithIF(string[] array1, string[] array2)
    {
        int count = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i].Length <= 3)
            {
                array2[count] = array1[i];
                count++;
            }
        }
    }

static void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (!string.IsNullOrEmpty(array[i]))
        {
            Console.Write($"{array[i]} ");
        }
    }
    Console.WriteLine();
}

