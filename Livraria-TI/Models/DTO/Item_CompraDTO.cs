namespace Livraria_TI.Models.DTO
{
    public class Item_CompraDTO
    {
        public int Id_Item { get; set; }
        public decimal Preco { get; set; }
        public int quantidade { get; set; }
        public int Id_Livro { get; set; }
        public int Id_Compra { get; set; }
    }
}
