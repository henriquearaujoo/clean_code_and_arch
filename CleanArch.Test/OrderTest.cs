using System;
using Xunit;

namespace CleanArch.Test
{
    public class OrderTest
    {
        [Fact(DisplayName = "Não deve criar um pedido com CPF inválido")]
        public void NaoDeveCriarUmPedidoComCPFINvalido()
        {
            var cpf = "111.222.333-44";
            Assert.Throws<ArgumentException>(() => { new Order(cpf); });
        }

        [Fact(DisplayName = "Deve criar um pedido com 3 itens")]
        public void DevCriarUmPedidoCom3Itens()
        {
            var cpf = "576.731.920-04";
            var order = new Order(cpf);
            order.AddItem("1", 1000, 2);
            order.AddItem("2", 5000, 1);
            order.AddItem("3", 30, 3);
            var total = order.GetTotal();
            Assert.Equal(7090, total);
        }
    }
}