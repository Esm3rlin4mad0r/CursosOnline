using System.ComponentModel.DataAnnotations;
namespace CursosOnline.Web.Models;

public class LoginModel
{

    [Required(ErrorMessage = "Campo requerido")]
    public string? Usuario { get; set; }
    [Required(ErrorMessage = "Campo requerido")]
    public string? Clave { get; set; }
}