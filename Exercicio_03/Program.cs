using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desenvolva uma calculadora, onde será necessário entrar com a operação, primeiro e segundo valor, exiba o resultado na tela.
            double v1, v2, Resultado = 0;
            char Operacao;

            Console.WriteLine("Entre com a operação-->");
            Console.WriteLine("+ Adição-------------->");
            Console.WriteLine("- Subtração----------->");
            Console.WriteLine("* Multiplicação------->");
            Console.WriteLine("/ Divisão------------->");
            Console.WriteLine("-----------------------");

            Console.WriteLine();

            Console.Write("Operação: ");

            char.TryParse(Console.ReadLine(), out Operacao);

            Console.WriteLine();
            Console.Write("Informe o primeiro valor: ");
            double.TryParse(Console.ReadLine(), out v1);

            Console.WriteLine();
            Console.Write("Informe o segundo valor: ");
            double.TryParse(Console.ReadLine(), out v2);

            Console.WriteLine();
            Console.WriteLine();

            switch (Operacao)
            {
                case '+':
                    Resultado = Adicao(v1, v2);
                    break;

                case '-':
                    Resultado = Subtracao(v1, v2);
                    break;

                case '*':
                    Resultado = Multiplicacao(v1, v2);
                    break;

                case '/':
                    Resultado = Divisao(v1, v2);
                    break;
            }

            Console.WriteLine("Resultado: " +Resultado);

            Console.ReadKey();
        }

        private static Double Adicao(double v1, double v2)
        {
            return (v1 + v2);
        }

        private static Double Subtracao(double v1, double v2)
        {
            return (v1 - v2);
        }

        private static Double Multiplicacao(double v1, double v2)
        {
            return (v1 * v2);
        }

        private static Double Divisao(double v1, double v2)
        {
            return (v1 / v2);
        }
    }
}
