using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class UsuariosController : ApiController
    {
        private static List<Usuario> usuarios = new List<Usuario>();

        [HttpGet]
        public List<Usuario> Pegar()
        {
            return usuarios; 
        }

        [HttpPost]
        public void enviar(string nome, string sexo, string endereco, string telefone, string email)
        {
            if (!string.IsNullOrEmpty(nome))
                usuarios.Add(new Usuario(nome, sexo, endereco, telefone, email));
        }
        /*public void enviar(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
                usuarios.Add(new Usuario(nome));
        }*/
        public void Delete(string nome)
        {
            usuarios.RemoveAt(usuarios.IndexOf(usuarios.First(x => x.nome.Equals(nome))));
        }
    }
}
