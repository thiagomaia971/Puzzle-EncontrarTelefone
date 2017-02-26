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
        public void Key_2_return_the_exception()
        {
            var conjuntoAlfabeto = new ConjuntoAlfabeto();
            var value = conjuntoAlfabeto.GetMatchedLetra('2');
        }

        [TestMethod]
        public void Key_caracterHifen_return_the_value_caractere()
        {
            var conjuntoAlfabeto = new ConjuntoAlfabeto();
            var value = conjuntoAlfabeto.GetMatchedLetra('-');

            Assert.AreEqual('-', value);
        }

        [TestMethod]
        public void Key_1_return_the_value_1()
        {
            var conjuntoAlfabeto = new ConjuntoAlfabeto();
            var value = conjuntoAlfabeto.GetMatchedLetra('1');

            Assert.AreEqual('1', value);
        }

        [TestMethod]
        public void Key_0_return_the_value_0()
        {
            var conjuntoAlfabeto = new ConjuntoAlfabeto();
            var value = conjuntoAlfabeto.GetMatchedLetra('0');

            Assert.AreEqual('0', value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Key_caractereBarra_return_the_exception()
        {
            var conjuntoAlfabeto = new ConjuntoAlfabeto();
            var value = conjuntoAlfabeto.GetMatchedLetra('\\');
        }

    }
}
