using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista11pr_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        //    //exercicio 1
        //    int[] numeros = new int[1000];
        //    Random random = new Random();

        //    for (int i = 0; i < 1000; i++)
        //    {
        //        numeros[i] = random.Next(1, 1001);
        //    }

        //    int tentativa;
        //    bool numeroEncontrado = false;

        //    do
        //    {
        //        Console.Write("Digite um número para tentar adivinhar: ");
        //        tentativa = Convert.ToInt32(Console.ReadLine());

        //        for (int i = 0; i < 1000; i++)
        //        {
        //            if (numeros[i] == tentativa)
        //            {
        //                numeroEncontrado = true;
        //                break;
        //            }
        //        }

        //        if (numeroEncontrado)
        //        {
        //            Console.WriteLine("Parabéns! Você adivinhou o número.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Número não encontrado. Tente novamente.");
        //        }

        //    } while (!numeroEncontrado);

        //    Console.WriteLine("Pressione qualquer tecla para sair.");
        //    Console.ReadKey();

        //    //exercicio 2

        //    int[] numeros = new int[20000];
        //    Random random = new Random();

        //    for (int i = 0; i < 20000; i++)
        //    {
        //        numeros[i] = random.Next(1, 1001);
        //    }

        //    int numeroEscolhido;
        //    int contador = 0;

        //    do
        //    {
        //        Console.Write("Digite um número para contar as ocorrências (digite 0 para sair): ");
        //        numeroEscolhido = Convert.ToInt32(Console.ReadLine());

        //        if (numeroEscolhido != 0)
        //        {
        //            contador = 0;

                   
        //            for (int i = 0; i < 20000; i++)
        //            {
        //                if (numeros[i] == numeroEscolhido)
        //                {
        //                    contador++;
        //                }
        //            }

        //            Console.WriteLine($"O número {numeroEscolhido} aparece {contador} vezes no vetor.");
        //        }

        //    } while (numeroEscolhido != 0);

        //    Console.WriteLine("Programa encerrado.");

        //    Console.WriteLine("Pressione qualquer tecla para sair.");
        //    Console.ReadKey();

        //    //exercicio 3

        //    int[] vetorOriginal = new int[10];
        //    int[] vetorModificado = new int[10];
        //    int indice = 0;

        //    do
        //    {
        //        Console.Write("Digite um número inteiro e positivo: ");
        //        int numero = Convert.ToInt32(Console.ReadLine());

        //        if (numero > 0)
        //        {
        //            vetorOriginal[indice] = numero;

        //            if (indice % 2 == 0)
        //            {
        //                vetorModificado[indice] = numero / 2;
        //            }
        //            else
        //            {
        //                vetorModificado[indice] = numero * 3;
        //            }

        //            indice++;
        //        }

        //    } while (indice < 10);

        //    Console.WriteLine("Vetor Original:");
        //    ImprimirVetor(vetorOriginal);

        //    Console.WriteLine("Vetor Modificado:");
        //    ImprimirVetor(vetorModificado);

        //    Console.WriteLine("Pressione qualquer tecla para sair.");
        //    Console.ReadKey();
        //}

        //static void ImprimirVetor(int[] vetor)
        //{
        //    for (int i = 0; i < vetor.Length; i++)
        //    {
        //        Console.Write(vetor[i] + " ");
        //    }
        //    Console.WriteLine();
        //    Console.ReadKey();

        //    //exercicio 4

        //    int[] numeros = new int[5000];
        //    int indice = 0;

        //    do
        //    {
        //        Console.Write("Digite um número inteiro: ");
        //        int numero = Convert.ToInt32(Console.ReadLine());

        //        numeros[indice] = numero;
        //        indice++;

        //    } while (indice < 5000);

        //    Console.WriteLine("Números primos encontrados:");

        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        if (EhPrimo(numeros[i]))
        //        {
        //            Console.WriteLine(numeros[i]);
        //        }
        //    }

        //    Console.WriteLine("Pressione qualquer tecla para sair.");
        //    Console.ReadKey();
        //}

        //static bool EhPrimo(int numero)
        //{
        //    if (numero < 2)
        //    {
        //        return false;
        //    }

        //    for (int i = 2; i <= Math.Sqrt(numero); i++)
        //    {
        //        if (numero % i == 0)
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //    Console.ReadKey(true);
        }
    }
}
