using System;

unsafe
{
    byte[] bytes = { 1, 2, 3 };

    fixed (byte* pointerToFirst = bytes)
    {
        Console.WriteLine($"The address of the first array element: {(long)pointerToFirst:X}.");
        Console.WriteLine($"The value of the first array element: {*pointerToFirst}.");
    }
}