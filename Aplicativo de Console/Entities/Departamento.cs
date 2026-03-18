using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_de_Console.Entities
{
    /// <summary>
    /// Modelo de dados para a entidade Departamento
    /// </summary>
    public class Departamento
    {
        private Guid _id;
        private string _nome;
        private string _sigla;

        public Guid Id
        {
            set
            {
                if (value == Guid.Empty)
                    throw new ArgumentException("Por favor, informe o ID.");
                _id = value;
            }
            get => _id;
        }
        public string Nome
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Por favor, informe o Nome.");
                // Remover espaços em branco nas extremidades antes de validar
                value = value.Trim();
                // Use Unicode letter category to allow accented characters and digits
                var regex = new System.Text.RegularExpressions.Regex(@"^[\p{L}\d\s]{6,50}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("O Nome deve conter entre 6 e 50 caracteres, com letras e numeros.");
                _nome = value;
            }
            get => _nome;
        }
        public string Sigla
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Por favor, informe a Sigla.");
                var regex = new System.Text.RegularExpressions.Regex("^[A-Za-z0-9]{4,10}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("A Sigla deve conter entre 4 e 10 caracteres, com letras e numeros.");
                _sigla = value;
            }
            get => _sigla;
        }
    }
}
