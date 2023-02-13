using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;

namespace FilmesAPI.Controllers
{
    //[Route("[controller]")] essa será a rota que aparecera no swagger, FilmeController
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static int id = 0;
        //static para ficar na classe toda, aqui estou criando uma nova lista de filme, o filmes é o nome que estou
        //dando a lista
        private static List<Filme> filmes = new List<Filme>();

        //aqui vai o post, que é para atualizar/inserir info, e a info vai vir do corpo da requisição (fromBody)
        [HttpPost]
        //public void AdicionaFilme([FromBody] Filme filme)
        public IActionResult AdicionaFilme([FromBody] Filme filme)
        {
            filme.Id = id++;
            filmes.Add(filme);
            return CreatedAtAction(nameof(RecuperaFilmesPorId),
                new { id = filme.Id },
                filme);
        }

        //quando tem void nao tem retorno no metodo, pq void nao retorna nada, nesse caso sera retornado a Lista de filmes
        //filmes com minuscula é o nome que dei a lista de filmes na linha 13
        //foi trocado de lista para ienumerable pois, se depois o metodo da linha 13 foi trocado de lista para algum outro
        ////nao ira dar erro, isso serve para deixar o codigo mais abstrato, sem depender tanto das interfaces
        //[HttpGet]
        //public IEnumerable<Filme> RecuperaFilmes()
        //{
        //    return filmes;
        //}

        //esse metodo ira limitar a lista que é passada ao usuario, ao inves de pegar toda a base como no metodo de get acima 
        //esse usa o skip = quantos elementos da lista quero pular e o take = quantos elementos quero pegar
        //tudo isso sendo passado como passado como padrao 0 ate 60, nisso vai pegar a lista ate o id 59
        //o fromQuer é a forma que isso vai ser passado, que será pelo usuario digitando, se ele nao digitar, vem os valores 
        //padrões de 0 a 59. A forma de passar no swagger é assim: //localhost:7003/filme?skip=10&take=50
        [HttpGet]
        public IEnumerable<Filme> RecuperaFilmes([FromQuery] int skip = 5, [FromQuery]int take = 60)
        {
            return filmes.Skip(skip).Take(take);
        }

        //este metodo serve para recuperar um filme por id, aqui ele vai fazer a pesquisa pelo id do filme
        //retorno a lista de filmes e pego o primeiro resultado onde o id do filme seja igual ao id do parametro
        [HttpGet("{id}")]
        //public Filme? RecuperaFilmesPorId(int id)
        //nessa segunda forma de metodo iremos utilizar o padrao rest IActionResult, onde ele envia um status
        //de sucesso ou defalha na requisição
        public IActionResult RecuperaFilmesPorId(int id)
        {
            var filme = filmes.FirstOrDefault(filme => filme.Id == id);
            if (filme == null) return NotFound();
            return Ok(filme);
        }

    }
}
