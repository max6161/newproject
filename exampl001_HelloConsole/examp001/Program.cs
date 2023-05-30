



//Задача2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число больше.
/*
Console.Write("primem chislo_a: ");
int number_a = Convert.ToInt32(Console.ReadLine());
Console.Write("primem chislo_b: ");
int number_b = Convert.ToInt32(Console.ReadLine());

if (number_a > number_b) 
    Console.WriteLine("chislo_a bolshe chisla_b");
else
    Console.WriteLine("chislo_B bolshe chisla_a");


Задача4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное число.

Console.Write("primem chislo_b: ");
        int number_b = Convert.ToInt32(Console.ReadLine());
        Console.Write("primem chislo_c: ");
        int number_c = Convert.ToInt32(Console.ReadLine());
        Console.Write("primem chislo_d: ");
        int number_d = Convert.ToInt32(Console.ReadLine());

        int max = 0;

        if (number_b > max)
            max = number_b; 

        if (number_c > max)
            max = number_c;
        
        if (number_d > max)
            max = number_d;

        Console.Write( max );
 

 Задача 6 :Напишите программу, которая на входе принимает число и выдаёт, являеться ли число чётным(делиться
  на 2 без остатка)
 
*/
/*
Console.Write("primem chislo: ");
int number_a = Convert.ToInt32(Console.ReadLine());

if  (number_a % 2==1)
    Console.Write("ЧИСЛО НЕ ЧЁТНОЕ: ");
else 
    Console.Write("ЧИСЛО  ЧЁТНОЕ, Делиться на 2 без остатка: ");

*/





/*
Console.Write("Input a positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

while(current <= num)
{
    Console.Write(current + " ");
    current ++ ;
}
*/

/* 
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1 456

int num = Convert.ToInt32(Console.ReadLine());
int MaxNumb(int num)
{
    int a1 = num /10;
    int a2 = a1 % 10;
    
    return a2;
   
}
       
Console.WriteLine($"Введено число: {num} средняя цифра: {MaxNumb(num)}");

*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6
/*
int num = Convert.ToInt32(Console.ReadLine()); 
bool return
int MaxNumb(int num)
{
    
    int a1 = num % 100;
    int a2 = num % 10;
    if (a2 > 999) 
    {
    return a2;
    }
    else
    {
     Console.Write("третьей цифры нет");
     return 0;
    }
}
Console.WriteLine($"Введено число: {num} средняя цифра: {MaxNumb(num)}");
*/
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