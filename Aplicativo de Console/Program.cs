using System;
using Aplicativo_de_Console.Entities;
using Aplicativo_de_Console.Repositories;

namespace Aplicativo_de_Console
{
    /// <summary>
    /// Classe de inicialização do Projeto
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n *** CADASTRO DE FUNCIONARIOS *** \n");
            var funcionario = new Funcionario();
            funcionario.Departamento = new Departamento();

            try
            {
                funcionario.Id = Guid.NewGuid();
                funcionario.Departamento.Id = Guid.NewGuid();
                Console.Write("DIGITE O NOME DO FUNCIONARIO.....: ");
                funcionario.Nome = Console.ReadLine();

                Console.Write("DIGITE O CPF.....................: ");
                funcionario.Cpf = Console.ReadLine();

                Console.Write("DIGITE A MATRICULA...............: ");
                funcionario.Matricula = Console.ReadLine();

                Console.Write("DIGITE O SALARIO.................: ");
                funcionario.Salario = decimal.Parse(Console.ReadLine());
                
                Console.Write("DIGITE O NOME DO DEPARTAMENTO....: ");
                funcionario.Departamento.Nome = Console.ReadLine();

                Console.Write("DIGITE A SIGLA DO DEPARTAMENTO...: ");
                funcionario.Departamento.Sigla = Console.ReadLine();

                //Criando um objeto para a classe FuncionarioRepository
                var funcionarioRepository = new FuncionarioRepository();
                funcionarioRepository.Exportar(funcionario);



                // Mensagem de confirmação após cadastro bem-sucedido
                Console.WriteLine("\nCADASTRO EFETUADO COM SUCESSO!\n");
                Console.WriteLine("Resumo do cadastro:");
                Console.WriteLine($"ID: {funcionario.Id}");
                Console.WriteLine($"Nome: {funcionario.Nome}");
                Console.WriteLine($"CPF: {funcionario.Cpf}");
                Console.WriteLine($"Matrícula: {funcionario.Matricula}");
                Console.WriteLine($"Salário: {funcionario.Salario:C}");
                Console.WriteLine($"Departamento: {funcionario.Departamento.Nome} ({funcionario.Departamento.Sigla})");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("\n\tERRO DE VALIDAÇÃO: ");
                Console.WriteLine("\t" + ex.Message);

                Console.Write("\nDESEJA TENTAR NOVAMENTE? (S,N)");
                var opcao = Console.ReadLine();
                if (opcao.Equals("S", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear(); //Limpa a tela do console
                    Main(args); //Inicia novamente o processo de cadastro
                }
                else
                    Console.WriteLine("\nPROGRAMA ENCERRADO. OBRIGADO POR UTILIZAR!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\tOCORREU UM ERRO INESPERADO: " + ex.Message);
            }
            Console.ReadKey();

        }
    }
}