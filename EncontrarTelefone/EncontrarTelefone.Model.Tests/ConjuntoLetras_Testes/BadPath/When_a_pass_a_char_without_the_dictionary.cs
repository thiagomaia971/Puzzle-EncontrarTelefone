using EncontrarTelefone.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncontrarTelefone.Model.Tests.ConjuntoLetras_Testes.BadPath
{
    [TestClass]
    public class When_a_pass_a_char_without_the_dictionary
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Key_2_return_the_value_2()
        {
            var conjuntoAlfabeto = new ConjuntoAlfabeto();
            var value = conjuntoAlfabeto.GetMatched('2');

            Assert.AreEqual('2', value);
        }

        [TestMethod]
        public void Key_caracterSpecial_return_the_value_caractere()
        {
            var conjuntoAlfabeto = new ConjuntoAlfabeto();
            var value = conjuntoAlfabeto.GetMatched('-');

            Assert.AreEqual('-', value);
        }

        [TestMethod]
        public void Key_1_return_the_value_1()
        {
            var conjuntoAlfabeto = new ConjuntoAlfabeto();
            var value = conjuntoAlfabeto.GetMatched('1');

            Assert.AreEqual('1', value);
        }

    }
}
