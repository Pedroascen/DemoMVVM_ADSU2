using DemoMVVM01.DAL;
using DemoMVVM01.Models;
using DemoMVVM01.Views;
using System;
using System.Collections.Generic;
using System.Windows;
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
            //usuarioCommandExecute();
        }

        public void usuarioCommandExecute()
        {


            var usuarioService = new UsuarioService();
            Usuario usuario = new Usuario();

            usuario.ID++;
            usuario.Nombre = GetInput.nombre;
            usuario.Apellido = GetInput.apellido;
            usuario.Hora = DateTime.Now.AddDays(usuario.ID);

            if (usuario.Nombre == null || usuario.Apellido == null) {
                //MessageBox.Show("Datos no guardados");
                return;
            }
            else
            {
                usuarioService.SaveUsuario(usuario);
                var result = usuarioService.GetUsuario();
                Usuarios = new List<Usuario>(result);
            }

        }
    }
}
