using System;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio Curva de Conhecimento");
            Console.WriteLine("engenhos.net.br");
            Console.WriteLine(" ");
            Console.WriteLine("Desafio:");
            Console.WriteLine(" ");
            Console.WriteLine("1 - Crie uma aplicação Console que some os números naturais múltiplos de 3 e 5 de uma sequência, seguindo as regras abaixo::");
            Console.WriteLine(" ");
            Console.WriteLine("    - A aplicação deve solicitar um número ao usuário.");
            Console.WriteLine("    - Em seguida a aplicação irá somar todos os números naturais de 0 até o número informado que sejam múltiplos de 3 ou 5.");
            Console.WriteLine("    - No final, deverá ser exibida a soma desses números ao usuário.");
            Console.WriteLine(" ");
            Console.WriteLine("Se for digitado o numero 15 o resultado será 60, pois 3 + 5 + 6 + 9 + 10 + 12 + 15 = 60");
            Console.WriteLine("OBS.: quando um numero for multiplo de 3 e 5 ele será somado apenas uma vez. ");
            Console.WriteLine(" ");
            Console.Write("Entre com um número inteiro, e em seguida pressione a tecla ENTER: ");
            var enterNumber = Console.ReadLine();

            if(int.TryParse(enterNumber, out int number))
            {
                int total = 0;
                for (int i = 0; i <= number; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        total = total + i;
                        //Console.WriteLine("Multiplo: " + i.ToString());
                    }
                }

                Console.WriteLine("Total: " + total.ToString());
            }
            else
            {
                Console.WriteLine("O valor digitado não é um numero inteiro.");
            }            
        }
    }
}

