using Dominio.Hamburgueria;
using Dominio.Hamburgueria.Interfaces;

namespace Repositorio.Hamburgueria
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {        
        public void AlterarEmail(string Email, string Senha)
        {
            throw new NotImplementedException();
        }
        
        public void AlterarEmail2(string Email, string Senha)
        {
            throw new NotImplementedException();
        }

        public void AlterarSenha(string Email, string Senha)
        {
            throw new NotImplementedException();
        }

        public void AlterarUsuario(string Nome, string Endereco, string Telefone)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarUsuario(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarUsuarioPorEmail(string Email)
        {
            throw new NotImplementedException();
        }

        public string DeletarUsuario(Guid Id)
        {
            throw new NotImplementedException();
        }

        public string Login(string Email, string Senha)
        {
            return Guid.NewGuid().ToString();
        }
    }
}