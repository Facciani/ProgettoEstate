using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Progetto1
{
    /// <summary>
    /// Logica di interazione per Selezione_Film.xaml
    /// </summary>
    public partial class Selezione_Film : Window
    {
        public Selezione_Film()
        {
            InitializeComponent();
           
        }

        private void btn2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Prenotazione p = new Prenotazione("2");
            p.Show();
            this.Hide();
        }

        private void btn1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Prenotazione p = new Prenotazione("1");
            p.Show();
            this.Hide();
        }

        private void Image_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Prenotazione p = new Prenotazione("3");
            p.Show();
            this.Hide();
        }
    }
}
