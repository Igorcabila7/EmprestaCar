namespace Models;

public record Carro(string matricula,  string marca, string modelo, string tipo,string cor, string tipo_caixa, string tipo_motor, string tipo_combustivel, List<Endereco> endereco);
public record   Endereco(string bairro, string provincia, string Pais,string Municipio, string? num_endereco);