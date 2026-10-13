using Models;
namespace Servico;

public class UsuarioService
{
 public static Proprietario CriarProprietario(string nome, int idade, string bi, string nif, Dictionary<string, Contactos> contactos, Dictionary<string, Endereco> endereco, Dictionary<string, Carro> carros)
 {
  return new Proprietario
  {
   nome = nome,
   Idade = idade,
   BI = bi,
   nif = nif,
   contactos = contactos,
   endereco = endereco,
   Carros = carros
  };
 }

 public static Condutor CriarCondutor(string nome, int idade, string bi, string cartaConducao, Dictionary<string, Contactos> contactos, Dictionary<string, Endereco> endereco)
    {
        return new Condutor
        {
            nome = nome,
            Idade = idade,
            BI = bi,
            carta_Conducao = cartaConducao,
            contactos = contactos,
            endereco = endereco
        };
    }

 

}

