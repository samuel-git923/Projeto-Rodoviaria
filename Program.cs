using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRodoviaria
{
    public class Program
    {
        static int ShowMenu()
        {
            Console.WriteLine("1 - Camaçari");
            Console.WriteLine("2 - São Francisco do Conde");
            Console.WriteLine("3 - Lauro de Freitas");
            Console.WriteLine("4 - Simões Filho");
            Console.WriteLine("5 - Candeias");
            Console.WriteLine("6 - Dias d'Ávila");
            Console.WriteLine("7 - Mata de São João");
            Console.WriteLine("8 - Pojuca");
            Console.WriteLine("9 - São Sebastião do Passé");
            Console.WriteLine("10 - Vera Cruz");
            Console.WriteLine("11 - Madre de Deus");
            Console.WriteLine("12 - Itaparica");
            Console.Write("Opção: ");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
            //String destino = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //Um programa que mostra o valor da passagem conforme o local selecionado

            Passageiro p = new Passageiro();
            Console.Write("Passageiro: ");
            p.Nome = Console.ReadLine();

            int op = 0;

                op = ShowMenu();
                Console.Clear();
                switch (op)
                {
                    case 1:
                        p.ExibirDados();
                        Console.WriteLine("Data: " + DateTime.Now.ToString());
                        Console.WriteLine("O valor da passagem é de R$ 69,90.");
                        break;

                    case 2:
                        p.ExibirDados();
                        Console.WriteLine("Data: " + DateTime.Now.ToString());
                        Console.WriteLine("O valor da passagem é de R$ 79,90.");
                        break;

                    case 3:
                        p.ExibirDados();
                        Console.WriteLine("Data: " + DateTime.Now.ToString());
                        Console.WriteLine("O valor da passagem é de R$ 89,90.");
                        break;

                    case 4:
                        p.ExibirDados();
                        Console.WriteLine("Data: " + DateTime.Now.ToString());
                        Console.WriteLine("O valor da passagem é de R$ 99,90.");
                        break;

                    case 5:
                        p.ExibirDados();
                        Console.WriteLine("Data: " + DateTime.Now.ToString());
                        Console.WriteLine("O valor da passagem é de R$ 104,90.");
                        break;

                    case 6:
                        p.ExibirDados();
                        Console.WriteLine("Data: " + DateTime.Now.ToString());
                        Console.WriteLine("O valor da passagem é de R$ 123,90.");
                        break;

                    case 7:
                        p.ExibirDados();
                        Console.WriteLine("Data: " + DateTime.Now.ToString());
                        Console.WriteLine("O valor da passagem é de R$ 58,90.");
                        break;

                    case 8:
                        p.ExibirDados();
                        Console.WriteLine("Data: " + DateTime.Now.ToString());
                        Console.WriteLine("O valor da passagem é de R$ 169,90.");
                        break;


                    case 9:
                        p.ExibirDados();
                        Console.WriteLine("Data: " + DateTime.Now.ToString());
                        Console.WriteLine("O valor da passagem é de R$ 149,90.");
                        break;

                    case 10:
                        p.ExibirDados();
                        Console.WriteLine("Data: " + DateTime.Now.ToString());
                        Console.WriteLine("O valor da passagem é de R$ 122,90.");
                        break;

                    case 11:
                        p.ExibirDados();
                        Console.WriteLine("Data: " + DateTime.Now.ToString());
                        Console.WriteLine("O valor da passagem é de R$ 129,90.");
                        break;

                    case 12:
                        p.ExibirDados();
                        Console.WriteLine("Data: " + DateTime.Now.ToString());
                        Console.WriteLine("O valor da passagem é de R$ 179,90.");
                        break;
                }

            Console.ReadKey();
        }
    }
}