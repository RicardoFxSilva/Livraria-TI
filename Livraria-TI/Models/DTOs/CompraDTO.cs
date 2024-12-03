namespace Livraria_TI.Models
{
    public class CompraDTO
    {
        public int Id_Compra { get; set; }

        public DateTime DataCompra { get; set; }

        public Boolean EstadoCompra { get; set; }

        public Boolean EstadoEncomenda { get; set; }

        public DateTime DataEntrega { get; set; }

        public int Id_Utilizador { get; set; }
    }
}
