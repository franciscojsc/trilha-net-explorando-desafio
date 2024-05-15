using DesafioProjetoHospedagem.Models;

namespace DesafioProjetoHospedagem.Interfaces
{
    public interface IReserva
    {
        public void CadastrarHospedes(List<Pessoa> hospedes);

        public void CadastrarSuite(Suite suite);

        public int ObterQuantidadeHospedes();

        public decimal CalcularValorDiaria();
    }
}
