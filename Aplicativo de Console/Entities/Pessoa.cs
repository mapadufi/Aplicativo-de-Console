using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Aplicativo_de_Console.Entities
{
    /// <summary>
    /// Modelo de dados para a entidade Pessoa
    /// </summary>
    public class Pessoa
    {
        private Guid _id;
        private string _nome;

        ///<summary>
        /// Método de encapsulamento
        ///</summary>
        public Guid Id
        {
            set {
                /*Formato do ID: 00000000-0000-0000-0000-000000000000*/
                if (value == Guid.Empty)
                {
                    throw new ArgumentException("Por favor, informe o ID.");
                }
                _id = value; }
            get => _id;
            
        }
        public string Nome
        {
            set { 
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Por favor, informe o Nome.");
                // Use Unicode letter category to allow accented characters and spaces.
                var regex = new Regex(@"^[\p{L}\s]{8,100}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("O Nome deve conter entre 8 e 100 caracteres, apenas letras e espaços.");
                _nome = value; }

            get => _nome;
            
        }
    }
}
