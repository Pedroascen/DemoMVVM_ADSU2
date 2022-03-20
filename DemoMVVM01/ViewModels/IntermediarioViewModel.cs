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
        //view model base es una clase base que hereda de las interfazes --anote
        #region Properties
        private List<Usuario> usuarios;
        //instanciar cuando se ejecuta el app
        UsuarioService usuarioService = new UsuarioService();

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

        public List<Usuario> Usuario { 
            get { return usuarios; }
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

        public void EjecutarCommand(){
            //MessageBox.Show("Hola desde el ModelView");
            //usuarioCommandExecute();
        }

        int contador = 1;
        public void usuarioCommandExecute()
        {
            Usuario usuario = new Usuario();
            usuario.ID = contador;
            usuario.Nombre = GetInput.nombre;
            usuario.Apellido = GetInput.apellido;
            usuario.Hora = DateTime.Now.AddDays(usuario.ID);

            if (usuario.Nombre == null || usuario.Apellido == null)
            {
                //MessageBox.Show("Datos no guardados");
                return;
            }

            usuarioService.SaveUsuario(usuario);
            var result = usuarioService.GetUsuario();

            GetInput.nombre = null;
            GetInput.apellido = null;

            Usuarios = new List<Usuario>(result);
            contador++;
               
        }
    }
}
