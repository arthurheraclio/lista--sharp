// Faça um programa na linguagem Java que receba, pelo teclado, 10 números inteiros maior que 1,
// verifique se cada número fornecido é primo ou não e mostre no console uma mensagem de número
// primo ou de número não primo. Um número é primo quando é divisível apenas por 1 e por ele mesmo. 

// using System;

// public class Primos
// {
//     public static void Main(string[] args)
//     {
        
//         int[] numeros = new int[10];
//         for(int i = 1; i<numeros.Length ; i++)
//         {
//             Console.WriteLine("Escreva aqui 10 números inteiros: ");
//                  int numero = Int32.Parse(Console.ReadLine());
//             for(int j = 2 ; j < numero ; j++)
//             {
                
//                 if(numero% j == 0)
//                 {
//                     Console.WriteLine($"{numero} não é primo");
//                 }
//                 if(numero == 2 || numero == 1 || numero%j != 0)
//                 {
//                     Console.WriteLine($"{numero} é primo");
//                 }
//             }


//         }
//     }
// }