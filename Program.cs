string[] arrayFirst = { "Hello", "2", "world", ":-)" };
string[] arraySecond = TransformArray(arrayFirst);
PrintArray(arraySecond);


string[] TransformArray(string[] array)
{
    int LengthNewArray = 0;
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            LengthNewArray++;
        }
    }

    string[] newArray = new string[LengthNewArray];

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