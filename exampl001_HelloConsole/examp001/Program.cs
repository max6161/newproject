

/*Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно 
 массивами.*/

class Program
{
    static void Main(string[] args)
    {
        string[] originalArray = { "apple", "banana", "cherry", "date" };
        string[] newArray = new string[3];
        Random rnd = new Random();

        int index1 = rnd.Next(originalArray.Length);
        int index2 = rnd.Next(originalArray.Length - 1);
        if (index2 >= index1) index2++;
        int index3 = rnd.Next(originalArray.Length - 2);
        if (index3 >= index1) index3++;
        if (index3 >= index2) index3++;

        newArray[0] = originalArray[index1];
        newArray[1] = originalArray[index2];
        newArray[2] = originalArray[index3];

        Console.WriteLine("New array: [{0}, {1}, {2}]", newArray[0], newArray[1], newArray[2]);
    }
}