using API.Data.Validations;
using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Usuario
    {
        private Task<Usuario?> task;

        public int Id { get; set; }
        [Required(ErrorMessage = "Nome Completo é obrigatório")]
        [StringLength(100,MinimumLength = 7,ErrorMessage = "Nome Completo deve conter entre 7 e 100 caracteres")]
        public string NomeCompleto { get; set; }

        [CPF]
        [Required(ErrorMessage = "CPF é obrigatório")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Email é obrigatório")]
        [StringLength(60, MinimumLength = 7, ErrorMessage = "Email deve conter entre 7 e 60 caracteres")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é obrigatório")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Senha deve conter entre 8 e 100 caracteres")]
        public string Senha { get; set; }

        public Usuario()
        {
        }
        public Usuario(UsuarioDTO usuarioDto)
        {
            NomeCompleto = usuarioDto.NomeCompleto;
            Cpf = usuarioDto.Cpf;
            Email = usuarioDto.Email;
            Senha = usuarioDto.Senha;
        }
        public Usuario(Usuario usuario)
        {
            NomeCompleto = usuario.NomeCompleto;
            Cpf = usuario.Cpf;
            Email = usuario.Email;
            Senha = usuario.Senha;
        }
        public Usuario(string nomeCompleto, string cpf, string email, string senha)
        {
            NomeCompleto = nomeCompleto;
            Cpf = cpf;
            Email = email;
            Senha = senha;
        }
        public Usuario(int id, string nomeCompleto, string cpf, string email, string senha)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            Cpf = cpf;
            Email = email;
            Senha = senha;
        }

        public Usuario(Task<Usuario?> task)
        {
            this.task = task;
        }
    }
}
