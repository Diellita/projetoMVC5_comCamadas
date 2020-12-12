using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using log4net;
using PetaPoco;
using WebApplicationMVC.ModelsDTO;

namespace WebApplicationMVC.Data.Repository
{
    public class CadastroRepository
    {
        private static ILog log;

        private Database DB;
        public CadastroRepository()
        {
            DB = new Database("DB");
        }
        public void SalvarUsuario(CadastroDTO cadastro)
        {
            try
            {
                string insert = @"insert into Usuarios (Nome,Email,ConfEmail,Senha,ConfSenha) values (@Nome,@Email,@ConfEmail,@Senha,@ConfSenha)";
                int v = DB.Execute(insert, new { cadastro.Nome, cadastro.Email, cadastro.ConfEmail, cadastro.Senha, cadastro.ConfSenha });

            }
            catch (Exception ex)
            {
                log.ErrorFormat("Erro ao consultar banco de dados!\n Error: {0}", ex);
                throw;
            }
        }
    }
}