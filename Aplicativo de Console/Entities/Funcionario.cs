using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Aplicativo_de_Console.Entities
{
    /// <summary>
    /// Modelo de dados para a entidade Funcionario
    ///</summary>
    public class Funcionario : Pessoa
    {
            private string _cpf;
            private string _matricula;
            private decimal _salario;
            private Departamento _departamento;

            /// <summary>
            /// Encapsulamento
            /// </summary>
            public string Cpf
            {
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new ArgumentException("Por favor, informe o CPF.");
                    var regex = new Regex("^[0-9]{11}$");
                    if (!regex.IsMatch(value))
                        throw new ArgumentException("O CPF deve conter exatamente 11 dígitos numéricos.");
                    _cpf = value;
                }
                get => _cpf;
            }
            public string Matricula
            {
                set
                { 
                    if(string.IsNullOrEmpty(value))
                        throw new ArgumentException("Por favor, informe a Matrícula.");
                    var regex = new Regex("^[A-Za-z0-9]{6,10}$");
                    if (!regex.IsMatch(value))
                        throw new ArgumentException("A Matrícula deve conter entre 6 e 10 caracteres alfanuméricos, sem espaços.");
                    _matricula = value;
                }
                get => _matricula;
            }
            public decimal Salario
            {
                set
                {
                    if (value <= 0)
                        throw new ArgumentException("O Salário deve ser um valor maior que zeros.");
                    _salario = value;
                }
                get => _salario;
            }
            public Departamento Departamento
            {
                set
                {
                    if (value == null)
                        throw new ArgumentException("Por favor, informe o Departamento.");
                    _departamento = value;
                }
                get => _departamento;
        }
    }
}
