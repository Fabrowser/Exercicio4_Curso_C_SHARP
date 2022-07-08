using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {


            int opcao = -1;

            while (opcao != 0)
            {
                Console.WriteLine(" [1] - IMPARES \n [2] - INTERVALO(0,20) \n [3] - TESTE \n [4] FATORIAL \n Digite a opção: \n ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Digite um número de algorismos: ");
                    int n = int.Parse(Console.ReadLine());

                    Console.WriteLine("NUMEROS ÍMPARES: \n");
                    for (int i = 0; i <= n; i++)
                    {

                        if (i % 2 != 0)
                        {
                            Console.WriteLine(i);
                        }


                    }
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Digite o numero de algarismos: ");
                    int n = int.Parse(Console.ReadLine());

                        for(int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Digite o numero: \n");
                        int numero = int.Parse(Console.ReadLine());

                        if (numero>=10 && numero <= 20)
                        {
                            Console.WriteLine(numero + " in");
                        }
                        else
                        {
                            Console.WriteLine(numero + " out");
                        }
                    }



                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Digite o numero de testes: ");
                    int n = int.Parse(Console.ReadLine());

                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Digite o 1º numero: \n");
                        int numero1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o 2º numero: \n");
                        int numero2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o 3º numero: \n");
                        int numero3 = int.Parse(Console.ReadLine());

                        double media = ((numero1 * 2 + numero2 * 3 + numero3 * 5)/10);

                        Console.WriteLine("MÉDIA PONDERADA: " + media);
                        
                        


                    }



                }
                else if (opcao == 4)
                {
                    double fatorial=0;
                    Console.WriteLine("Digite um número: ");
                    int n = int.Parse(Console.ReadLine());
                    fatorial = n;

                    for (int i = n; i >1; i--)
                    {
                

                        fatorial = fatorial * (i - 1);

                    }

                    Console.WriteLine(n + "! (FATORIAL) = "+ fatorial);

                }

            }
        }
    }
}

