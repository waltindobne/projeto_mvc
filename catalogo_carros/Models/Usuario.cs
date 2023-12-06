namespace catalogo_carros.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        public required string Nome { get; set; }

        public required string NomeUsuario { get; set; }
         
        public required string Senha { get; set; }
    }
}
