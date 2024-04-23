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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Polozka? hledany = Seznam?.SelectedItem as Polozka;
            if (hledany != null)
            {
                OknoEdit edit = new OknoEdit(hledany);
                edit.Closing += Dialog_Closing;
                edit.ShowDialog();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Polozka? hledana = Seznam?.SelectedItem as Polozka;
            MessageBoxResult volba = MessageBox.Show($"Odebrat {hledana.Nazev}?", "Odebrat",MessageBoxButton.YesNo);
            if(volba == MessageBoxResult.Yes)
            {
                Polozky.Remove(hledana);
                Seznam.ItemsSource = null;
                Seznam.ItemsSource = Polozky;
            }
        }
    }
}