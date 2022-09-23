namespace API.Models
{
    public class UsuarioDTO
    {
        public int ?Id { get; set; }
        public string ?NomeCompleto { get; set; }
        public string ?Cpf { get; set; }
        public string ?Email { get; set; }
        public string ?Senha { get; set; }

        public UsuarioDTO()
        {
        }
        
    }
}
