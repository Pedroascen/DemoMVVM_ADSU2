using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DemoMVVM01
{
    public abstract class BaseViewModel : INotifyPropertyChanging, INotifyPropertyChanged
    {
        //Notificadores de eventos 
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyCahnging([CallerMemberName] string propertyName = ""){
            PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
        }

        protected void OnPropertiesChanged([CallerMemberName] string propertyName = "") {

            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
