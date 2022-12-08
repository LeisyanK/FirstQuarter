Main();

void Main()
{
    Console.Clear();
    string[] array = { "hello", "2", "world", ":-)" };
    string[] secondArray = {};

    Console.WriteLine("Исходный массив:");
    PrintArray(array);

    secondArray = NewArray(array, secondArray);

    Console.WriteLine("Новый массив:");
    PrintArray(secondArray);
    
}

string[] NewArray(string[] array, string[] newArray)
{
    int i = 0;
    foreach (string el in array)
    {
        if (el.Length < 4)
        {
            Resize(ref newArray, i+1);
            newArray[i] = el;
            i++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    int i = 0;
    foreach (string el in array)
    {
        Console.Write(el + " ");
        i++;
    }
    Console.WriteLine();
}

void Resize(ref string[] array, int newSize)
{
    //Console.WriteLine(newSize);
    string[] newArray = new string[newSize];
    for (int i = 0; i < array.Length && i < newArray.Length; i++)
    {
        newArray[i] = array[i];
    }
    array = newArray;
}