

using System.Drawing;

class Program
{

    static void SearchTarget(int[] arr, int t)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] + arr[j] == t) 
                { 
                    Console.WriteLine(i + " " + j);
                
                }
            }
           
            
        }
    }


    static void  ElementArray(int[] arr, int s)
    {
        for (int i = 0; i < s; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Enter size your array and elemenets") ;
        Console.WriteLine("Size:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] ints = new int[size];
         
        Console.WriteLine("Elements:");

        ElementArray(ints, size);

        Console.WriteLine("Введіть значення для пошуку:");
        int target = Convert.ToInt32(Console.ReadLine());

        SearchTarget(ints, target);
    }
}
