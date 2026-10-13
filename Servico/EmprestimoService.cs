using Models;

namespace Servico;

public sealed class EmprestimoService
{
    private readonly Dictionary<(int ProprietarioId, string Matricula), Emprestimo> _emprestimosAtivos = new();

    public Emprestimo Emprestar(Condutor condutor, Proprietario proprietario, string matricula, string datadeVolucao)
    {
        if (!proprietario.Carros.TryGetValue(matricula, out var carro))
        {
            throw new ArgumentException("O proprietario nao possui um carro com essa matricula.", nameof(matricula));
        }

        var chave = (proprietario.id, matricula);
        if (_emprestimosAtivos.ContainsKey(chave))
        {
            throw new InvalidOperationException("Este carro ja esta emprestado.");
        }

        var emprestimo = new Emprestimo(condutor, proprietario, carro, DateTime.UtcNow, datadeVolucao);
        _emprestimosAtivos.Add(chave, emprestimo);
        return emprestimo;
    }

    public bool Devolver(Proprietario proprietario, string matricula)
    {
        return _emprestimosAtivos.Remove((proprietario.id, matricula));
    }
}