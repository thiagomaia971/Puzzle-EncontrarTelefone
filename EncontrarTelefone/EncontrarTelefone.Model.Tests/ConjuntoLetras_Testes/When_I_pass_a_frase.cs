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
        [Owner("Thiago Maia da Costa")]
        [Description("WHEN I pass ABC THEN return 222")]
        [Priority(1)]
        [WorkItem(1570)]
        public void ABC_returns_222()
        {

            string frase = "ABC";
            IConjuntoAlfabeto conjuntoAlfabeto = new ConjuntoAlfabeto(frase);

            string telefone = conjuntoAlfabeto.GetMatched();

            Assert.AreEqual("222", telefone);
        }

        [TestMethod]
        [Owner("Thiago Maia da Costa")]
        [Description("WHEN I pass WXYZ THEN return 9999")]
        [Priority(1)]
        [WorkItem(1570)]
        public void WXYZ_returns_9999()
        {
            string frase = "WXYZ";
            IConjuntoAlfabeto conjuntoAlfabeto = new ConjuntoAlfabeto(frase);

            string telefone = conjuntoAlfabeto.GetMatched();
            Assert.AreEqual("9999", telefone);
        }

        [TestMethod]
        [Owner("Thiago Maia da Costa")]
        [Description("WHEN I pass HOME THEN return 4663")]
        [Priority(1)]
        [WorkItem(1570)]
        public void HOME_returns_4663()
        {
            string frase = "HOME";
            IConjuntoAlfabeto conjuntoAlfabeto = new ConjuntoAlfabeto(frase);

            string telefone = conjuntoAlfabeto.GetMatched();

            Assert.AreEqual("4663", telefone);
        }

        [TestMethod]
        public void HOME_SWEET_HOME_returns_1_4663_79338_4663 ()
        {
            string frase = "1-HOME-SWEET-HOME";

            IConjuntoAlfabeto conjuntoAlfabeto = new ConjuntoAlfabeto(frase);

            string telefone = conjuntoAlfabeto.GetMatched();

            Assert.AreEqual("1-4663-79338-4663", telefone);
        }

    }
}
