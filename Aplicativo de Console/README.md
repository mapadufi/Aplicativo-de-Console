# Aplicativo de Console - Cadastro de Funcionários

Aplicativo de console em C# (.NET 8) para cadastro simples de funcionários com validação e exportação para JSON.

## Descrição

O programa solicita os dados do funcionário (nome, CPF, matrícula, salário) e dados do departamento (nome, sigla), valida as entradas e grava cada registro em `funcionarios.json`.

## Requisitos

- .NET 8 SDK
- Visual Studio 2022/2026 ou qualquer editor que suporte .NET 8

## Como compilar e executar

Pelo terminal (PowerShell):

`dotnet build "Aplicativo de Console.sln"`

`dotnet run --project "Aplicativo de Console/Aplicativo de Console.csproj"`

Ou abra a solução no Visual Studio e execute (F5 ou Ctrl+F5).

## Local de exportação

Os registros são salvos no arquivo:

`C:\Users\kiko\Documents\ProjetoC#\Aplicativo de Console\funcionarios.json`

Se quiser alterar o local, edite o caminho definido em `Aplicativo de Console/Repositories/FunconarioRepository.cs` (variável `directory`).

## Validações importantes

- `Nome` do funcionário: somente letras e espaços, entre 8 e 100 caracteres.
- `CPF`: exatamente 11 dígitos numéricos.
- `Matrícula`: 6 a 10 caracteres alfanuméricos, sem espaços.
- `Salário`: número decimal maior que zero.
- `Nome` do departamento: letras, dígitos e espaços, entre 6 e 50 caracteres.
- `Sigla` do departamento: 4 a 10 caracteres alfanuméricos.

Se alguma validação falhar, o programa exibirá a mensagem de erro e perguntará se deseja tentar novamente.

## Observações

- O arquivo `funcionarios.json` é aberto em modo append: cada registro é escrito em uma nova linha no formato JSON.
- Recomenda-se adicionar um `.gitignore` para ignorar `bin/`, `obj/` e arquivos gerados localmente (por exemplo o próprio `funcionarios.json`).

Exemplo de entradas válidas ao executar o programa:

- Nome: `Marcos Paulo`
- CPF: `12345678901`
- Matrícula: `ABC12345`
- Salário: `4500.00`
- Nome do departamento: `Desenvolvimento`
- Sigla do departamento: `DEV1`

## Melhorias sugeridas

- Tornar o caminho de exportação configurável via arquivo de configuração ou argumento de linha de comando.
- Adicionar tratamento para evitar gravação do arquivo em repositório (mover para pasta fora do projeto).
- Adicionar testes automatizados.

## Licença

Projeto fornecido sem licença específica. Adicione uma licença se desejar publicá-lo.
