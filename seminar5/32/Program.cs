using System;
// Задача 32: Напишите программу замена элементов массива: положительные 
//элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


//int [] a = {1,2,-3,5};
void function(params int [] a)
{   Console.Write($" [{string.Join(", ",a)}] -> ");
    for(int i = 0 ; i< a.Length;i++) a[i] *=(-1);
    Console.WriteLine($"[{string.Join(", ",a)}]");
}

function(1,-2,3,4,5);
function(-4,8,8,2);