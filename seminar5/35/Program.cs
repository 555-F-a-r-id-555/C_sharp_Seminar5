// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int[] randomArray(int length)
{
    int[] a = new int[length];
    for (int i = 0; i < length; i++) a[i] = Random.Shared.Next(10, 150);
    return a;
}

void countNumber(int[] a)
{
    int count = 0;
    foreach (var item in a)
    {
        if (item >= 10 && item <= 99) count += 1;
    }
    Console.WriteLine($"[{string.Join(", ", a)}] -> {count}");
}

countNumber(randomArray(5));
countNumber(randomArray(5));
countNumber(randomArray(5));
countNumber(randomArray(5));
countNumber(randomArray(5));