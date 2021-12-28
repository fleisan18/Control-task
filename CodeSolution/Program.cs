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
    Console.WriteLine();
}

int[] IsEven (int[] array)
{
    int length = array.Length;
    int[] b = CreateArray(length);
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if(array[i] %2 ==0) b[count++] = array[i];
    }
    Array.Resize(ref b, count);
    return b;
}

Random r = new Random();
int [] a= FillArray(CreateArray(r.Next(10,20)));
int [] b = IsEven(a);

PrintArray(a);
PrintArray(b);



