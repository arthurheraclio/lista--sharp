using System;
using System.Runtime.CompilerServices;

public class Eleicoes
{
    public static void Main(string[] args)
    {
        int Lulonaro = 0;
        int Bolsolula = 0;
        int Getulino = 0;
        Console.WriteLine ("Escreva a quantidade de eleitores: ");
        
        int numEleitores = Int32.Parse(Console.ReadLine());
        int[] eleitores = new int[numEleitores];
        for (int i = 0 ; i < numEleitores ; i++)
        {
            Console.WriteLine("Meu voto vai para: ");
            int voto = Int32.Parse(Console.ReadLine());
        if (voto == 13)
        {
            Lulonaro+=1;
        }
        if (voto == 22)
        {
            Bolsolula+=1;
        }
        if (voto == 24)
        {
            Getulino+=1;
        }
        }

        Console.Write($"Lulonaro: {Lulonaro}, Bolsolula: {Bolsolula}, Getulino: {Getulino}");
        
    }
}