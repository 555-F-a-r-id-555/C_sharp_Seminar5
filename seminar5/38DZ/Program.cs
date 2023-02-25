// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

Double[] randomArray(int length)
{
    double[] a = new double[length];
    for (int i = 0; i < length; i++) a[i] = Math.Round(Random.Shared.NextDouble() * 100, 2);
    return a;
}

// Console.WriteLine($"{Random.Shared.NextDouble()*100}");

void res(double[] a)
{
    var min = a[0];
    var max = a[0];
    foreach (var item in a)
    {
        if (item < min) min = item;
        if (item > max) max = item;
    }
    Console.WriteLine($"[{string.Join(", ", a)}] -> {max} - {min} = {(max - min):f2}\n\n");
}


res(randomArray(5));
res(randomArray(5));
res(randomArray(5));