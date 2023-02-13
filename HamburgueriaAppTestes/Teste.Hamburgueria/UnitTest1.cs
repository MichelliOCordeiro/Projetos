using Dominio.Hamburgueria;
using Dominio.Hamburgueria.Interfaces;
using Servico.Hamburgueria;
using Teste.Hamburgueria.Mock;

namespace Teste.Hamburgueria
{
    public class UnitTest1 
    {
        IUsuarioRepositorio _userRepositorio;

        public UnitTest1()
        {
            _userRepositorio = new UsuarioMockRepositorio();
        }        

        [Fact]
        public void ValidarEmailSenhaCorreto()
        {
            var servico = new UsuarioService(_userRepositorio);
            var resposta = servico.Login("mimi@com", "123");
            Assert.NotNull(resposta);
        }

        [Fact]
        public void ValidarEmailCertoSenhaErrada()
        {
            var servico = new UsuarioService(_userRepositorio);
            var resposta = servico.Login("mimi@com", "12345");
            Assert.NotNull(resposta);
        }

        [Fact]
        public void ValidarEmailNaoExisteSenhaErrada()
        {
            var servico = new UsuarioService(_userRepositorio);
            var resposta = servico.Login("mimi@234com", "12345");
            Assert.Null(resposta);
        }

        [Fact]
        public void ValidarEmailMaiusculo()
        {
            var servico = new UsuarioService(_userRepositorio);
            var resposta = servico.Login("MIMI@COM", "123");
            Assert.NotNull(resposta);
        }

        [Fact]
        public void ValidarEmailValido()
        {
            var servico = new UsuarioService(_userRepositorio);
            var resposta = servico.BuscarUsuarioPorEmail("MIMI@COM");
            Assert.NotNull(resposta);
        }

        [Fact]
        public void ValidarEmailInvalido()
        {
            var servico = new UsuarioService(_userRepositorio);
            var resposta = servico.BuscarUsuarioPorEmail("MIMI@COM.br");
            Assert.Null(resposta);
        }

        [Fact]
        public void BuscarUsuarioPorId()
        {
            var servico = new UsuarioService(_userRepositorio);
            var usuario = servico.BuscarUsuarioPorEmail("mimi@com");
            var resposta = servico.BuscarUsuario(usuario.Id);
            Assert.NotNull(resposta);
        }

        [Fact]
        public void BuscarUsuarioPorIdIncorreto()
        {
            var servico = new UsuarioService(_userRepositorio);
            var resposta = servico.BuscarUsuario(Guid.NewGuid());
            Assert.Null(resposta);
        }

        [Fact]
        public void DeletarUsuario()
        {
            var servico = new UsuarioService(_userRepositorio);
            var usuario = servico.BuscarUsuarioPorEmail("mimi@com");
            var idUsuario = servico.BuscarUsuario(usuario.Id);
            //var resposta = servico.DeletarUsuario(idUsuario.Id);
            //Assert.Null(resposta);
        }

        [Fact]
        public void AlterarSenha()
        {
            var servico = new UsuarioService(_userRepositorio);
            var resposta = servico.AlterarSenha(Guid.NewGuid());
            Assert.Null(resposta);
        }
    }
}