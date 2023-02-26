// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] ->

using static Library;

Console.Write("Введите кол-во элементов в массиве:  ");
int size = int.Parse(Console.ReadLine());

string[] arrayStr = new string [size];
Console.WriteLine();

UserInput(arrayStr);
Console.WriteLine();

PrintArray(arrayStr);
Console.WriteLine();
Console.WriteLine();

string[] arrayStrNew = new string [arrayStr.Length];
int length = 3;

FindStringArrayElementsSpecificLength(arrayStr, arrayStrNew, length);

Console.WriteLine($"Массив из строк, длина которых меньше либо равна {length} символам");
Console.WriteLine();
PrintArray(arrayStrNew);













