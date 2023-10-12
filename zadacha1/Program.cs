/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/
using Microsoft.VisualBasic;

int Input(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}
string[] CreateArray(int size)
{
    return new string[size];
}
void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine("Введите строку: ");
        arr[i] = Console.ReadLine()!;
    }
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {

        Console.Write(arr[i] + " ");
    }

    Console.WriteLine();
}
string[] NewArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            count++;
    }
    string[] res = CreateArray(arr.Length);
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            res[j] = arr[i];
            j++;
        }
    }
    return res;
}

int size = Input("Введите размер массива: ");
string[] myArray = CreateArray(size);
FillArray(myArray);
System.Console.WriteLine("Введенный массив: ");
PrintArray(myArray);
string[] newarr = NewArray(myArray);
System.Console.WriteLine("Новый массив: ");
PrintArray(newarr);
