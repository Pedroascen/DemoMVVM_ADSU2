
using DemoMVVM01.ViewModels;
using System.Windows;


namespace DemoMVVM01.Views
{
    public partial class MainWindow : Window
    {
        IntermediarioViewModel model = new IntermediarioViewModel();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (INombreText.Text == string.Empty || IApellidoText.Text == string.Empty)
            {
                MessageBox.Show("Por favor verifique los campos.");
                return;
            }
            else {
                //GetInput.id = Int32.Parse(IdText.Text);
                GetInput.nombre = INombreText.Text;
                GetInput.apellido = IApellidoText.Text;
                //MessageBox.Show("Su nombre es: " + GetInput.nombre + " " + GetInput.apellido);
                //IdText.Clear();
                INombreText.Clear();
                IApellidoText.Clear();
            }
        }
    }
}
