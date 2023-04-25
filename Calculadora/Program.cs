using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        { int continua = 1;
            while (continua == 1) { 

            Console.WriteLine("Insira o valor do primeiro número");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor do segundo número");
                double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1 - adição ");
            Console.WriteLine("2 - subtração ");
            Console.WriteLine("3 - multiplicação ");
            Console.WriteLine("4 - divisão ");
           // Console.WriteLine("5 - porcentagem ");
          //  Console.WriteLine("Potência");
            Console.WriteLine("Selecione a operação");
                int opcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (opcao)
            {
                case 1:
                        double soma = number1 + number2;
                    Console.WriteLine($"{number1} + {number2} = {soma}");
                    break;
                case 2:
                        double sub = number1 - number2;
                    Console.WriteLine($"{number1} - {number2} = {sub}");
                    break;
                case 3:
                        double mult = number1 * number2;
                    Console.WriteLine($"{number1} * {number2} = {mult}");
                    break;
                case 4:
                        double div = number1 / number2;                 
                    Console.WriteLine($"{number1} / {number2} = {div.ToString("N1")}");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
                     
            }
                Console.WriteLine("Deseja continuar? 1 - sim; 2 - para não");
                continua = Convert.ToInt32(Console.ReadLine());
                Console.Clear() ;
                
   
                
            } 
            Console.WriteLine("Fim");

            Console.ReadKey();
        }
    }
}
