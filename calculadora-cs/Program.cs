﻿using System;
using System.Collections.Generic;
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

        public static void interfaceCalculation(char menuChoice)
        {
            int auxChoice = (int)Char.GetNumericValue(menuChoice);
            Console.Clear();
            Console.Write("Calculadora de Console em C# \n---------------------------------\n");

            if (auxChoice >= 1 && auxChoice <= 4)
            {
                Console.Write("Insira o primeiro valor: ");
                double auxA = Convert.ToDouble(Console.ReadLine());
                Console.Write("Insira o segundo valor: ");
                double auxB = Convert.ToDouble(Console.ReadLine());

                if (auxChoice == 1)
                {
                    Console.WriteLine("\nO resultado é: " + calcSum(auxA, auxB));
                    Console.ReadKey();
                } else if (auxChoice == 2)
                {
                    Console.WriteLine("\nO resultado é: " + calcSubtract(auxA, auxB));
                    Console.ReadKey(true);
                } else if (auxChoice == 3)
                {
                    Console.WriteLine("\nO resultado é: " + calcDivide(auxA, auxB));
                    Console.ReadKey(true);
                } else if (auxChoice == 4)
                {
                    Console.WriteLine("\nO resultado é: " + calcMultiply(auxA, auxB));
                    Console.ReadKey(true);
                }
            }
        }

        public static void interfaceMenu()
        {
            Console.Clear();
            Console.Write("Calculadora de Console em C# \n---------------------------------\n");
            Console.WriteLine("1 - Soma    2 - Subtração");
            Console.WriteLine("3 - Divisão 4 - Multiplicação");
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
