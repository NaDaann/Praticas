using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratica2
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Fila inserir_cliente = new Fila(5);
            Fila inserir_cliente_pag = new Fila(5);
            Fila inserir_cliente_enco = new Fila(5);
            int value_menu = 0; 
            void enun(){
                Console.WriteLine("Digite sua opção sendo 1 para " +
              "inserção de cliente na fila de pedidos \n" +
              "2 para remoção de cliente da fila de pedidos \n" +
              "3 para remoção de cliente da fila de pagamentos \n" +
              "4 para remoção de cliente da fila de encomendas \n" +
              "5 para sair");
                value_menu = int.Parse(Console.ReadLine());


            }
            int valor = value_menu;
            string opcao = "";
            void loop()
            {
                
                while (value_menu != 5)
                {

                    switch (value_menu)
                    {
                        case 1:

                            if (inserir_cliente.Cheia())
                            {
                                Console.WriteLine($"ERRO: Fila de clientes cheia, deseja desinfileirar o Primeiro cliente (Digite Y para sim e N para não)?");
                                opcao = Console.ReadLine();

                                if (opcao == "Y")
                                {
                                    valor = inserir_cliente.Desenfileirar();
                                    Console.WriteLine($"Cliente {valor} desinfileirado");
                                }
                                else if (opcao == "N")
                                {
                                    Console.WriteLine("Saindo da aplicação...");
                                    value_menu = 5;

                                }
                            }
                            else {
                                valor++;
                                 inserir_cliente.Enfileirar(valor);

                                Console.WriteLine($"\n\n\nCliente {valor} inserido\n\n\n");

                                enun();
                            }
                            break;
                        case 2:
                            if (inserir_cliente_pag.Cheia())
                            {
                                Console.WriteLine($"ERRO: Fila de pagamentos cheia, deseja desinfileirar o Primeiro cliente (Digite Y para sim e N para não)?");
                                opcao = Console.ReadLine();

                                if (opcao == "Y")
                                {
                                    valor = inserir_cliente_pag.Desenfileirar();
                                    Console.WriteLine($"Cliente {valor} desinfileirado");
                                }
                                else if (opcao == "N")
                                {
                                    Console.WriteLine("Saindo da aplicação...");
                                    value_menu = 5;

                                }
                            }   
                          
                              
                            else
                            {
                                valor = inserir_cliente.Desenfileirar();
                                Console.WriteLine("\n\n\nDesinfileirando o cliente " + valor);
                                Console.WriteLine("\nEnfileirando na fila de pagamento");
                                inserir_cliente_pag.Enfileirar(valor);
                                Console.WriteLine($"\n\n\nCliente {valor} inserido na fila de pagamento\n\n\n");
                                enun();
                            } 
                            if (inserir_cliente.Vazia())
                            {
                                Console.WriteLine("\n\n\nErro: Fila de clientes vazia");
                                enun();

                            }

                            break;
                        case 3:
                            if (inserir_cliente_enco.Cheia())
                            {
                                Console.WriteLine($"ERRO: Fila de encomendas cheia, deseja desinfileirar o Primeiro cliente (Digite Y para sim e N para não)?");
                                opcao = Console.ReadLine();

                                if (opcao == "Y")
                                {
                                    valor = inserir_cliente_enco.Desenfileirar();
                                    Console.WriteLine($"Cliente {valor} desinfileirado");
                                }
                                else if (opcao == "N")
                                {
                                    Console.WriteLine("Saindo da aplicação...");
                                    value_menu = 5;

                                }
                            }   
                                else
                                {
                                    valor = inserir_cliente_pag.Desenfileirar();
                                    Console.WriteLine("\n\n\nDesinfileirando o cliente " + valor);
                                    inserir_cliente_enco.Enfileirar(valor);
                                    Console.WriteLine("\nEnfileirando na fila de encomenda\n\n\n");
                                    Console.WriteLine($"\n\n\nCliente {valor} inserido na fila de encomendas\n\n\n");
                                enun();
                                }if (inserir_cliente_pag.Vazia())

                                {
                                    Console.WriteLine("\n\n\nErro: Fila de pagamento vazia\n\n\n");
                                    enun();
                                }
                            

                            break;
                        case 4:
                            if (inserir_cliente_enco.Vazia())

                            {
                                Console.WriteLine("\n\n\nErro: Fila de encomenda vazia\n\n\n");
                                enun();
                            }
                            else
                            {
                                valor = inserir_cliente_enco.Desenfileirar();
                               
                                Console.WriteLine("\n\n\nDesinfileirando o cliente "+valor+ " da fila de encomendas...\n\n\n");
                                Console.WriteLine($"\n\n\nCliente {valor} desinfileirado\n\n\n");

                                enun();
                            }
                            break;
                        default:
                            enun();
                            break;

                    }
                    
                }
            }
            enun();
            loop();
            
        }
      }
    }

