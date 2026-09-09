// using System;

// public class SeraQueAF
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine ("Digite sua primeira nota: ");
//         string notaUm = Console.ReadLine();
//         float nota1 = float.Parse(notaUm);
//         Console.WriteLine("Digite sua segunda nota: ");
//         string notaDois = Console.ReadLine();
//         float nota2 = float.Parse(notaDois);
//         float media = (nota1 + nota2)/2;
//         if(media >= 7)
//         {
//             Console.WriteLine("Parabéns, você foi aprovado!");
//            return; 
//         }
//         if (4 <= media && media < 7)
//         {
//             Console.WriteLine("Infelizmente, você irá para a AF");
//             Console.WriteLine("Digite aqui sua nota da Af: ");
//             string notaAF = Console.ReadLine();
//             float floatAF = float.Parse(notaAF);
//             if((media + floatAF)/2 >=5)
//             {
//                 Console.WriteLine("Parabéns, você foi aprovado!");
//                 return;
//             }
//         }
//         else
//         {
//             Console.WriteLine("Até semestre que vem papai");
//             return;
//         }
    
//     }
// }