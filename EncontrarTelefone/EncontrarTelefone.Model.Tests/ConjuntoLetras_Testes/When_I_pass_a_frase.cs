using EncontrarTelefone.Domain.Entities;
using EncontrarTelefone.Domain.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncontrarTelefone.Model.Tests.ConjuntoLetras_Testes
{
    [TestClass]
    public class When_I_pass_a_frase
    {

        [TestMethod]
        public void ABC_returns_222()
        {
            IConjuntoAlfabeto conjuntoAlfabeto = new ConjuntoAlfabeto();

            string frase = "ABC";
            string telefone = conjuntoAlfabeto.GetMatchedFrase(frase);

            Assert.AreEqual("222", telefone);
        }

        [TestMethod]
        public void WXYZ_returns_9999()
        {
            IConjuntoAlfabeto conjuntoAlfabeto = new ConjuntoAlfabeto();

            string frase = "WXYZ";
            string telefone = conjuntoAlfabeto.GetMatchedFrase(frase);

            Assert.AreEqual("9999", telefone);
        }

        [TestMethod]
        public void HOME_returns_4663()
        {
            IConjuntoAlfabeto conjuntoAlfabeto = new ConjuntoAlfabeto();

            string frase = "HOME";
            string telefone = conjuntoAlfabeto.GetMatchedFrase(frase);

            Assert.AreEqual("4663", telefone);
        }

        [TestMethod]
        public void HOME_SWEET_HOME_returns_4663()
        {
            IConjuntoAlfabeto conjuntoAlfabeto = new ConjuntoAlfabeto();

            string frase = "1-HOME-SWEET-HOME";
            string telefone = conjuntoAlfabeto.GetMatchedFrase(frase);

            Assert.AreEqual("1-4663-79338-4663", telefone);
        }

    }
}
