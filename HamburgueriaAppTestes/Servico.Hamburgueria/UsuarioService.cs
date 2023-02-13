using Dominio.Hamburgueria;
using Dominio.Hamburgueria.Interfaces;
using Repositorio.Hamburgueria;

namespace Servico.Hamburgueria
{
    public class UsuarioService
    {
        private IUsuarioRepositorio _repositorio;
        public UsuarioService(IUsuarioRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public object AlterarSenha(Guid id)
        {
            var usuario = _repositorio.AlterarSenha(id);
            return usuario;
        }

        public Usuario BuscarUsuario(Guid Id)
        {
            var usuario = _repositorio.BuscarUsuario(Id);
            return usuario;
        }

        public Usuario BuscarUsuarioPorEmail(string Email)
        {
            Email = Email.ToLower();
            var usuario = _repositorio.BuscarUsuarioPorEmail(Email);

            return usuario;
        }

        public void DeletarUsuario(Guid id)
        {
            _repositorio.DeletarUsuario(id);     

        }

        public string Login(string Email, string Senha)
        {
            Email = Email.ToLower();
            var usuario = _repositorio.Login(Email, Senha);  
            
            return usuario;
        }

        

    }
}