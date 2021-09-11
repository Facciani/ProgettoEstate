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
        string num;
        int el = 0;
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

        public Posti(string p, string[] vett, string numfilm)
        {
            InitializeComponent();
            numPosto = p;
            num = numfilm;

            vett1 = vett;

            if(vett1[Int32.Parse(p) - 1] != "0")
            {
                el = 1;
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
                        string a = "";
                        if (Int32.Parse(txtEta.Text) < 14)
                        {
                            a = "6";
                            line = txtNome.Text + ";" + txtCognome.Text + ";" + txtEta.Text + ";" + "1" + ";" + a + ";" + numPosto;
                        }
                        else
                        {
                            a = "8";
                            line = txtNome.Text + ";" + txtCognome.Text + ";" + txtEta.Text + ";" + "1" + ";" + a + ";" + numPosto;
                        }

                        var result = MessageBox.Show("Sei sicuro di voler comprare questo posto? Il prezzo sarà di: " + a + "€", "Aqcuisto" ,MessageBoxButton.YesNo,MessageBoxImage.Question);

                        if(result == MessageBoxResult.Yes)
                        {
                            vett1[Int32.Parse(numPosto) - 1] = line;

                            Prenotazione p = new Prenotazione(vett1,num);
                            p.Show();
                            this.Hide();
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
            else
            {
                MessageBox.Show("Dati Mancanti", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void cestinoimg_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string line = "0";
            if (el == 1)
            {
                var result = MessageBox.Show("Sei sicuro di voler eliminare questo posto", "Cancellazione", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    vett1[Int32.Parse(numPosto) - 1] = line;

                    Prenotazione p = new Prenotazione(vett1, num);
                    p.Show();
                    this.Hide();
                }
            }
        }

        private void btnBack_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Prenotazione p = new Prenotazione(vett1, num);
            p.Show();
            this.Hide();
        }
    }
}
