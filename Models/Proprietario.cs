
namespace Models;

public class Proprietario : Usuario
{
    public required string nif{get; set;} = string.Empty;
    public string Tipo {get;init;} = "Proprietario";
    public required Dictionary<string, Carro> Carros {get; set;} = new();

    public override void MostrarPerfil()
    {
        var perfil =new List<string>
       {
           $"{id}",
           $"{nome}",
           $"{Idade}",
           $"{BI}",
           $"{nif}",
           $"{Tipo}"
       };
       Console.WriteLine($"Id:{perfil[0]}\tNome:{perfil[1]}\tIdade:{perfil[2]}\tBI:{perfil[3]}\tNif:{perfil[4]}\tTipo:{perfil[5]}");

       if(contactos.Count == 0){throw new Exception("Nao tem contactos registrados");}
       foreach(var Contactos in contactos.Values)
       {
           Console.WriteLine($"Email: {Contactos.email}\tNumber: {Contactos.number_phone}\tWhatsapp: {Contactos.whatsapp_number}");
       }
       if(endereco.Count == 0){throw new Exception("Nao tem enderecos Cadastrados");}
       foreach(var enderecos in endereco.Values)
       {
        Console.WriteLine($"Pais:{enderecos.Pais}\tProvincia:{enderecos.provincia}\tMunicipio:{enderecos.Municipio}\tBairro:{enderecos.bairro}\tNumero Postal:{enderecos.num_endereco}");
       }
        if(Carros.Count == 0){
            throw new Exception("Nao tem carros Cadastrados");
        }
        foreach(var Carro in Carros.Values)
        {
            Console.WriteLine($"Carro: Matricula:{Carro.matricula}\tMarca:{Carro.marca}\tModelo:{Carro.modelo}\tTipo:{Carro.tipo}\tCor:{Carro.cor}\tCaixa:{Carro.tipo_caixa}\tMotor:{Carro.tipo_motor}\tCombustivel:{Carro.tipo_combustivel}\tEndereco:{Carro.endereco[0]}");
        }
    }

}