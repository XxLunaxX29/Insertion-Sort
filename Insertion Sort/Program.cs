
internal class Program
{
    
    static void Main(string[] args)
    {
        Console.Write("Arreglo desordenado :"); 
        int[] arr = { 5, 7, 2, 8, 3, 9, 15};
        Console.WriteLine(string.Join(", ", arr));
        for (int i = 1; i < arr.Length; i++)
        {
            int actual = arr[i];
                
            int j = i-1;
            while (j >= 0 && arr[j] > actual)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j+1] = actual;
        }

        Console.WriteLine("__________________________");
        Console.Write("Arreglo ordenado :");
        Console.WriteLine(string.Join(", ", arr));   
        Console.ReadKey();
    }
}

