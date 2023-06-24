using CursosOnline.Domain.Entities.Seguridad;
using CursosOnline.Domain.Repository;
using CursosOnline.Infraestructure.Models.Usuario;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CursosOnline.Infraestructure.Interfaces
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Task<List<UsuarioModel>> GetUsuarios();
        Task<UsuarioModel> GetUsuario(string correo, string pwd);
    }
}
