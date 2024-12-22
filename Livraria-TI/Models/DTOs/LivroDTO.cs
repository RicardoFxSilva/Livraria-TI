
namespace Livraria_TI.Models
{
    public class LivroDTO
    {
        public int Id_Livro { get; set; }

        public string Titulo { get; set; }

        public decimal Preco { get; set; }

        public string ImagemDeCapa { get; set; }

        public string Editora { get; set; }

        public string Descricao { get; set; }
    }
}
