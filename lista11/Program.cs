using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista11PR2
{
    internal class Program
    {
        public static void Exercicio1()
        {
            int[] vet = new int[1000];

            Random random = new Random();
            bool achei = true;
            for (int i = 0; i < 1000; i++)
            {
                vet[i] = random.Next(1, 1000);
            }
            do
            {
                Console.WriteLine(" digite o numero que deseja descobrir: ");
                int num = int.Parse(Console.ReadLine());

                for (int i = 0; i < 1000; i++)
                {
                    vet[i] = random.Next(1, 1000);
                    if (vet[i] == num)
                    {
                        achei = false;
                        Console.WriteLine("o numero digitado esta no vetor posiçao{0}", i);
                        break;
                    }



                }
                if (achei)
                    Console.WriteLine("o numero digitado nao foi encontrado!");
            } while (achei);
        }
        public static void Exercicio2()
        {
            int numero = 0;
            int[] vet = new int[2000];

            Random random = new Random();

            for (int i = 0; i < 2000; i++)
            {
                vet[i] = random.Next(1, 20);
            }
            Console.WriteLine(" digite o numero que deseja descobrir: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < 2000; i++)
            {
                vet[i] = random.Next(1, 2000);
                if (vet[i] == num)
                {

                    Console.WriteLine("o numero digitado esta no vetor posiçao{0}", i);
                    numero++;
                }



            }
            Console.WriteLine("o numero repete: " + numero);

        }
        public static void Exercicio3()
        {

            int[] vet = new int[10];
            int[] vet2 = new int[10];

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                vet[i] = random.Next(1, 20);
                if (i % 2 == 0)
                {
                    vet2[i] = vet[i] / 2;


                }
                else
                    vet2[i] = vet[i] * 3;
            }
            for (int i = 0; i < 10; i++)
            {

                Console.Write(vet[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(vet2[i] + " ");

            }
            Console.WriteLine();

        }
        public static void Exercicio4()
        {
            int[] vet;

            vet = new int[5000];
            Random rand = new Random();

            for (int i = 0; i < 5000; i++)
            {

                vet[i] = rand.Next(1, 40);

            }
            Console.WriteLine("digite um número: ");


            for (int i = 0; i < 5000; i++)
            {
                if (vet[i] % 2 != 0 && vet[i] % 3 != 0 && vet[i] % 5 != 0)
                {
                    Console.WriteLine("números primos {0}", vet[i]);

                }




            }
            static void Main(string[] args)

            {
                int menuzin;
                do
                {
                    Console.WriteLine("========MENU=========");
                    Console.WriteLine("Digite 0 para sair");
                    Console.WriteLine("exercicio 1");
                    Console.WriteLine("exercicio 2");
                    Console.WriteLine("exercicio 3");
                    Console.WriteLine("exercicio 4");



                    menuzin = int.Parse(Console.ReadLine());

                    switch (menuzin)
                    {
                        case 0:
                            Console.WriteLine("Obrigada por utilizar o sistema");
                            break;
                        case 1:
                            Exercicio1();
                            break;
                        case 2:
                            Exercicio2();
                            break;
                        case 3:
                            Exercicio3();
                            break;
                        case 4:
                            Exercicio4();
                            break;



                        default:
                            Console.WriteLine("Exercicio invalido");
                            break;
                    }


                } while (menuzin != 0);
            }
        }
    }
}
    

