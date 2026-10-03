using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SistemaLogistica.Infraesctrutura.Data;
using Microsoft.EntityFrameworkCore;

namespace SistemaLogistica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CargarProductos();
        }
        private void CargarProductos()
        {
            var productos = App.Db.Productos.ToList();
            ProductosGrid.ItemsSource = productos;
        }
    }
}