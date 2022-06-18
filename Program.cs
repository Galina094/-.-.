//Creating an array
Console.Write("Enter length of array: ");

int length = Convert.ToInt32(Console.ReadLine());
string[] array = new string[length];
string[] array2 = new string[length];

//Fill array
Console.WriteLine("Fill the array whith values, please.");
FillArray(array);

//Output array
Console.WriteLine();
Console.WriteLine("Entered array:");
OutputArr(array);

//Creating new sorted array
SortArr(array, array2);

//Output sorted array
Console.WriteLine();
Console.WriteLine("Sorted array: ");
OutputArr(array2);


//Filling the array
void FillArray(string[] arr)
{
    for (int i = 0; i < length; i++)
    {
        arr[i] = Convert.ToString(Console.ReadLine());
    }
}

//Output array
void OutputArr(string[] arr)
{
    for (int i = 0; i < length; i++)
    {
        Console.Write($" {arr[i]} ");
    }
}

//Sorted
void SortArr(string[] arr, string[] arr2)
{
    for (int i = 0; i < length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arr2[i] = arr[i];
        }
    }
}
