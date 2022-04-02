using System;

public class main 
{
    public static void Main()
    {
        int[][] tablica = new int[4][];
        tablica[0] = new int[4] {1,2,3,4};
        tablica[1] = new int[2] {5,6};
        tablica[2] = new int[3] {7,8,9};
        tablica[3] = new int[1] {10};

        for (int i = 0; i<tablica.Length; i++) 
        {
            Console.WriteLine(" numer wiersza [{0}]", i);
            for (int j = 0; j < tablica[i].Length; j++) 
            {
                Console.WriteLine("[{0}]", tablica[i][j]);
            }
             Console.WriteLine("");
        }
    }
}