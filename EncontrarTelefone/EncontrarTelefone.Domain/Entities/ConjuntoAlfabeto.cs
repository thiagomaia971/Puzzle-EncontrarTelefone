using EncontrarTelefone.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EncontrarTelefone.Domain.Entities
{
    public class ConjuntoAlfabeto : IConjuntoAlfabeto
    {

        public IConjuntoAlfabetoFactory _conjunto { get; private set; }
        public string Frase { get; set; }
        public string Telefone { get; set; }

        public ConjuntoAlfabeto(string frase)
        {
            this.Frase = frase;
            _conjunto = new ConjuntoAlfabetoFactory();
        }

        public void HaveFrase()
        {
            if (string.IsNullOrEmpty(Frase))
                throw new FraseIsMissingException();
        }

        public string GetMatched()
        {
            Telefone = "";

            foreach (var letra in this.Frase)
            {
                Telefone += this.GetMatchedLetra(letra).ToString();
            }

            return Telefone;
        }

        private char GetMatchedLetra(char key)
        {

            if (key == '-' || key == '0' || key == '1')
                return key;

            var value = this._conjunto.Get().SingleOrDefault(x => x.Key == key).Value;

            if (value == 0)
                throw new ArgumentException("Letra nao contem no alfabeto.");

            return Convert.ToChar(value.ToString());
        }

    }

    [Serializable]
    internal class FraseIsMissingException : Exception
    {
        public FraseIsMissingException() : base("Está faltando a frase.")
        {
        }

        public FraseIsMissingException(string message) : base(message)
        {
        }

        public FraseIsMissingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FraseIsMissingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
