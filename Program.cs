//Creating an array
Console.Write("Enter length of array: ");

int length = Convert.ToInt32(Console.ReadLine());
string[] array = new string[length];
string[] array2 = new string[length];

//Fill array
Console.WriteLine("Fill the array whith values, please.");
FillArr(array);

//Output array
Console.WriteLine();
Console.WriteLine("Entered array:");
OutputArr(array);
Console.WriteLine();

//Entering the maximum length of a value in a cell
Console.WriteLine();
int MaxValue = InputValue("Enter maximum length of the value in the cell:");

int InputValue (string n)
{
    int value;
        Console.Write(n);
        while (!int.TryParse(Console.ReadLine(), out value) || value<=0)
        {
            Console.WriteLine("Error! Value must be tipe of the integer!");
            Console.WriteLine(n);
        }
    return value;
}  

//Creating new sorted array
SortArr(array, array2);

//Output sorted array
Console.WriteLine();
Console.WriteLine("Sorted array: ");
OutputArr(array2);


//Filling the array
void FillArr(string[] arr)
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
        if (arr[i].Length <= MaxValue)
        {
            arr2[i] = arr[i];
        }
    }
}
