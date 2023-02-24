// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] randomArray(int length)
{
    int[] a = new int[length];
    for (int i = 0; i < length; i++) a[i] = Random.Shared.Next(100, 1000);
    return a;
}

void res(int[] a)
{
    int min = a[0];
    int max = a[0];
    foreach (var item in a)
    {
        if (item < min) min = item;
        if (item > max) max = item;
    }
    Console.WriteLine($"[{string.Join(", ",a)}] -> {max} - {min} = {max-min}");
    
}

res(randomArray(5));
res(randomArray(5));
res(randomArray(5));