﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!!!!");

int[] arr = { 1, 2, 3, 4, 5 };
Console.WriteLine(GetAvg(arr));

static double GetAvg(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }

    return sum / arr.Length;
}
Console.WriteLine("This is a modification123");