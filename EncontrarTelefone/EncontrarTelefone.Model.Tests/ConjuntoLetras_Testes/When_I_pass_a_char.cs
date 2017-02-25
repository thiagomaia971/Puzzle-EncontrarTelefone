using EncontrarTelefone.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncontrarTelefone.Domain.Testes.ConjuntoLetras_Testes
{
    [TestClass]
    public class When_I_pass_a_char
    {
        [TestMethod]
        public void A_return_the_value_2()
        {
            var conjuntoAlfabeto = new ConjuntoAlfabeto();
            var value = conjuntoAlfabeto.GetMatched('A');

            Assert.AreEqual('2', value);
        }

        [TestMethod]
        public void K_return_the_value_5()
        {
            var conjuntoAlfabeto = new ConjuntoAlfabeto();
            var value = conjuntoAlfabeto.GetMatched('K');

            Assert.AreEqual('5', value);
        }


    }
}
