namespace EncontrarTelefone.Domain.Interfaces
{
    public interface IConjuntoAlfabeto
    {
        string Frase { get; set; }
        string Telefone { get; set; }

        string GetMatched();

    }
}