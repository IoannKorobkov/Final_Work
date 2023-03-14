
string[] array = { "123456", "hello_world", "2", ":-)" };

void FillArray(string[] array)
{
    Console.Write($"Вводимый массив: ");
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
}
FillArray(array);

void ThirdSymbol(string[] array)
{
    Console.Write($"Выводимый массив: ");
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write($"{array[i]}  ");
        }
    }
}
ThirdSymbol(array);