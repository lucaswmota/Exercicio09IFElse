using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09IFElse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Informe seu peso: ");
                double peso = double.Parse(Console.ReadLine());

                if (peso > 0)
                {
                    Console.Write("Informe sua altura: ");
                    double altura = double.Parse(Console.ReadLine());

                    if (altura > 0)
                    {
                        double IMC = peso / (altura * altura);

                        if (IMC < 22)
                        {
                            Console.WriteLine("Peso abaixo do adequado. IMC: " + IMC.ToString("F2"));                            
                        }
                        else if (IMC >= 22 && IMC <= 27)
                        {
                            Console.WriteLine("Peso Adequado. IMC: " + IMC.ToString("F2"));
                        }
                        else
                            Console.WriteLine("Acima do Peso. IMC: " + IMC.ToString("F2"));
                    }
                    else
                    {
                        Console.WriteLine("Insira um valor maior do que 0 (Zero).");
                    }
                }
                else
                {
                    Console.WriteLine("Insira um valor maior do que 0 (Zero).");
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Insira apenas numeros.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            finally
            {
                Console.WriteLine("Programa encerrado.");
                Console.ReadKey();
            }
        }
    }
}
