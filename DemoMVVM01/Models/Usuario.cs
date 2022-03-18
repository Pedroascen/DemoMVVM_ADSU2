using System;

namespace DemoMVVM01.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Hora { get; set; }

        public Usuario()
        {
        }
    }
}
