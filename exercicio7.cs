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
            
            while(i < notas.Length)
            {
              notas[i] += notas[i + 1];
            }
            Console.Write(soma);
           float soma = notas[i] + notas[i];
           Console.Write(soma);
            // foreach (float nota in notas)
            // {
            //    // float inicio = 0;
            //     float temp += nota;
            //     //float media = soma/notas.Length;
            //     Console.Write(soma);
            // }
            
        }
    }
    
}