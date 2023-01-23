Console.Clear();
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int i = 0;
    while (i < lenght)
    {
        collection[i] = new Random().Next(0, 11);
        i++;
    }
}
System.Console.WriteLine("Введите размер массива: ");
int volum = Convert.ToInt32(System.Console.ReadLine()!);
int[] array = new int[volum];

FillArray(array);

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

System.Console.WriteLine("Массив:");
PrintArray(array);
SelectionSort(array);
System.Console.WriteLine("Сортировка массива Min → Max:");
PrintArray(array);