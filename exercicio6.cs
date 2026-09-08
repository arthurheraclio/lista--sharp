// Faça um programa na linguagem Java que pergunte, pelo teclado, o preço de três produtos e informe, no
// console, qual produto você deve comprar, sabendo que a decisão de comprar um produto é sempre pelo
// mais barato.

using System;

class Pechincha
{
    static void Main(string[] args)
    {
        Console.WriteLine("Preço do Produto 1: ");
        string precoUm = Console.ReadLine();
        float preco1 = float.Parse(precoUm);
        Console.WriteLine("Preço do Produto 2: ");
        string precoDois = Console.ReadLine();
        float preco2 = float.Parse(precoDois);
        Console.WriteLine("Preço do Produto 3: ");
        string precoTres = Console.ReadLine();
        float preco3 = float.Parse(precoTres);

        float[] precos = new float[3];
        precos = new float[] {preco1, preco2, preco3};
        // precos.Append(preco1);
        // precos.Append(preco2);
        // precos.Append(preco3);

        Console.Write(string.Join(", ", precos));

        for (int i = 0; i = precos.Length; i++)
        {
            
        }

    }
}