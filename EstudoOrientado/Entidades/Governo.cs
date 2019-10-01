using System.Globalization;
using EstudoOrientado.Entidades.Enuns;
using System;
namespace EstudoOrientado.Entidades
{
    class Governo : Faturamento
    {
        public Governo(double pedido, DateTime dataPedido, Cliente cliente) 
            : base(pedido, dataPedido, cliente)
        {

        }
        public override string Faturar()
        {
            DataPedido = DataPedido;
            Pedido = Pedido;
            return "\nValor R$: " + Pedido.ToString("f2", CultureInfo.InvariantCulture) +
                "\nData para Pagamento: " + DataPedido.ToString("dd/MM/yyyy");
        }

    }
}
