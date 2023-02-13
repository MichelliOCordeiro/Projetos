using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Hamburgueria.Interfaces
{
    public interface IUsuarioRepositorio
    {
        public string Login (string Email, string Senha);

        public void AlterarUsuario(string Nome, string Endereco, string Telefone);

        public void AlterarEmail(string Email, string Senha);

        public Usuario AlterarSenha (Guid id);

        public void DeletarUsuario (Guid Id);

        public Usuario BuscarUsuario (Guid Id);

        public Usuario BuscarUsuarioPorEmail (string Email);

    }
}
