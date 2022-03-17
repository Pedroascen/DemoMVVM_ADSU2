using DemoMVVM01.Models;
using System.Collections.Generic;

namespace DemoMVVM01.DAL
{
    public interface IUsuarioService
    {
        List<Usuario> GetUsuario();
        
    }
}
