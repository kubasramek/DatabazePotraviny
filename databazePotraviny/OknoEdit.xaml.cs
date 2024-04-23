using databazePotraviny;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DatabazePotraviny
{
    /// <summary>
    /// Interakční logika pro OknoEdit.xaml
    /// </summary>
    public partial class OknoEdit : Window
    {
        public Polozka Z {  get; set; }
        public OknoEdit(Polozka z)
        {
            InitializeComponent();
            Z = z;
            DataContext = Z;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Z.Nazev = ProNazev.Text;
            Z.Cena = int.Parse(ProCenu.Text);
            Z.Pocet = int.Parse(ProPocet.Text);

            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
