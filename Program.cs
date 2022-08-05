// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


Console.WriteLine("Введите кол-во элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());

// Заполнение начального массива
string[] array = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите строку: ");
    array[i] = Console.ReadLine();
}
Console.WriteLine();
Console.Write("[ " + string.Join(" ", array) + " ] -> ");

//Заполнение нового массива
string[] arrayNew = new string[array.Length];
int count = 0;
for (int i = 0; i < n; i++)
{
    if (array[i].Length <= 3)
    {
        arrayNew[count] = array[i];
        count++;
    }
}
Console.Write("[ " + string.Join(" ", arrayNew) + "]");
