using databazePotraviny;
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

namespace DatabazePotraviny
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Polozka> Polozky { get; set; }
        public MainWindow()
        {
            Polozky = new();
            InitializeComponent();
            Seznam.ItemsSource = Polozky;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OknoPridat dialog = new(Polozky);
            dialog.Closing += Dialog_Closing;
            dialog.ShowDialog();
        }
        private void Dialog_Closing(object? sender, EventArgs e)
        {
            Seznam.ItemsSource = null;
            Seznam.ItemsSource = Polozky;
        }

    }
}