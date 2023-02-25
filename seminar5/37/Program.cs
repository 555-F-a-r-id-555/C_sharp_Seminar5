// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


// int f(int x)
// {
//     return x*x;
// }

// void z( int a,int x)
// {
//     int z1 = f(x) + a;
//     Console.WriteLine($"{z1}");    
// }

// z(8,2);

int[] randomArray(int length)
{
    int[] a = new int[length];
    for (int i = 0; i < length; i++) a[i] = Random.Shared.Next(0, 11);
    return a;
}

int newLength(int length)
{
    int newLenght = (length % 2 == 0) ? length / 2 : length / 2 + 1;
    return newLenght;
}

void newArray(int length)
{
    int[] a = randomArray(length);
    int[] newArray = new int[newLength(length)];
    for (int i = 0; i < length / 2; i++)
    {
        newArray[i] = a[i] * a[(length - 1) - i];
    }
    if (length % 2 != 0) newArray[^1] = a[length / 2];
    Console.WriteLine($"[{string.Join(", ", a)}] -> [{string.Join(", ", newArray)}]");
}

newArray(1);
newArray(3);
newArray(4);
newArray(15);