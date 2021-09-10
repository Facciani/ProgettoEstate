using System;
using System.Collections.Generic;
using System.IO.Ports;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Progetto1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SerialPort com1;
        int f = 0;
        public MainWindow()
        {
            InitializeComponent();
            com1 = new SerialPort("COM3", 9600);
            try
            {
                com1.Open();
                com1.DataReceived += Com1_DataReceived;
            }
            catch
            {
                MessageBox.Show("Nessun arduino rilevato", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Com1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string temp;
            temp = com1.ReadExisting();
            AppendTextInvoke(txt, temp);
        }
        private void AppendTextInvoke(TextBox t, string text)
        {
            if (!CheckAccess())
            {
                if (f == 0)
                {
                    Dispatcher.Invoke(() =>
                    {
                        if (f == 0)
                        {
                            AppendTextInvoke(t, text);
                        }
                    });
                }
            }
            else
            {
                t.AppendText(text);

                string[] vett = t.Text.Split(';');


                for (int i = 1; i < vett.Length - 1; i++)
                {
                    try
                    {
                        int a = Int32.Parse(vett[i]);
                        if (a < 10)
                        {
                            Selezione_Film sel = new Selezione_Film();
                            sel.Show();
                            this.Close();
                            f = 1;
                            break;
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }
    }
}
