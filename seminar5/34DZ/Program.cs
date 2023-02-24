// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу,которая покажет
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] randomArray(int length)
{
    int[] a = new int[length];
    for (int i = 0; i < length; i++) a[i] = Random.Shared.Next(100, 1000);
    return a;
}

void evenNumber(int[] a)
{
    int count = 0;
    foreach (var item in a)
    {
        if (item % 2 == 0) count += 1;
    }
    Console.WriteLine($"[{string.Join(", ",a)}] -> {count}");
}

evenNumber(randomArray(5));
evenNumber(randomArray(5));
evenNumber(randomArray(5));
evenNumber(randomArray(5));
evenNumber(randomArray(5));