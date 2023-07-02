using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_cs
{
    internal class Program
    {
        public static double calcSum(double a, double b)
        {
            return (a + b);
        }

        public static double calcSubtract(double a, double b)
        {
            return (a - b);
        }

        public static double calcDivide(double a, double b)
        {
            return (a / b);
        }

        public static double calcMultiply(double a, double b)
        {
            return (a * b);
        }

        public static int calcLcm(int a, int b)
        {
            int auxLarger, lcm;

            if (a > b)
            {
                auxLarger = a;
            } else
            {
                auxLarger = b;
            }

            while (true)
            {
                if ((auxLarger % a == 0) && (auxLarger % b == 0)) {
                    lcm = auxLarger;
                    break;
                }

                auxLarger++;
            }
            return lcm;
        }

        public static List<int> calcFactorization(int a)
        {
            var primes = new List<int>();

            for (int div = 2; div <= a; div++)
            {
                while (a % div == 0)
                {
                    primes.Add(div);
                    a = a / div;
                }
            }

            return primes;
        }

        public static double calcPotentiation(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public static double calcRooting(double a, double b)
        {
            return Math.Pow(b, 1 / a);
        }

        public static void interfaceCalculation(char menuChoice)
        {
            int auxChoice = (int)Char.GetNumericValue(menuChoice);
            Console.Clear();
            Console.Write("Calculadora de Console em C# \n-------------------------------------\n");

            if (auxChoice >= 1 && auxChoice <= 5)
            {
                Console.Write("Insira o primeiro valor: ");
                double auxA = Convert.ToDouble(Console.ReadLine());
                Console.Write("Insira o segundo valor: ");
                double auxB = Convert.ToDouble(Console.ReadLine());

                if (auxChoice == 1)
                {
                    Console.WriteLine("\nO resultado é: " + calcSum(auxA, auxB));
                } else if (auxChoice == 2)
                {
                    Console.WriteLine("\nO resultado é: " + calcSubtract(auxA, auxB));
                } else if (auxChoice == 3)
                {
                    Console.WriteLine("\nO resultado é: " + calcDivide(auxA, auxB));
                } else if (auxChoice == 4)
                {
                    Console.WriteLine("\nO resultado é: " + calcMultiply(auxA, auxB));
                } else if (auxChoice == 5)
                {
                    Console.WriteLine("\nO resultado é: " + calcLcm(Convert.ToInt32(auxA), Convert.ToInt32(auxB)));
                }
                
                Console.Write("\nPressione qualquer tecla para continuar");
                Console.ReadKey();
            } else if (auxChoice == 6)
            {
                Console.Write("Insira o valor: ");
                int auxA = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nO resultado é: ");
                foreach (int fatora in calcFactorization(auxA)) {
                    Console.WriteLine(fatora);
                }

                Console.Write("\nPressione qualquer tecla para continuar");
                Console.ReadKey();
            } else if (auxChoice == 7)
            {
                Console.Write("Insira a base: ");
                double auxA = Convert.ToDouble(Console.ReadLine());
                Console.Write("Insira o expoente: ");
                double auxB = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nO resultado é: " + calcPotentiation(auxA, auxB));

                Console.Write("\nPressione qualquer tecla para continuar");
                Console.ReadKey();
            } else if (auxChoice == 8)
            {
                Console.Write("Insira o índice: ");
                double auxA = Convert.ToDouble(Console.ReadLine());
                Console.Write("Insira o radicando: ");
                double auxB = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nO resultado é: " + calcRooting(auxA, auxB));

                Console.Write("\nPressione qualquer tecla para continuar");
                Console.ReadKey();
            } else if (auxChoice == 0)
            {
                System.Environment.Exit(1);
            } else
            {
                Console.Clear();
                Console.Write("Calculadora de Console em C# \n-------------------------------------\n");
                Console.WriteLine("Opção incorreta");
                Console.Write("\nPressione qualquer tecla para continuar");
                Console.ReadKey();
            }
        }

        public static void interfaceMenu()
        {
            Console.Clear();
            Console.Write("Calculadora de Console em C# \n-------------------------------------\n");
            Console.WriteLine("1 - Soma          2 - Subtração");
            Console.WriteLine("3 - Divisão       4 - Multiplicação");
            Console.WriteLine("5 - MMC           6 - Fatoração");
            Console.WriteLine("7 - Potenciação   8 - Radiciação");
            Console.WriteLine("\n0 - Sair");
            Console.Write("\nSelecione uma opção: ");
            
            interfaceCalculation(Console.ReadKey().KeyChar);

        }
        
        static void Main(string[] args)
        {
            do
            {
                interfaceMenu();
            } while (true);
        }
    }
}