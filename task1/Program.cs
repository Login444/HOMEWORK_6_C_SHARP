void ShowArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


int[] CreateArray()
{
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {   
        Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int CountOfPositiveNums(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0 ) count++;
    }
    return count;
}

Console.WriteLine("Давайте создадим Ваш массив и я попробую узнать сколько положительных чисел Вы ввели: ");
int [] arr = CreateArray();
Console.Clear();
Console.WriteLine("Ваш массив: ");
ShowArray(arr);
Console.WriteLine();
Console.WriteLine($"В Вашем массиве {CountOfPositiveNums(arr)} положительных чисел.");