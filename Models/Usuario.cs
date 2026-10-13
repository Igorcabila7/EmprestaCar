using Models;
public abstract class Usuario{
    public int id{get; init;} = Math.Abs(Guid.NewGuid().GetHashCode());
    public required string nome {get; set;}

    private int _idade;
    public required int Idade {get  => _idade; set{
        if(value < 18)
        {
            throw new ArgumentException("O utilizador deve ser maior de 18 anos para se registar no sistema.");
        }
        _idade = value;
    }
    }
    public required string BI {get; set;}
    public required Dictionary<string,Contactos> contactos {get; set;} = new();
    public required Dictionary<string,Endereco> endereco {get; set;} = new();


    public virtual void MostrarPerfil()
    {
       var perfil =new List<string>
       {
           $"{id}",
           $"{nome}",
           $"{_idade}",
           $"{BI}"
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

    



}