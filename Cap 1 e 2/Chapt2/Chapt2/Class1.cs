using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Chapt2
{
    internal class Exercicios
    {
        enum DiaSemana
        {
            Segunda,
            Terça,
            Quarta,
            Quinta,
            Sexta,
            Sábado,
            Domingo
        }

        public static void ex7()
        {
            Console.WriteLine(DiaSemana.Segunda);
        }

        enum Valores
        {
            Baixo = 1,
            Medio = 5,
            Alto = 10
        }

        public static void ex8()
        {
            Console.WriteLine((int) Valores.Alto);
        }

        enum EstadoEncomenda
        {
            Pendente,
            Enviada,
            Entregue,
            Cancelada
        }
        public static void ex9()
        {
            EstadoEncomenda estado = EstadoEncomenda.Pendente;

            string msg = estado switch
            {
                EstadoEncomenda.Pendente => "A sua encomenda está pendente de pagamento.",
                EstadoEncomenda.Enviada => "A sua encomenda foi enviada para entrega.",
                EstadoEncomenda.Entregue => "A sua encomenda foi entregue ao destinatário.",
                _ => "A sua encomenda foi cancelada."
            };
            Console.WriteLine(msg);
        }
        


        public static void ex10()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        public static void ex11()
        {
            int[] arr = new int[10];
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * i;
                Console.WriteLine(arr[i]);
            }
        }

        public static void ex12()
        {
            int[,] arr = new int[3,3];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = (i+1) * (j+1);
                }
            }

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        public static void ex13()
        {
            double a = 9.99;
            int b = (int) a;
            Console.WriteLine(b);
        }

        public static void ex14()
        {
            Console.Write("Write a number: ");
            string aRaw = Console.ReadLine();

            if (int.TryParse(aRaw, out int b))
            {
                Console.WriteLine("Input number: " + b);
            }
            else
            {
                Console.WriteLine("Not a number");
            }
        }

        public static void ex19()
        {
            Console.Write("Input your age: ");
            string ageStr = Console.ReadLine();

            if (int.TryParse(ageStr, out int age))
            {
                if (age < 0)
                    Console.WriteLine("Age invalid: can't be less than 0");
                else if (age < 18)
                    Console.WriteLine("Menor");
                else
                    Console.WriteLine("Adulto");
            }
            else
            {
                Console.WriteLine("Not a number");
            }
        }

        public static void ex20()
        {
            int nota = 15;

            if (nota < 10)
            {
                Console.WriteLine("Reprovado");
            }
            else if (nota < 14)
            {
                Console.WriteLine("Suficiente");
            }
            else if (nota < 18)
            {
                Console.WriteLine("Bom");
            } else
            {
                Console.WriteLine("Muito Bom");
            }
        }

        public static void ex21()
        {
            int nota = 20;

            string msg = nota switch
            {
                < 10 => "Reprovado",
                < 14 => "Suficiente",
                < 18 => "Bom",
                _ => "Muito Bom"
            };

            Console.WriteLine(msg);
        }

        public static void ex23()
        {
            int i = 1;
            int total = 0;
            while (i <= 100)
            {
                if ((i % 2) != 0)
                {
                    i++;
                    continue;
                }

                total += i;
                i++;
            }

            Console.WriteLine(total);
        }

        public static void ex24()
        {
            string input;
            int inv = 0;
            do
            {
                Console.Write("Enter input: ");
                input = Console.ReadLine();

                if (input == "")
                {
                    inv++;
                    Console.WriteLine("Invalid Input!");
                }

                if (inv > 1)
                {
                    Console.WriteLine("Invalid input twice; breaking...");
                    break;
                }
                    

                if (input != "sair")
                    Console.WriteLine("Option entered: " + input);
            }
            while (input != "sair");
        }








        public static void ex6()
        {
            Console.WriteLine("Exercício 6 - Ficha Prática 2");

            int x = 6;
            int y = x--;
            Console.WriteLine($"x:{x}, y:{y}");

            x *= 2;
            Console.WriteLine($"x:{x}");

            int z = -3;
            int r = x + y / -z;
            Console.WriteLine($"x:{x}, y:{y}, z:{z}, r:{r}");
        }
    }


}
