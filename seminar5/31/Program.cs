// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.


//int [] a = new int [12];

int[] getRandomArray ()
{
    int length = 12;
    int leftRange = -9;
    int rightRange = 9;

    int [] array = new int[length];

    for(int i =0; i<array.Length;i++)
    {
        array[i] =Random.Shared.Next(leftRange,rightRange);
    }
    return array;
}

(int ,int ) SumPositiveAndNegative(int[] array)
{
    int sumPositive =0;
    int sumNegative =0;
    for (int i=0; i<array.Length; i++)
    {
        if(array[i]>0)
        {
            sumPositive+=array[i];
        }
        else if(array[i]<0)
        {
            sumNegative+=array[i];
        }   
    }

    return(sumPositive,sumNegative);
}

int[] myArray = getRandomArray();
Console.WriteLine($"[{string.Join(", ",myArray)}]");


(int sumP,int sumN) = SumPositiveAndNegative(myArray);
Console.WriteLine($"Sum positive = {sumP}");
Console.WriteLine($"Sum negative = {sumN}");

// (int a,int b) =(1,2);