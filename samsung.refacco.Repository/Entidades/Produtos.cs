using System;

namespace samsung.refacco.Repository.Entidades
{
    public class Produtos
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Produto { get; set; }
        public decimal Valor { get; set; }
        public int Estoque { get; set; }
    }
}
