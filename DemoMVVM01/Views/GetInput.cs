using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DemoMVVM01.Views
{
    class GetInput : INotifyPropertyChanged
    {
        string nombre,apellido;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property) {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    
    public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }
    public string Apellido{
            get { return apellido; }
            set { apellido = value; }
        }
    }
}
