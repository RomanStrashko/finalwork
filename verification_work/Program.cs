/* Написать программу, которая из имеющегося массива строк формирует массив из строк, для меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на выполнения алгоритма. При решение не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами.*/


string [,] array = { { "R" , "o", "m", "a", "n" }, { "S", "t", "r", "0", "8" }};
int rows = 5;    
int columns = 5;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{ array[i, j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.Write("-> ");
PrintArray(array);

void PrintArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write($" {array[i, j]} \t");
        }
        Console.WriteLine();
        Console.Write("   ");
    }
}