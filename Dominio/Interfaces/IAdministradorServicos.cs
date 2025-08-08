using MinimalApi.Admin;
using MinimalApi.DTOs;

namespace MinimalApi.Dominio.Interfaces
{
    public interface IAdministradorServicos
    {
        Administrador? Login(LoginDTO loginDTO);
        Administrador? BuscarPorId(int id);
        Administrador Incluir(Administrador administrador);
        List<Administrador> Todos(int? pagina);
        
    }
}
