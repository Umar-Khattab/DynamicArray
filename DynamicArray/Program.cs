using System;
using array;
class program
{
    public static void Main()
    {
        DynamicArray DA = new DynamicArray(3);
        DA.Add(13);
        DA.Add(39);
        DA.Add(75);
        Console.WriteLine($"number of elments which assigned : {DA.Length()}"); Console.WriteLine($"Array length : {DA.StorageLength()}");//Before Expanding
        DA.Add(67);
        Console.WriteLine($"number of elments which assigned : {DA.Length()}"); Console.WriteLine($"Array length : {DA.StorageLength()}");//After Expanding
        DA.Print();
    }
}