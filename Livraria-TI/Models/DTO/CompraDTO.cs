namespace Livraria_TI.Models.DTO
{
    public class CompraDTO
    {
        public int Id_Compra { get; set; }
        public DateTime Data_Compra { get; set; }
        public bool Estado_Compra { get; set; }
        public bool Estado_Encomenda { get; set; }
        public DateTime Data_Entrega { get; set; }
        public int Id_Utilizador { get; set; }
    }
}
