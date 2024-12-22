namespace Livraria_TI.Models.ViewModels.Livro
{
    public class LivroCreateViewModel
    {
        public IFormFile Capa { get; set; }

        public string Titulo { get; set; }

        public string Editora { get; set; }

        public decimal Preco { get; set; }

        public string descricao { get; set; }
    }
}
