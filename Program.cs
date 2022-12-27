using System;

public class Program
{
    public static void Main(string[] args)
    {
        var meuArray = new int[5] { 1, 2, 3, 4, 5 };
        meuArray[0] = 12;

        Console.Clear();
        Console.WriteLine("Percorrendo item a item");
        Console.WriteLine(meuArray[0]);
        Console.WriteLine(meuArray[1]);
        Console.WriteLine(meuArray[2]);
        Console.WriteLine(meuArray[3]);
        Console.WriteLine(meuArray[4]);

        Console.WriteLine();
        Console.WriteLine("Percorrendo com laço for");
        for (var index = 0; index < meuArray.Length; index++)
        {
            Console.WriteLine(meuArray[index]);
        }

        Console.WriteLine();
        Console.WriteLine("Percorrendo com laço foreach");
        foreach (var item in meuArray)
        {
            Console.WriteLine(item);
        }

        var clientes = new Cliente[5];
        clientes[0] = new Cliente(1, "Bruno");

        foreach(var cliente in clientes)
        {
            Console.WriteLine(cliente.Id);
            Console.WriteLine(cliente.Name);
        }

        // Copiando valores de um array para outro
        var arr1 = new int[5];
        var arr2 = new int[5];

        arr1[0] = arr2[0];
        arr2[0] = 10;

        Console.WriteLine(arr1[0]);
        Console.WriteLine(arr1[1]);
    }
}

public struct Cliente
{
    public int Id;
    public string Name;

    public Cliente(int id, string name)
    {
        Id = id;
        Name = name;
    }
}