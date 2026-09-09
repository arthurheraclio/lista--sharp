using System;

public class Boletim
{
    public static void Main(string[] args)
    {
        float soma = 0;
        float media;
     float[] notas = new float[3];
    for (int i = 0; i < notas.Length; i++)
    {     
     Console.WriteLine("Escreva aqui sua nota: ");   
     string entrada = Console.ReadLine();
     float notaFloat = float.Parse(entrada);
        soma+= notaFloat;
        //Console.WriteLine(soma);
    }
        media = soma/notas.Length;
        Console.WriteLine($"A média é {media}");
	if(media < 7)
{
Console.WriteLine("Infelizmente, você não obteve a média necessária");
}
if (media >= 7)
{
Console.WriteLine("Parabéns, você foi aprovado!");
}
    }
}