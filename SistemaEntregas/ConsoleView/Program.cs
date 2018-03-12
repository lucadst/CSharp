using Modelos;
using System;
using Controllers;

namespace ConsoleView
{
    class Program
    {
        enum OpcoesMenuPrincipal

        {
            CadastrarCliente = 1,
            PesquisarCliente = 2,
            EditarCliente = 3,
            ExcluirCliente = 4,
            LimparTela = 5,
            Sair = 6

        }

        private static OpcoesMenuPrincipal Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("Escolha sua opção");
            Console.WriteLine("");

            Console.WriteLine(" - Clientes - ");
            Console.WriteLine("1 - Cadastrar Novo");
            Console.WriteLine("2 - Pesquisar Cliente");
            Console.WriteLine("3 - Editar Cliente");
            Console.WriteLine("4 - Excluir Cliente");
            Console.WriteLine("");

            Console.WriteLine(" - Geral - ");
            Console.WriteLine("5 - Limpar Tela");
            Console.WriteLine("6 - Sair");
            Console.WriteLine("");

            string opcao = Console.ReadLine();
            return (OpcoesMenuPrincipal)int.Parse(opcao);
        }

        static void Main(string[] args)
        {
            OpcoesMenuPrincipal opcaoDigitada = OpcoesMenuPrincipal.Sair;

            do
            {

                opcaoDigitada = Menu();

                switch (opcaoDigitada)
                {
                    case OpcoesMenuPrincipal.CadastrarCliente:
                        Cliente c = CadastrarCliente();

                        ClienteController cc = new ClienteController();
                        cc.SalvarCliente(c);

                        ExibirDadosCliente(c);
                        break;

                    case OpcoesMenuPrincipal.PesquisarCliente:
                        PesquisarCliente();
                        break;

                    case OpcoesMenuPrincipal.EditarCliente:
                        break;

                    case OpcoesMenuPrincipal.ExcluirCliente:
                        break;

                    case OpcoesMenuPrincipal.LimparTela:
                        break;

                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Opção inválida, digite novamente");
                        break;
                };
            }
            while (opcaoDigitada != OpcoesMenuPrincipal.Sair);
        }

        private static Cliente CadastrarCliente()
        {
            Cliente cli = new Cliente();
            Endereco end = new Endereco();

            Console.WriteLine("");
            Console.WriteLine(" - Cadastro de Cliente - ");
            Console.WriteLine("");

            Console.WriteLine("Digite o nome: ");
            cli.Nome = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Digite o cpf: ");
            cli.Cpf = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Digite o endereço: ");
            Console.WriteLine("Rua: ");
            end.Rua = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Número: ");
            end.Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Complemento: ");
            end.Complemento = Console.ReadLine();
            Console.WriteLine("");

            cli._Endereco = end;

            return cli;
        }

        private static Cliente PesquisarCliente()
        {
            // TODO : Fazer depois
            return new Cliente();
        }

        private static void ExibirDadosCliente(Cliente cliente)
        {
            Console.WriteLine("");
            Console.WriteLine("--- DADOS CLIENTE --- ");
            Console.WriteLine("ID: " + cliente.PessoaID);
            Console.WriteLine("Nome: " + cliente.Nome);
            Console.WriteLine("Cpf: " + cliente.Cpf);

            Console.WriteLine("- Endereço -");
            Console.WriteLine("Rua: " + cliente._Endereco.Rua);
            Console.WriteLine("Num: " + cliente._Endereco.Numero);
            Console.WriteLine("Compl.: " + cliente._Endereco.Complemento);
            Console.WriteLine("------------");
            Console.WriteLine("");
        }
    }
}