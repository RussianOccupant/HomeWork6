/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] GetArray(int size)
{
    int[] res = new int[size];
    Console.WriteLine("Enter elements: ");
    for (int i = 0; i < size; i++)
    {
        res[i] = int.Parse(Console.ReadLine()!);
    }
    return res;
}

int GetProv(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите числовое обозначение количества будущих элементов: ");
int size = int.Parse(Console.ReadLine()!);


int[] array = GetArray(size);
Console.WriteLine($"Чисел больше нуля {GetProv(array)}");








