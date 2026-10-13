
namespace Models;
using Servico;

public class Condutor : Usuario{
    public required string carta_Conducao{get; set;}

    public string Tipo {get;init;} = "Condutor";
    public override void MostrarPerfil()
    {
       var perfil =new List<string>
       {
           $"{id}",
           $"{nome}",
           $"{Idade}",
           $"{BI}",
           $"{carta_Conducao}",
           $"{Tipo}"
       };
       Console.WriteLine($"Id:{perfil[0]}\tNome:{perfil[1]} Idade:{perfil[2]}\t BI:{perfil[3]}");

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
    }

    public Emprestimo EmprestarCarro(Proprietario proprietario, string matricula, EmprestimoService servico,string DatadeDevolucao)
    {
        return servico.Emprestar(this, proprietario, matricula, DatadeDevolucao);
    }


}
