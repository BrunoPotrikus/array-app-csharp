﻿using System;

public class Program
{
    public static void Main(string[] args)
    {
        var meuArray = new int[5] { 1, 2, 3, 4, 5 };
        meuArray[0] = 12;

        Console.WriteLine(meuArray[0]);
        Console.WriteLine(meuArray[1]);
        Console.WriteLine(meuArray[2]);
        Console.WriteLine(meuArray[3]);
        Console.WriteLine(meuArray[4]);
    }
}