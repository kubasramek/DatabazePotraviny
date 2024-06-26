﻿using System;
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

namespace databazePotraviny
{
    /// <summary>
    /// Interakční logika pro OknoPridat.xaml
    /// </summary>
    
    public partial class OknoPridat : Window
    {
        List<Polozka> _polozky;
        public OknoPridat(List<Polozka> polozky)
        {
            InitializeComponent();
            _polozky = polozky;
        }
        private int VytvorID() => _polozky.Count + 1;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nazev = TBNazev.Text;
            int cena = int.Parse(TBCena.Text);
            int pocet = int.Parse(TBPocet.Text);

            Polozka Novy = new Polozka(VytvorID(),nazev, cena, pocet);
            _polozky.Add(Novy);

            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
