using AppExemploMVVM.ViewModels;
using System.Windows.Controls;

namespace AppExemploMVVM.Views
{
    /// <summary>
    /// Interação lógica para Inicio.xam
    /// </summary>
    public partial class Inicio : Page
    {
        public Inicio()
        {
            InitializeComponent();
            this.DataContext = new InicioViewModel(); // Injeta a ViewModel no DataContext 
        }
    }
}
