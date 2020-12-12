
namespace WebApplicationMVC.ModelsDTO
{
    public class UsuarioDTO
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string ConfEmail { get; set; }
        public string Nascimento { get; set; }
        public string Senha { get; set; }
        public string ConfSenha { get; set; }
        public string msgErroEmail { get; set; }
        public string msgErroSenha { get; set; }
    }
}