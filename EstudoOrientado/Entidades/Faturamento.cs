using System;
using System.Globalization;
using EstudoOrientado.Entidades.Enuns;
namespace EstudoOrientado.Entidades
{
    class Faturamento
    {
        public double Pedido { get; set; }

        public DateTime DataPedido { get; set; }

        public Cliente Cliente { get; set; }

        public Faturamento()
        {
        }

        public Faturamento(double pedido, DateTime dataPedido, Cliente cliente)
        {
            Pedido = pedido;
            DataPedido = dataPedido;
            Cliente = cliente;
        }

        public virtual string Faturar()
        {
            return Faturar();
        }


        public override string ToString()
        {
            return "\nResumo do Pedido. \n" +
                "\nTotal do Pedido R$: " + Pedido.ToString("f2", CultureInfo.InvariantCulture) +
                "\nData do Pedido: " + DataPedido.ToString("dd/MM/yyyy") +
                "\nTipo de Pessoa: "+ Cliente +
                "\n\nFinalização do Pedido. \n" +
                Faturar();

        }
    }
}

