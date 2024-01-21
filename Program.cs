using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace PTI;

class Program
{
    static void Main(string[] args)
    {
        bool funcionando = true;
        GerenciadorEstoque gerenciador = new GerenciadorEstoque();

        Console.WriteLine("\nCONTROLE DE ESTOQUE - ELETRONICOS APPLE");

        while (funcionando == true)
        {
            Console.WriteLine("\n [1] Novo");
            Console.WriteLine(" [2] Listar Produtos");
            Console.WriteLine(" [3] Remover Produtos");
            Console.WriteLine(" [4] Entrada Estoque");
            Console.WriteLine(" [5] Saída Estoque");
            Console.WriteLine(" [0] Sair");
            Console.Write(" Escolha uma opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 0)
            {
                Console.WriteLine("Saindo...");
                funcionando = false;
            }
            else if (opcao == 1)
            {
                Produtos p1 = new Produtos();

                Console.WriteLine("Digite o nome do produto: ");
                p1.Nome = Console.ReadLine();
                Console.WriteLine("Informe o preço (em R$):");
                p1.Preco = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe a quantidade:");
                p1.Quantidade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe a capacidade (256/512/1024):");
                p1.Armazenamento = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe a memória RAM (8/16/32):");
                p1.MemoriaRam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o estado (Novo/Recondicionado):");
                p1.Estado = Console.ReadLine();

                gerenciador.Adicionar(p1);
            }
            else if (opcao == 2)
            {
                gerenciador.Listar();
            }
            else if (opcao == 3)
            {
                Console.Write("Qual produto deseja remover? ");
                int remove = Convert.ToInt32(Console.ReadLine());
                gerenciador.Remover(remove - 1);
            }
            else if (opcao == 4)
            {
                Console.Write("Digite a posição do produto que deseja aumentar: ");
                int posEntrada = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a quantidade desejada: ");
                int qtdEntrada = Convert.ToInt32(Console.ReadLine());
                gerenciador.Entrada(posEntrada - 1, qtdEntrada);
            }
            else if (opcao == 5)
            {
                Console.Write("Digite a posição do produto que deseja diminuir: ");
                int posSaida = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a quantidade desejada: ");
                int qtdSaida = Convert.ToInt32(Console.ReadLine());
                gerenciador.Saida(posSaida - 1, qtdSaida);
            }
            else
            {
                Console.WriteLine("Opção incorreta...");
            }

        }
    }
}