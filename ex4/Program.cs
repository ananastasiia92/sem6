// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
//  Первые два числа Фибоначчи: 0 и 1.

// Если N = 5-> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8  

// <aside>
// ❗️ Числа Фибоначчи — числовая ****последовательность,
//  каждый элемент которой равен сумме двух предыдущих.

/*Console.Clear();

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Fib(n);

void Fib(int n)
{
int[] array = new int[n];
array[0] = 0;
array[1] = 1;
for (int i = 2; i < n; i++)
{
array[i] = array[i - 1] + array[i - 2];
}
System.Console.WriteLine(String.Join(" ", array));
}
*/

int[] Fib(int n){
    int[] mas_f = new int[n];
    mas_f[0] = 0;
    if(n >= 2)
        mas_f[1] = 1;
    for (int i = 2; i < n; i++){
        mas_f[i] = mas_f[i - 1] + mas_f[i - 2];
    }
    return mas_f;
}

Console.Clear();
Console.WriteLine("введите N");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"[{String.Join(' ', Fib(n))}]");


