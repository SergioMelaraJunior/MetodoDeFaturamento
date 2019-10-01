using System;
using EstudoOrientado.Entidades.Enuns;
using System.Globalization;
namespace EstudoOrientado.Entidades
{
    class PessoaJuridica : Faturamento 
    {
        public PessoaJuridica(double pedido, DateTime dataPedido, Cliente cliente)
            : base(pedido, dataPedido, cliente)
        {

        }

        public override string Faturar()
        {
            DataPedido = DataPedido.AddDays(61);
            Pedido -= Pedido * 0.20;
            return "\nValor com desconto R$: " + Pedido.ToString("f2",CultureInfo.InvariantCulture) +
                "\nData para Pagamento: " + DataPedido.ToString("dd/MM/yyyy");
        }

    }
}
