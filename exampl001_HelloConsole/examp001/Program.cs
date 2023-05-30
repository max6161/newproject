

//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
string[] string_set = new string[5] {"1", "2", "old", "yang", "23", };
string[] string_set2 = new string[string_set.Length];
void array_method(string[] string_set, string[] string_set2)
{
    int count = 0;
    for (int a = 0; a < string_set.Length; a++)
    {
    if(string_set[a].Length <= 3)
        {
        string_set2[count] = string_set[a];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int a = 0; a < array.Length; a++)
    {
        Console.Write($"{array[a]} ");
    }
    Console.WriteLine();
}
array_method(string_set, string_set2);
PrintArray(string_set2);