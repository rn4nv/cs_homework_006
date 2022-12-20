Console.Clear();

Console.WriteLine("Заполните массив из 5 чисел: ");

void FillArray(int[] collection)

{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = int.Parse(Console.ReadLine());
        index++;
    }
}

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write($"{col[position]} ");
//         position++;
//     }
// }

int NumbersNegative (int[] collection)
{
    int count = collection.Length;
    int index = 0;
    int result = 0;

    while (index < count)
    {
        if (collection[index] < 0)
        {
            result++;
            index++;
        }
        else
        {
            index++;
        }
    }
    return result;
}


int[] Array = new int [5];
FillArray(Array);
Console.WriteLine();
// PrintArray(Array);
// Console.WriteLine();
Console.WriteLine($"Количество найденных чисел в введенном массиве равно: {NumbersNegative(Array)}");

