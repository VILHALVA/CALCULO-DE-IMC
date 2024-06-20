using System;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar peso do usuário
            Console.WriteLine("Digite seu peso em kg:");
            if (double.TryParse(Console.ReadLine(), out double peso) && peso > 0)
            {
                // Solicitar altura do usuário
                Console.WriteLine("Digite sua altura em metros:");
                if (double.TryParse(Console.ReadLine(), out double altura) && altura > 0)
                {
                    // Calcular IMC
                    double imc = CalcularIMC(peso, altura);

                    // Exibir resultado
                    Console.WriteLine($"Seu IMC é: {imc:F2}");

                    // Classificação do IMC
                    Console.WriteLine(ClassificarIMC(imc));
                }
                else
                {
                    Console.WriteLine("Por favor, insira uma altura válida.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um peso válido.");
            }
        }

        static double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        static string ClassificarIMC(double imc)
        {
            if (imc < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                return "Peso normal";
            }
            else if (imc >= 25 && imc < 29.9)
            {
                return "Sobrepeso";
            }
            else
            {
                return "Obesidade";
            }
        }
    }
}
