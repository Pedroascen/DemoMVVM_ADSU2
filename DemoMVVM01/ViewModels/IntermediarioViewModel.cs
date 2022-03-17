using DemoMVVM01.DAL;
using DemoMVVM01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace DemoMVVM01.ViewModels
{
    public class IntermediarioViewModel : BaseViewModel
    {

        //view model base es una clase base que hereda de las interfazes anote
        #region Properties
        private List<Usuario> usuarios;


        public List<Usuario> Usuarios {
            get {
                return usuarios;
            }
            set {
                if (usuarios == value) {
                    return;
                }
                usuarios = value;
                OnPropertiesChanged("Usuarios");
            }
        }
        #endregion

        #region Comands
        private ICommand usuarioCommand;

        public ICommand UsuarioCommand
        {
            get {
                if (usuarioCommand == null) {
                    usuarioCommand = new RelayCommand(param => this.usuarioCommandExecute(), null);
                }

                return usuarioCommand;
            }
        }
        #endregion


        public IntermediarioViewModel() {
           
        }

        private void usuarioCommandExecute()
        {
            Usuario usuario = new Usuario();
            var usuarioService = new UsuarioService();
            
                usuario.ID = 1;
                usuario.Nombre = "Luisa";
                usuario.Apellido = "Canizalez";
                usuario.UltiLogin = DateTime.Now.AddDays(usuario.ID);

                
                usuarioService.SaveUsuario(usuario);
            

            var result = usuarioService.GetUsuario();
            Usuarios = new List<Usuario>(result);
        }
    }
}
