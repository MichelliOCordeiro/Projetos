using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        public int Id { get; internal set; }

        [Required(ErrorMessage = "O título é obrigatório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O gênero é obrigatório")]
        [MaxLength(50, ErrorMessage = "Não pode exceder a 50 caracteres")]
        public string Genero { get; set; }

        //range é o intervalo, minimo de 70 e maximo de 600
        [Required(ErrorMessage = "A duração é obrigatória")]
        [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600")]
        public int Duracao { get; set; }        
    }
}
