Main();

void Main()
{
    string[] array = { "hello", "2", "world", ":-)" };
    //string[] newArray = new string[array.Length];
    string[] newArray = {};

    Console.WriteLine("Исходный массив:");
    int i = 0;
    foreach (string el in array)
    {
        Console.Write(el + " ");
        if (el.Length < 4)
        {
            Resize(ref newArray, i+1);
            //Console.WriteLine(newArray.Length);
            //Console.WriteLine(el);
            newArray[i] = el;
            i++;
        }
    }
    Console.WriteLine();

    Console.WriteLine("Новый массив:");
    foreach (string el in newArray)
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