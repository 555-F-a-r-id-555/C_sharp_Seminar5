// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] randomNumber(int length)
{
    int[] a = new int[length];
    for (int i = 0; i < length; i++) a[i] = Random.Shared.Next(-100, 101);
    return a;
};

void sumNumber( int[] a)
{
    int sum = 0;
    for (int i = 1; i < a.Length; i += 2) sum += a[i];
    Console.WriteLine($"[{string.Join(", ",a)}] -> {sum}");
}

sumNumber(randomNumber(5));
sumNumber(randomNumber(5));
sumNumber(randomNumber(5));
sumNumber(randomNumber(5));