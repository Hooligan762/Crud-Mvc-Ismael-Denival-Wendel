using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Usuario
    {
        public string nome { get; set; }
        public string sexo { get; set; }
        public string endereco { get; set; }
        public string telefone{ get; set; }
        public string email { get; set; }

        public Usuario(string nome, string sexo, string endereco, string telefone, string email)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.endereco = endereco;
            this.telefone = telefone;
            this.email = email;
        }
        /*public Usuario(string nome)
        {
            this.nome = nome;          
        }*/

    }
}