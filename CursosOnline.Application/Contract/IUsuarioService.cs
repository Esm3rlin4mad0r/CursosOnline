using CursosOnline.Application.Core;
using CursosOnline.Application.Dtos.Producto;
using CursosOnline.Application.Dtos.Usuario;
using CursosOnline.Application.Responses;
using System.Threading.Tasks;

namespace CursosOnline.Application.Contract
{
    public interface IUsuarioService
    {
        Task<ServiceResult> SaveUsuario(UsaurioAddDto productAddDto);

        Task<ServiceResult> GetUsuario(GetUsuarioInfoDto getUsuarioInfoDto); 
         

    }
}
