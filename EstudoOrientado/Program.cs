using System;
using System.Collections.Generic;
using EstudoOrientado.Entidades;
using EstudoOrientado.Entidades.Enuns;
namespace EstudoOrientado
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Faturamento> faturamentos = new List<Faturamento>();


            try
            {
                Console.Write("Valor do pedido: R$ ");
                double pedido = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Tipo de Cliente [PF/PJ/GOV]: ");
                Cliente cliente = Enum.Parse<Cliente>(Console.ReadLine());
                DateTime dataPedido = DateTime.Now;
                Console.WriteLine();
                if (cliente.ToString() == "PF" || cliente.ToString() == "pf")
                {
                    Console.WriteLine("Pessoa Fisica tem 15% de desconto e 30 dias para pagar.");
                    faturamentos.Add(new PessoaFisica(pedido, dataPedido, cliente));

                }
                if (cliente.ToString() == "PJ" || cliente.ToString() == "pj")
                {
                    Console.WriteLine("Pessoa Juridica tem 20% de desconto e 60 dias para pagar.");
                    faturamentos.Add(new PessoaJuridica(pedido, dataPedido, cliente));
                }
                if (cliente.ToString() == "GOV" || cliente.ToString() == "gov")
                {
                    Console.WriteLine("Governo não tem desconto e tem que pagar a vista.");
                    faturamentos.Add(new Governo(pedido, dataPedido, cliente));
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro" + e.Message);
            }
            finally
            {
                foreach (Faturamento faturamento in faturamentos)
                {

                    Console.WriteLine(faturamento);
                }
            }
        }
    }
}

