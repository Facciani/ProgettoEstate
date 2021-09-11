using System;
using System.Collections.Generic;
using System.IO;
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
    /// Logica di interazione per Prenotazione.xaml
    /// </summary>
    public partial class Prenotazione : Window
    {
        int count = 0;
        string[] postiPresi = new string[9];
        int prezzo = 0;
        int postiLiberi = 0;
        int postiOccupati = 0;
        int postiPrenotati = 0;
        string numFilm;
        string[] stato = new string[9];
        string[] vett = new string[9];
        public Prenotazione()
        {
            InitializeComponent();
        }

        public Prenotazione(string film)
        {
            InitializeComponent();
            numFilm = film;
            if(numFilm == "1")
            {
                img.Source = new BitmapImage(new Uri(@"locandina1.jpg", UriKind.RelativeOrAbsolute));
                title.Text = "Avengers endgame";
            }else if(numFilm == "2")
            {
                img.Source = new BitmapImage(new Uri(@"locandina2.jpg", UriKind.RelativeOrAbsolute));
                title.Text = "Hollywood";
            }
            else
            {
                img.Source = new BitmapImage(new Uri(@"locandina3.jpg", UriKind.RelativeOrAbsolute));
                title.Text = "Interstellar";
            }

            popolaPosti(numFilm);

            popolaLabel();

            postiLiberi = 0;
            postiOccupati = 0;
            postiPrenotati = 0;
        }

        public Prenotazione(string[] vett1,string numfilm)
        {
            InitializeComponent();

            numFilm = numfilm;

            if (numFilm == "1")
            {
                img.Source = new BitmapImage(new Uri(@"locandina1.jpg", UriKind.RelativeOrAbsolute));
                title.Text = "Avengers endgame";
            }
            else if (numFilm == "2")
            {
                img.Source = new BitmapImage(new Uri(@"locandina2.jpg", UriKind.RelativeOrAbsolute));
                title.Text = "Hollywood";
            }
            else
            {
                img.Source = new BitmapImage(new Uri(@"locandina3.jpg", UriKind.RelativeOrAbsolute));
                title.Text = "Interstellar";
            }

            vett = vett1;
            for (int i = 0; i < vett.Length; i++)
            {
                if (vett[i] == "0")
                {
                    stato[i] = "verde";
                }
                else if (vett[i].Split(';')[3] == "1")
                {
                    stato[i] = "giallo";
                    prezzo += Int32.Parse(vett[i].Split(';')[4]);
                }
                else
                {
                    stato[i] = "rosso";
                }
            }
            coloraPosti(stato);

            popolaLabel();

            postiLiberi = 0;
            postiOccupati = 0;
            postiPrenotati = 0;
        }

        public void popolaLabel()
        {
            postiLiberi1.Text = postiLiberi.ToString();
            postiOccupati1.Text = postiOccupati.ToString();
            postiPrenotati1.Text = postiPrenotati.ToString();
            postiPrezzo1.Text = prezzo.ToString();
        }
        public void popolaPosti(string numfilm)
        {
            string line = "";
            int i = 0;

            if (numfilm == "1")
            {
                StreamReader sr = new StreamReader("posti1.txt");
                line = sr.ReadLine();

                vett = line.Split('-');

                for (int a = 0; a < vett.Length; a++)
                {
                    if (vett[a] == "0")
                    {
                        stato[a] = "verde";
                    }
                    else
                    {
                        string[] vettTest = vett[a].Split(';');
                        if (vettTest[3] == "0")
                        {
                            stato[a] = "rosso";
                        }
                        else
                        {
                            stato[a] = "giallo";
                        }
                    }
                }
                
                coloraPosti(stato);
            }
            else if (numfilm == "2")
            {
                StreamReader sr = new StreamReader("posti2.txt");
                line = sr.ReadLine();

                vett = line.Split('-');

                for (int a = 0; a < vett.Length; a++)
                {
                    if (vett[a] == "0")
                    {
                        stato[a] = "verde";
                    }
                    else
                    {
                        string[] vettTest = vett[a].Split(';');
                        if (vettTest[3] == "0")
                        {
                            stato[a] = "rosso";
                        }
                        else
                        {
                            stato[a] = "giallo";
                        }
                    }
                }
                coloraPosti(stato);
            }
            else
            {
                StreamReader sr = new StreamReader("posti3.txt");
                line = sr.ReadLine();

                vett = line.Split('-');

                for (int a = 0; a < vett.Length; a++)
                {
                    if (vett[a] == "0")
                    {
                        stato[a] = "verde";
                    }
                    else
                    {
                        string[] vettTest = vett[a].Split(';');
                        if (vettTest[3] == "0")
                        {
                            stato[a] = "rosso";
                        }
                        else
                        {
                            stato[a] = "giallo";
                        }
                    }
                }
                coloraPosti(stato);
            }
        }

        private void btnBack_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Selezione_Film s = new Selezione_Film();
            s.Show();
            this.Hide();
        }

        public void coloraPosti(string[] color)
        {
            if (color[0] == "verde")
            {
    
                posto1.Source = new BitmapImage(new Uri(@"posto_libero.jpg", UriKind.RelativeOrAbsolute));
                postiLiberi++;
            }
            else if (color[0] == "rosso")
            {
                posto1.Source = new BitmapImage(new Uri(@"posto_occupato.jpg", UriKind.RelativeOrAbsolute));
                postiOccupati++;
            }
            else
            {
                posto1.Source = new BitmapImage(new Uri(@"posto_prenotato.jpg", UriKind.RelativeOrAbsolute));
                postiPrenotati++;
            }

            if (color[1] == "verde")
            {
                posto2.Source = new BitmapImage(new Uri(@"posto_libero.jpg", UriKind.RelativeOrAbsolute));
                postiLiberi++;
            }
            else if (color[1] == "rosso")
            {
                posto2.Source = new BitmapImage(new Uri(@"posto_occupato.jpg", UriKind.RelativeOrAbsolute));
                postiOccupati++;
            }
            else
            {
                posto2.Source = new BitmapImage(new Uri(@"posto_prenotato.jpg", UriKind.RelativeOrAbsolute));
                postiPrenotati++;
            }

            if (color[2] == "verde")
            {
                posto3.Source = new BitmapImage(new Uri(@"posto_libero.jpg", UriKind.RelativeOrAbsolute));
                postiLiberi++;
            }
            else if (color[2] == "rosso")
            {
                posto3.Source = new BitmapImage(new Uri(@"posto_occupato.jpg", UriKind.RelativeOrAbsolute));
                postiOccupati++;
            }
            else
            {
                posto3.Source = new BitmapImage(new Uri(@"posto_prenotato.jpg", UriKind.RelativeOrAbsolute));
                postiPrenotati++;
            }

            if (color[3] == "verde")
            {
                posto4.Source = new BitmapImage(new Uri(@"posto_libero.jpg", UriKind.RelativeOrAbsolute));
                postiLiberi++;
            }
            else if (color[3] == "rosso")
            {
                posto4.Source = new BitmapImage(new Uri(@"posto_occupato.jpg", UriKind.RelativeOrAbsolute));
                postiOccupati++;
            }
            else
            {
                posto4.Source = new BitmapImage(new Uri(@"posto_prenotato.jpg", UriKind.RelativeOrAbsolute));
                postiPrenotati++;
            }

            if (color[4] == "verde")
            {
                posto5.Source = new BitmapImage(new Uri(@"posto_libero.jpg", UriKind.RelativeOrAbsolute));
                postiLiberi++;
            }
            else if (color[4] == "rosso")
            {
                posto5.Source = new BitmapImage(new Uri(@"posto_occupato.jpg", UriKind.RelativeOrAbsolute));
                postiOccupati++;
            }
            else
            {
                posto5.Source = new BitmapImage(new Uri(@"posto_prenotato.jpg", UriKind.RelativeOrAbsolute));
                postiPrenotati++;
            }

            if (color[5] == "verde")
            {
                posto6.Source = new BitmapImage(new Uri(@"posto_libero.jpg", UriKind.RelativeOrAbsolute));
                postiLiberi++;
            }
            else if (color[5] == "rosso")
            {
                posto6.Source = new BitmapImage(new Uri(@"posto_occupato.jpg", UriKind.RelativeOrAbsolute));
                postiOccupati++;
            }
            else
            {
                posto6.Source = new BitmapImage(new Uri(@"posto_prenotato.jpg", UriKind.RelativeOrAbsolute));
                postiPrenotati++;
            }

            if (color[6] == "verde")
            {
                posto7.Source = new BitmapImage(new Uri(@"posto_libero.jpg", UriKind.RelativeOrAbsolute));
                postiLiberi++;
            }
            else if (color[6] == "rosso")
            {
                posto7.Source = new BitmapImage(new Uri(@"posto_occupato.jpg", UriKind.RelativeOrAbsolute));
                postiOccupati++;
            }
            else
            {
                posto7.Source = new BitmapImage(new Uri(@"posto_prenotato.jpg", UriKind.RelativeOrAbsolute));
                postiPrenotati++;
            }

            if (color[7] == "verde")
            {
                posto8.Source = new BitmapImage(new Uri(@"posto_libero.jpg", UriKind.RelativeOrAbsolute));
                postiLiberi++;
            }
            else if (color[7] == "rosso")
            {
                posto8.Source = new BitmapImage(new Uri(@"posto_occupato.jpg", UriKind.RelativeOrAbsolute));
                postiOccupati++;
            }
            else
            {
                posto8.Source = new BitmapImage(new Uri(@"posto_prenotato.jpg", UriKind.RelativeOrAbsolute));
                postiPrenotati++;
            }

            if (color[8] == "verde")
            {
                posto9.Source = new BitmapImage(new Uri(@"posto_libero.jpg", UriKind.RelativeOrAbsolute));
                postiLiberi++;
            }
            else if (color[8] == "rosso")
            {
                posto9.Source = new BitmapImage(new Uri(@"posto_occupato.jpg", UriKind.RelativeOrAbsolute));
                postiOccupati++;
            }
            else
            {
                posto9.Source = new BitmapImage(new Uri(@"posto_prenotato.jpg", UriKind.RelativeOrAbsolute));
                postiPrenotati++;
            }
        }

        private void posto1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (stato[0] == "verde")
            {
                Posti p = new Posti("1", vett,numFilm);
                p.Show();
                this.Hide();
            }
            else if (stato[0] == "giallo")
            {
                Posti a = new Posti("1", vett, numFilm);
                a.Show();
                this.Hide();
            }
        }

        private void posto2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (stato[1] == "verde")
            {
                Posti p = new Posti("2", vett, numFilm);
                p.Show();
                this.Hide();
            }
            else if (stato[1] == "giallo")
            {
                Posti a = new Posti("2", vett, numFilm);
                a.Show();
                this.Hide();
            }
        }

        private void posto3_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (stato[2] == "verde")
            {
                Posti p = new Posti("3", vett, numFilm);
                p.Show();
                this.Hide();
            }
            else if (stato[2] == "giallo")
            {
                Posti a = new Posti("3", vett, numFilm);
                a.Show();
                this.Hide();
            }
        }

        private void posto4_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (stato[3] == "verde")
            {
                Posti p = new Posti("4", vett, numFilm);
                p.Show();
                this.Hide();
            }
            else if (stato[3] == "giallo")
            {
                Posti a = new Posti("4", vett, numFilm);
                a.Show();
                this.Hide();
            }
        }

        private void posto5_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (stato[4] == "verde")
            {
                Posti p = new Posti("5", vett, numFilm);
                p.Show();
                this.Hide();
            }
            else if (stato[4] == "giallo")
            {
                Posti a = new Posti("5", vett, numFilm);
                a.Show();
                this.Hide();
            }
        }

        private void posto6_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (stato[5] == "verde")
            {
                Posti p = new Posti("6", vett, numFilm);
                p.Show();
                this.Hide();
            }
            else if (stato[5] == "giallo")
            {
                Posti a = new Posti("6", vett, numFilm);
                a.Show();
                this.Hide();
            }
        }

        private void posto7_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (stato[6] == "verde")
            {
                Posti p = new Posti("7", vett, numFilm);
                p.Show();
                this.Hide();
            }
            else if (stato[6] == "giallo")
            {
                Posti a = new Posti("7", vett, numFilm);
                a.Show();
                this.Hide();
            }
        }

        private void posto8_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (stato[7] == "verde")
            {
                Posti p = new Posti("8", vett, numFilm);
                p.Show();
                this.Hide();
            }
            else if (stato[7] == "giallo")
            {
                Posti a = new Posti("8", vett, numFilm);
                a.Show();
                this.Hide();
            }
        }

        private void posto9_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (stato[8] == "verde")
            {
                Posti p = new Posti("9", vett, numFilm);
                p.Show();
                this.Hide();
            }
            else if (stato[8] == "giallo")
            {
                Posti a = new Posti("9", vett, numFilm);
                a.Show();
                this.Hide();
            }
        }

        private void imgShop_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int count = 0;
            for(int i = 0; i< vett.Length; i++)
            {
                if(vett[i]!="0")
                {
                    if(vett[i].Split(';')[3] == "1")
                    {
                        count++;
                    }
                }
            }

            if (count == 0)
            {
                MessageBox.Show("Non sono stati aquistati biglietti", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                var result = MessageBox.Show("Sei sicuro di voler aqcuistare questi biglietti?", "Acquisto", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if(result == MessageBoxResult.Yes)
                {
                    string vettfin = "";
                    for (int i = 0; i < vett.Length; i++)
                    {
                        if (vett[i] == "0")
                        {
                            if (i != vett.Length - 1)
                            {
                                vettfin += "0" + "-";
                            }
                            else
                            {
                                vettfin += "0";
                            }
                        }
                        else
                        {
                            if (vett[i].Split(";")[3] == "1")
                            {
                                string[] a = vett[i].Split(';');

                                a[3] = "0";

                                string b = a[0] + ";" + a[1] + ";" + a[2] + ";" + a[3] + ";" + a[4] + ";" + a[5];

                                vett[i] = b;

                                postiPresi[count] = vett[i].Split(";")[5];
                                if (i != vett.Length - 1)
                                {
                                    vettfin += vett[i] + "-";
                                }
                                else
                                {
                                    vettfin += vett[i];
                                }
                            }
                            else
                            {
                                if (i != vett.Length - 1)
                                {
                                    vettfin += vett[i] + "-";
                                }
                                else
                                {
                                    vettfin += vett[i];
                                }
                            }
                        }
                    }
                    if (title.Text == "Avengers endgame")
                    {
                        File.WriteAllText("posti1.txt", vettfin);
                    }
                    else if (title.Text == "Hollywood")
                    {
                        File.WriteAllText("posti2.txt", vettfin);
                    }
                    else
                    {
                        File.WriteAllText("posti3.txt", vettfin);
                    }

                    MainWindow m = new MainWindow();
                    m.Show();
                    this.Hide();
                }
            }
        }
    }
}
