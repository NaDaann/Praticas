using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratica3
{
    class TestaLista
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();
            int c = 0;
            int cc;
            string name = "";
            int valor_verificar;

            while (c != 4) {
                Console.WriteLine("Digite a opção desejada:\n" +
                    "1) Inserir\n" +
                    "2) Pesquisar\n" +
                    "3) Imprimir lista\n" +
                    "4) Sair");
                c = Convert.ToInt32(Console.ReadLine());

                while (c == 1)
                {
                    Console.WriteLine("\nDigite o nome da pessoa que deseja inserir:");
                    name = Console.ReadLine();
                    Console.Write("\nDigite o valor que deseja inserir: ");
                    cc = Convert.ToInt32(Console.ReadLine());
                    valor_verificar = cc;
                    l.Inserir(new NoLista(cc),name);
                    Console.WriteLine($"\n\nValor {cc} inserido com sucesso");
                    Console.WriteLine("\n\nDeseja inserir mais algum valor? (Digite 1 para Sim e 2 para Não)");
                    cc = Convert.ToInt32(Console.ReadLine());
                    if (cc == 1)
                    {
                        c = 1;
                    }
                    else if (cc == 2)
                    {
                        c = 6;
                    }
                    else
                    {
                        Console.WriteLine("\n\nValor digitado é diferente da resposta desejada, voltando ao menu principal..\n\n");
                        c = 6;
                    }

                }
                while (c == 2) {
                    Console.Write("Digite um nº a ser pesquisado: ");
                    c = Convert.ToInt32(Console.ReadLine());

                    NoLista n = l.Pesquisar(c);
                    if (n == null) { 
                        Console.WriteLine("\nValor não encontrado!");
                       Console.WriteLine("\nDeseja voltar ao menu? (Digite 1 para Sim e 2 para Não)");
                       cc = Convert.ToInt32(Console.ReadLine());
                        if (cc == 1) c = 2;
                        else if (cc == 2) c = 6;
                        else
                        {
                            Console.WriteLine("\n\nValor digitado é diferente da resposta desejada, voltando ao menu principal..\n\n");
                            c = 6;
                        }

                    }

                    else {
                        Console.WriteLine("\n\nValor encontrado: " + n.chave);
                        Console.WriteLine("\n\nDeseja pesquisar outro número?(Digite 1 para Sim e 2 para Não)");
                        cc = Convert.ToInt32(Console.ReadLine());
                        if (cc == 1)
                        {
                            c = 2;
                        }
                        else if (cc == 2)
                        {
                            c = 6;
                        }
                        else
                        {
                            Console.WriteLine("\n\nValor digitado é diferente da resposta desejada, voltando ao menu principal..\n\n");
                            c = 6;
                        }

                    }
                    
                }
                if(c == 3)
                {
                   
                    Console.WriteLine($"Imprimindo todos os valores encontrados\n\n");
                    l.Imprimir();
                    Console.WriteLine("\n\nVoltando ao menu principal...\n\n");
                        c = 6;
                   
                    
                }
                
            }
        }
    } 
}
