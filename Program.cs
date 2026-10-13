using Models;
using Servico;

var contactos = new Dictionary<string, Contactos>
{
  { "principal", new Contactos("igor@example.com", "+244950000000", "+244950000000") }
};

var enderecos = new Dictionary<string, Endereco>
{
  { "casa", new Endereco("28 de Agosto", "Luanda", "Angola", "Belas", "2344") }
};

var carros = new Dictionary<string, Carro>
{
  {
    "AA-11-BB",
    new Carro(
      "AA-11-BB", "Kia", "K7", "Sedan", "Azul", "Automatica", "Selado",
      "Gasolina",
      new List<Endereco>
      {
        new Endereco("28 de Agosto", "Luanda", "Angola", "Belas", "2344")
      })
  }
};

Proprietario proprietario1 = UsuarioService.CriarProprietario(
  "Igor", 18, "1234", "123456789", contactos, enderecos, carros);

Condutor condutor1 = UsuarioService.CriarCondutor(
  "Ana", 25, "5678", "CD-12345", contactos, enderecos);

Console.WriteLine($"{proprietario1.Tipo}: {proprietario1.nome}");
Console.WriteLine($"{condutor1.Tipo}: {condutor1.nome}");
proprietario1.MostrarPerfil();

var emprestimoService = new EmprestimoService();
var emprestimo = condutor1.EmprestarCarro(proprietario1, "AA-11-BB", emprestimoService, "2026-10-18");
Console.WriteLine($"{emprestimo.Condutor.nome} emprestou o carro {emprestimo.Carro.matricula} de {emprestimo.Proprietario.nome} em {emprestimo.DataEmprestimo:u} até {emprestimo.DataDevolucao}.");

