using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationMVC.ModelsDTO;
using WebApplicationMVC.Data.Repository;

namespace WebApplicationMVC.Service.Services
{
    public class CadastroService
    {
        private CadastroRepository cadastroRepository;
        public CadastroService()
        {
            cadastroRepository = new CadastroRepository();
        }

        public void SalvarUsuario(string nome, string email, string confEmail, string senha, string confSenha)
        {
            try
            {
                var usuario = new CadastroDTO();

                if (!string.IsNullOrEmpty(nome.Trim()) && !string.IsNullOrWhiteSpace(nome))
                    usuario.Nome = nome.Trim();

                if (!string.IsNullOrEmpty(email.Trim()) && !string.IsNullOrWhiteSpace(email))
                    usuario.Email = email.Trim();

                if (!string.IsNullOrEmpty(confEmail.Trim()) && !string.IsNullOrWhiteSpace(confEmail))
                    usuario.ConfEmail = confEmail.Trim();

                if (!string.IsNullOrEmpty(senha.Trim()) && !string.IsNullOrWhiteSpace(senha))
                    usuario.Senha = senha.Trim();

                if (!string.IsNullOrEmpty(confSenha.Trim()) && !string.IsNullOrWhiteSpace(confSenha))
                    usuario.ConfSenha = confSenha.Trim();


                cadastroRepository.SalvarUsuario(usuario);

            }
            catch (Exception)
            {

                throw;
            }


        }


    }
}