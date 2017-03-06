using EncontrarTelefone.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncontrarTelefone.Domain.Entities
{
    public class ConjuntoAlfabetoFactory : IConjuntoAlfabetoFactory
    {
        public IDictionary<char, int> Get()
        {
            var _conjunto = new Dictionary<char, int>();

            _conjunto.Add('A', 2);
            _conjunto.Add('B', 2);
            _conjunto.Add('C', 2);

            _conjunto.Add('D', 3);
            _conjunto.Add('E', 3);
            _conjunto.Add('F', 3);

            _conjunto.Add('G', 4);
            _conjunto.Add('H', 4);
            _conjunto.Add('I', 4);

            _conjunto.Add('J', 5);
            _conjunto.Add('K', 5);
            _conjunto.Add('L', 5);

            _conjunto.Add('M', 6);
            _conjunto.Add('N', 6);
            _conjunto.Add('O', 6);

            _conjunto.Add('P', 7);
            _conjunto.Add('Q', 7);
            _conjunto.Add('R', 7);
            _conjunto.Add('S', 7);

            _conjunto.Add('T', 8);
            _conjunto.Add('U', 8);
            _conjunto.Add('V', 8);

            _conjunto.Add('W', 9);
            _conjunto.Add('X', 9);
            _conjunto.Add('Y', 9);
            _conjunto.Add('Z', 9);

            return _conjunto;
        }
        
    }
}
