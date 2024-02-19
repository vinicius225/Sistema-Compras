namespace Sistema.Compras.Repository;

public class Perfil
{
public int Id { get; set; }
public string Nome { get; set; }
public string Descricao { get; set; }
public DateTime DataCriacao { get; set; }
public DateTime DataAlteracao { get; set; }
public IEnumerable<Usuario> Usuarios { get; set; }
}
