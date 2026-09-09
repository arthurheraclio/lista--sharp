using System;
using System.Diagnostics.CodeAnalysis;

class MediaDeNotas
{
    static void Main(string[] args)
    {
        
        float[] notas = new float[3];
        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write("Escreva aqui as notas: ");
            string notaString = Console.ReadLine();
            notas[i] = float.Parse(notaString);
            float somaNotas;
            float soma = 0;
            foreach (float nota in notas)
            {
             soma += nota;
            }
            float media = soma/notas.Length;
            Console.WriteLine($"A sua média é {media}");
            if(media < 7)
            {
                Console.WriteLine("Infelizmente você não passou");
            }
            if(media >= 7)
            {
                Console.WriteLine("Parabéns, você passou!");
            }
        }
    }
    
}