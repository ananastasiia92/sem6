﻿/* Задача 1:Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

-1, -7, 567, 89, 223-> 3
*/

Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);
int N = FindQuant(baseArray);
Console.WriteLine($"{String.Join(", ", GetArrayFromString(elements))} -> {FindQuant(baseArray)}");

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int FindQuant(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++){
        if (array[i] > 0){
        count++;
        }
    }return count;
}