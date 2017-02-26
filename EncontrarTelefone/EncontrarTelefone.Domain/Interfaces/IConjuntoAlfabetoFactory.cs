using System.Collections.Generic;

namespace EncontrarTelefone.Domain.Entities
{
    public interface IConjuntoAlfabetoFactory
    {
        IDictionary<char, int> Get();
    }
}