using MinimalApi.Admin;
using MinimalApi.DTOs;
using MinimalApi.Transporte;

namespace MinimalApi.Dominio.Interfaces
{
    public interface IVeiculoServicos
    {
        List<Veiculo> Todos(int? pagina = 1, string? nome = null, string? marca = null);
        Veiculo? BuscarPorId(int id);
        void Incluir(Veiculo veiculo);
        void Atualizar(Veiculo veiculo);
        void Apagar(Veiculo veiculo);
        
    }
}
