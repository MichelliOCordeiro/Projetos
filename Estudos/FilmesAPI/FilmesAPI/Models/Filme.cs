using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        //para criar a tabela no banco: ferramentas - nuget - console do gerenc. de pacotes
        //no console: Add-Migration CriandoTabelaFilme
        //para criar realmente com as configs passadas: Update-Database

        //aqui passo para o banco que é necessario gerar o id e que é campo obrigatorio
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório")]
        public string Titulo { get; set; }

        [MaxLength(50, ErrorMessage = "Não pode exceder a 50 caracteres")]
        [Required(ErrorMessage = "O gênero é obrigatório")]
        public string Genero { get; set; }

        //range é o intervalo, minimo de 70 e maximo de 600
        [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600")]
        [Required(ErrorMessage = "A duração é obrigatória")]
        public int Duracao { get; set; }        
    }
}
