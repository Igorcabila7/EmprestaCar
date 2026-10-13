using Models;

namespace Servico;

public sealed record Emprestimo(
	Condutor Condutor,
	Proprietario Proprietario,
	Carro Carro,
	DateTime DataEmprestimo,
    string DataDevolucao);
