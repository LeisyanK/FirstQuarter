Main();

void Main()
{
    Console.Clear();
    string[] array = { "hello", "2", "world", ":-)" };
    //string[] newArray = new string[array.Length];
    string[] newArray = {};

    Console.WriteLine("Исходный массив:");
    PrintArray(array);
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
    Console.WriteLine();

    Console.WriteLine("Новый массив:");
    PrintArray(newArray);
    
}

void PrintArray(string[] array)
{
    foreach (string el in array)
    {
        //Console.WriteLine(el + " "+ el.Length);
        Console.Write(el + " ");
    }
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