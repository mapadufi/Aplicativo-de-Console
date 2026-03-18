using Aplicativo_de_Console.Entities;
using System.IO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_de_Console.Repositories
{
    /// <summary>
    /// Repositorio de dados para Funcionarios
    /// </summary>
    public class FuncionarioRepository
    {
        /// <summary>
        /// Metodo para gravar dados do funcionario em um arquivo JSON
        /// </summary>
        /// <param name="funcionario"></param>
        public void Exportar(Funcionario funcionario)
        {
            // Serializar os dados do funcionario para o formato JSON
            var json = JsonConvert.SerializeObject(funcionario, Formatting.Indented);

            // Caminho solicitado pelo usuário
            var directory = @"C:\Users\kiko\Documents\ProjetoC#\Aplicativo de Console";
            var filePath = Path.Combine(directory, "funcionarios.json");

            // Garante que o diretório exista
            Directory.CreateDirectory(directory);

            // Abrindo o arquivo para escrita e gravando os dados (append)
            using (var streamWriter = new StreamWriter(filePath, true, Encoding.UTF8))
            {
                streamWriter.WriteLine(json);
            }
        }
    }
}
