using MinimalApi.Dominio.Interfaces;
using MinimalApi.Admin;
using MinimalApi.DTOs;
using MinimalApi.Insfraestrutura.Db;

namespace MinimalApi.Dominio.Servicos
{
    public class AdministradorServicos : IAdministradorServicos
    {
        private readonly DbContexto _contexto;

        public AdministradorServicos(DbContexto contexto)
        {
            _contexto = contexto;
        }

        public Administrador? BuscarPorId(int id)
        {
            return _contexto.Administradores.Where(v => v.Id == id).FirstOrDefault();
        }

        public Administrador Incluir(Administrador administrador)
        {
            _contexto.Administradores.Add(administrador);
            _contexto.SaveChanges();
            return administrador;
        }

        public Administrador? Login(LoginDTO loginDTO)
        {
            var adm = _contexto.Administradores
                .FirstOrDefault(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha);

            return adm;
        }

        public List<Administrador> Todos(int? pagina)
        {
            var query = _contexto.Administradores.AsQueryable();

            int itensPorPagina = 10;

            if (pagina != null)
                query = query.Skip(((int)pagina - 1) * itensPorPagina).Take(itensPorPagina);
            

            return query.ToList();  
        }
    }
}
