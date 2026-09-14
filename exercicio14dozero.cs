// Faça um programa na linguagem Java que receba, pelo teclado, 10 números inteiros maior que 1,
// verifique se cada número fornecido é primo ou não e mostre no console uma mensagem de número
// primo ou de número não primo. Um número é primo quando é divisível apenas por 1 e por ele mesmo. 

using System;

public class Primos
{
    static void Main(string[] args)
    {
        for(int i = 0 ; i < 10 ; i++ )
        {
        Console.Write("Escreva aqui 10 números inteiros: ");
        int numerosRecebidos = Int32.Parse(Console.ReadLine());
        if(numerosRecebidos == 2)
        {
            Console.WriteLine("É primo");
        }
        //Console.WriteLine(numerosRecebidos);
        if(numerosRecebidos != 2 && numerosRecebidos%1 == 0 && numerosRecebidos%numerosRecebidos == 0 && numerosRecebidos%2 != 0 && numerosRecebidos%3 != 0 && numerosRecebidos%5 != 0)
            {
                Console.WriteLine("É primo");
            } else
            {
                Console.WriteLine("Não é primo");
            }
        }
    
        

    }
}