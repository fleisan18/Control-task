//Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.

int[] CreateArray (int n)
{
    int[] array = new int [n];
    return array;
}

int[] FillArray (int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next (-100,100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

