using Dominio.Hamburgueria;
using Dominio.Hamburgueria.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Hamburgueria.Mock
{
    public class UsuarioMockRepositorio : IUsuarioRepositorio
    {
        private List<Usuario> Usuarios;

        public UsuarioMockRepositorio()
        {
            Usuarios = new List<Usuario>();
            Usuarios.Add(new Usuario("Michelli", "mimi@com", "123"));
        }

        public void AlterarEmail(string Email, string Senha)
        {
            throw new NotImplementedException();
        }

        public void AlterarSenha(string Email, string Senha)
        {
            throw new NotImplementedException();
        }

        public Usuario AlterarSenha(Guid id)
        {
            var usuario = Usuarios.FirstOrDefault(e => e.Senha == e.Senha);
            return usuario;
        }

        public void AlterarUsuario(string Nome, string Endereco, string Telefone)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarUsuario(Guid Id)
        {
            var usuario = Usuarios.FirstOrDefault(e => e.Id == Id);
            return usuario;
        }

        public Usuario BuscarUsuarioPorEmail(string Email)
        {
            var usuario = Usuarios.FirstOrDefault(e => Email == e.Email);
            return usuario;
        }

        public void DeletarUsuario(Guid id)
        {
            var usuario = Usuarios.Remove(BuscarUsuario(id));
        }

        public string Login(string emailParam, string senhaParam)
        {
            var usuario = Usuarios.FirstOrDefault(e => e.Email == emailParam && e.Senha == senhaParam);
            if(usuario == null)
            {
                return null;
            }
            else
            {
                return Guid.NewGuid().ToString();
            }
        }
    }
}
