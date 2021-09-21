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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lista
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<string> lista = new List<string>();

        private void btnAggiungi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtTesto.Text == "")
                    throw new Exception("Inserisci un valore nella casella di testo!");
                string testo = txtTesto.Text;
                lbLista.Items.Add(testo);
                lista.Add(testo);
                txtTesto.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRimuovi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int i = lbLista.SelectedIndex;
                lbLista.Items.RemoveAt(i);
                lista.RemoveAt(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConta_Click(object sender, RoutedEventArgs e)
        {
            List<string> numeri = new List<string>();
            foreach (string s in lista)
            {
                if (s.All(char.IsNumber))
                {
                    numeri.Add(s);
                }
            }
        }
    }
}
