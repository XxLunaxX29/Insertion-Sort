
using Insertion_Sort;
using System;
using System.Diagnostics;


internal class Program
{
    private static Random Random = new Random();

    static void Main(string[] args)
    {
        int size;
        string datas;
        Console.WriteLine("Escribe el numero de elementos que deseas");
        datas = Console.ReadLine();
        while (!int.TryParse(datas, out size) || size <= 0)
        {
            Console.WriteLine("Ingresa un número válido mayor a 0");
            datas = Console.ReadLine();
            
        }
        Order.SwapCount = 0;
        Order.ComparisonCount = 0;

        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        array[i] = Random.Next(0, 101);

        Console.WriteLine("Arreglo desordenado");
        Console.WriteLine(string.Join(", ", array));
        Stopwatch stopwatch = Stopwatch.StartNew();
        Console.WriteLine("--------------------------------------------------------------");
       
        Order.InsertSort(array);
        stopwatch.Stop();

        Console.WriteLine("Arreglo ordenado");
        Console.WriteLine(string.Join(", ", array));
        Console.Write("Intercambios:  ");
        Console.WriteLine(Order.SwapCount.ToString());
        Console.Write("Comparciones:  ");
        Console.WriteLine(Order.ComparisonCount.ToString());
        Console.Write("Tiempo  :");
        Console.WriteLine(stopwatch.Elapsed.ToString());
        Console.ReadKey();
    }
}

