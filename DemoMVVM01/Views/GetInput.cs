using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using DemoMVVM01.Models;

namespace DemoMVVM01.Views
{
    public class GetInput //: INotifyPropertyChanged
    {
        //static public int id;
        static public string nombre;
        static public string apellido;
    }
}


//public event PropertyChangedEventHandler PropertyChanged;

//private void OnPropertyChanged(string property) {
//    if (PropertyChanged != null)
//    {
//        PropertyChanged(this, new PropertyChangedEventArgs(property));
//    }
//}

//public string Nombre {
//        get { return nombre; }
//        set { nombre = value; }
//    }
//public string Apellido{
//        get { return apellido; }
//        set { apellido = value; }
//    }