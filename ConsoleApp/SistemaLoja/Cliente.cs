using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApplication1.SistemaLoja
{
    public class Cliente
    {
        public string Email { get; set; }
        public string Senha { get; set; }

        public Cliente(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }
    }

    public class GerenciadorUsuarios
    {
        private List<Cliente> usuarios;
        private string caminhoArquivo;

        public GerenciadorUsuarios()
        {
            string caminhoPastaUsuario = Environment.GetEnvironmentVariable("USERPROFILE");
            caminhoArquivo = Path.Combine(caminhoPastaUsuario, "usuarios.json");

            if (File.Exists(caminhoArquivo))
            {
                var json = File.ReadAllText(caminhoArquivo);
                usuarios = JsonConvert.DeserializeObject<List<Cliente>>(json);
            }
            else
            {
                usuarios = new List<Cliente>();
            }
        }

        public void AdicionarUsuario(Cliente usuario)
        {
            usuarios.Add(usuario);
            SalvarDados();
        }

        public bool ChecarLogin(string email, string senha)
        {
            foreach (var usuario in usuarios)
            {
                if (usuario.Email == email && usuario.Senha == senha)
                {
                    return true;
                }
            }

            return false;
        }

        private void SalvarDados()
        {
            var json = JsonConvert.SerializeObject(usuarios);
            File.WriteAllText(caminhoArquivo, json);
        }
    }
}