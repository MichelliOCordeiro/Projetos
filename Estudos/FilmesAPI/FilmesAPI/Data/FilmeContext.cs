using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesAPI.Data
{
    public class FilmeContext : DbContext
    {
        //opções de acesso
        public FilmeContext(DbContextOptions<FilmeContext> opts)
            :base(opts)
        {

        }

        //Dbset: conjunto de dados que tera o nome de filmes
        public DbSet<Filme> Filmes { get; set; }
    }
}
