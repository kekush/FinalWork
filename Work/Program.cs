// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

void Main()
{
    Console.Clear();
    string[] arrStart = new string[4] {"hello", "2", "world", ":-)"};
    string[] arrFinish = new string[arrStart.Length];
    FinishArray(arrStart, arrFinish);
    PrintArray(arrFinish);
}

void FinishArray(string[] arr1, string[] arr2)
{
    int count = 0;
    int limit = 3;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= limit)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Main();
