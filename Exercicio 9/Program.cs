using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos deseja alugar? ");
            int quantidadeDeQuartos = int.Parse(Console.ReadLine());
            
            Quarto[] aluguel = new Quarto[quantidadeDeQuartos];

            for (int i = 0; i < quantidadeDeQuartos; i++)
            {
                Console.WriteLine($"\nAluguel #{i + 1}");
                Console.Write("Name: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                aluguel[i] = new Quarto(nome, email, quarto);
            }

            Console.WriteLine();

            for (int i = 0; i < quantidadeDeQuartos; i++)
            {
                if (aluguel[i] != null)
                {
                    Console.WriteLine($"{aluguel[i]}");
                }
            }

            Console.WriteLine("\nPressione qualquer tecla para finalizar");
            Console.ReadKey();
        }
    }
}
