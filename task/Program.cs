//Console.Write("Введите количество элементов массива: ");
//int size = int.Parse(Console.ReadLine());

string[] array = {"hello", "2", "world", ":-)"};
string[] newArray = new string[array.Length];
int i = 0;
foreach (string el in array)
{
    //Console.WriteLine(el + " "+ el.Length);  
    if (el.Length < 4) 
    {
        //Console.WriteLine(el);
        newArray[i] = el;
        i++;
    }
}

