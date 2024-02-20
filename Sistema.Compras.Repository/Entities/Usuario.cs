using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Sistema.Compras.Repository;

public class Usuario
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public int IdPerfil { get; set; }
    public Perfil Perfil {get; set;} 
    public DateTime DataCadastro { get; set; }
    public DateTime DataAlteracao { get; set; }
}
