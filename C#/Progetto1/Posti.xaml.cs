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
    /// Logica di interazione per Posti.xaml
    /// </summary>
    public partial class Posti : Window
    {
        string numPosto = "";
        string[] vett1 = new string[9];
        public Posti()
        {
            InitializeComponent();
        }

        public Posti(string p)
        {
            InitializeComponent();
            numPosto = p;
        }

        public Posti(string p, string[] vett)
        {
            InitializeComponent();
            numPosto = p;

            vett1 = vett;

            if(vett1[Int32.Parse(p) - 1] != "0")
            {
                string[] a = vett1[Int32.Parse(p) - 1].Split(';');

                txtNome.Text = a[0];
                txtCognome.Text = a[1];
                txtEta.Text = a[2];
            }
        }

        private void btn_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string line = "";
            if (txtNome.Text != "")
            {
                if (txtCognome.Text != "")
                {
                    if(txtEta.Text != "")
                    {
                        line = txtNome.Text + ";" + txtCognome.Text + ";" + txtEta.Text + ";" + "1";

                        vett1[Int32.Parse(numPosto) - 1] = line;

                        Prenotazione p = new Prenotazione(vett1);
                        p.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Dati Mancanti", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Dati Mancanti", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Dati Mancanti", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
