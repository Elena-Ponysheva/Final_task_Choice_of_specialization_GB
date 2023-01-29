string[] arrayFirst = { "Hello", "2", "world", ":-)" };
string[] arraySecond = TransformArray(arrayFirst);
PrintArray(arraySecond);


string[] TransformArray(string[] array)
{
    int lengthNewArray = 0;
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            lengthNewArray++;
        }
    }

    string[] newArray = new string[lengthNewArray];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }

    return newArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}