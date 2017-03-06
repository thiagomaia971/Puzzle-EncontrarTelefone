using System.Collections.Generic;

namespace EncontrarTelefone.Domain.Interfaces
{
    public interface IConjuntoAlfabetoFactory
    {
        IDictionary<char, int> Get();
    }
}