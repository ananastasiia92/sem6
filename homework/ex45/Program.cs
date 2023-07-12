/*Задача 45: Напишите программу,
 которая будет создавать копию заданного массива с помощью поэлементного копирования.*/

Console.Clear();
int[] array = GetArray(6, 0, 10);
Console.WriteLine(String.Join(" ", (array)));

int[] N = CopyArr(array);
Console.WriteLine(String.Join(", ", CopyArr(array)));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
 int[] CopyArr(int[]array){
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];

    }
    return result;
}




