using EncontrarTelefone.Domain.Entities;
using EncontrarTelefone.Domain.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace EncontrarTelefone.Model.Tests.ConjuntoLetras_Testes
{
    [Binding]
    public class StepDefinitions
    {

        public Mock<IConjuntoAlfabeto> MockConjuntoAlfabeto { get; set; }
        public Mock<IConjuntoAlfabetoFactory> MockConjuntoAlfabetoFactory { get; set; }

        [BeforeScenario()]
        public void ReceberFrase()
        {
            this.MockConjuntoAlfabeto = new Mock<IConjuntoAlfabeto>();
            this.MockConjuntoAlfabetoFactory = new Mock<IConjuntoAlfabetoFactory>();

            var frase = "ABC";
            this.MockConjuntoAlfabeto.Setup(x => x.Frase).Returns(frase);
            this.MockConjuntoAlfabetoFactory.Setup(x => x.Get()).Returns(new Dictionary<char, int>());
        }

        [Given(@"Eu tenha passado a frase")]
        public void DadoEuTenhaPassadoAFrase()
        {
            Assert.IsNotNull(this.MockConjuntoAlfabeto.Object.Frase);
        }

        [Given(@"Que o programa tenha mapeado as letras")]
        public void DadoQueOProgramaTenhaMapeadoAsLetras()
        {
            Assert.IsNotNull(MockConjuntoAlfabetoFactory.Object.Get());
        }

        [When(@"Eu executar o programa")]
        public void QuandoEuExecutarOPrograma()
        {
            
            
        }

        [Then(@"O resultado será o número telefone correspondente a frase\.")]
        public void EntaoOResultadoSeraONumeroTelefoneCorrespondenteAFrase_()
        {
            Assert.AreEqual("222", this.MockConjuntoAlfabeto.Object.GetMatched());
        }
    }
}
