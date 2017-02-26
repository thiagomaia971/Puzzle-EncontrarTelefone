using EncontrarTelefone.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncontrarTelefone.Domain.Entities
{
    public class ConjuntoAlfabeto : IConjuntoAlfabeto
    {

        private IDictionary<char, int> _conjunto;

        public ConjuntoAlfabeto()
        {
            this._conjunto = new ConjuntoAlfabetoFactory().Get();
        }

        public char GetMatchedLetra(char key)
        {

            if (key == '-' || key == '0' || key == '1')
                return key;

            var value = this._conjunto.SingleOrDefault(x => x.Key == key).Value;

            if (value == 0)
                throw new ArgumentException("Letra nao contem no alfabeto.");

            return Convert.ToChar(value.ToString());
        }

        public string GetMatchedFrase(string frase)
        {
            string telefone = "";

            foreach (var letra in frase)
            {
                telefone += this.GetMatchedLetra(letra).ToString();
            }

            return telefone;
        }
    }
}
