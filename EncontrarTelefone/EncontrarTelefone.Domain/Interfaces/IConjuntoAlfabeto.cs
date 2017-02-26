namespace EncontrarTelefone.Domain.Interfaces
{
    public interface IConjuntoAlfabeto
    {
        char GetMatchedLetra(char v);
        string GetMatchedFrase(string v);
    }
}