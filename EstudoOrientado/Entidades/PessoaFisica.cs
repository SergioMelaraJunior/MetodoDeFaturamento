using System;
using EstudoOrientado.Entidades.Enuns;
using System.Globalization;
namespace EstudoOrientado.Entidades
{
    class PessoaFisica : Faturamento
    {
        public PessoaFisica(double pedido, DateTime dataPedido, Cliente cliente)
            : base(pedido, dataPedido, cliente)
        {

        }

        public override string Faturar()
        {
            DataPedido = DataPedido.AddDays(30);
            Pedido -= Pedido * 0.15;
            return "\nValor com desconto R$: " + Pedido.ToString("f2",CultureInfo.InvariantCulture) +
                "\nData para Pagamento: " + DataPedido.ToString("dd/MM/yyyy");
        }
    }
}
