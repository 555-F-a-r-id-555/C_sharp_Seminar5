using System.Security.Claims;
// Задача 33: Задайте массив. Напишите программу, 
//которая определяет, присутствует ли заданное 
//число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int [] a ={ 1,2,3,45,6};

void function(int findNumber)
{
    bool p = false;
    foreach(var item in a)
    {
        if(item == findNumber) 
        {   
            p = true;
            Console.WriteLine($"{findNumber}; массив [{string.Join(", ",a)}] -> ДА");
            break;
        }
    }
if(p == false) Console.WriteLine($"{findNumber}; массив [{string.Join(", ",a)}] -> НЕТ");
}

function(6);
function(30);


// bool isinArray(params int[] array)
// {
//     int findNum = 8;
//     bool result = false;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == findNum)
//         {
//             result = true;
//             break;
//         }
//     }
//     return result;
// }


// isinArray(1, 2, 5, 50);