using DemoMVVM01.Models;
using System;
using System.Collections.Generic;


namespace DemoMVVM01.DAL
{
    public class UsuarioService : IUsuarioService
    {
        Usuario usuario = new Usuario();
        List<Usuario> usuarios = new List<Usuario>();

        public List<Usuario> GetUsuario()
        {  
            return usuarios;
        }
        public bool SaveUsuario(Usuario usuario) {
            if (usuario == null) {
                return false;
            }
            usuarios.Add(usuario);
            return true;
        }
    }
}
