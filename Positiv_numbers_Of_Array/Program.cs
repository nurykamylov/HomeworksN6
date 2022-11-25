/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.Write("Type the size of number, how much you want enter: ");
int size = int.Parse(Console.ReadLine()!);
int[] array =  new int[size];

EnteringElements(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine("Positive numbers: " + PositiveNumbersOfArray(array));

void EnteringElements(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{i+1}: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
       Console.Write(arr[i] + ", ");
    }
}

int PositiveNumbersOfArray(int[] arr )
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sum += 1;
        }
    }
    return sum;
}