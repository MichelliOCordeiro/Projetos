using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Hamburgueria
{
    public class Usuario
    {        
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string? Endereco { get; set; }
        public string? Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuario(string nome, string email, string senha)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            Senha = senha;
        }
    }
}
