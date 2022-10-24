string[] array = { "hello", "2", "world", ":-)" };
int size = array.Length;
int number = 0;
int sizeArrayResult = 0;
for (int i = 0; i < size; i++)
{
    if (array[i].Length < 4) sizeArrayResult++;
}
string[] arrayResult = new string[sizeArrayResult];
for (int i = 0; i < size; i++)
{
    if (array[i].Length < 4)
    {
        arrayResult[number] = array[i];
        number++;
    }
}
PrintArray(arrayResult);
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(",");
    }
    Console.Write("]");
}

