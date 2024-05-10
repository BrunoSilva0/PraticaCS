
namespace ConsoleApplication1.SistemaLoja
{
    public class Cliente
    {
        private string email;
        private string nomeUsuario;
        private string senha;

        public Cliente(string email, string nomeUsuario, string senha)
        {
            this.email = email;
            this.nomeUsuario = nomeUsuario;
            this.senha = senha;
        }
    }
}