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

namespace ScontoWPF
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

        private void Calcola_Click(object sender, RoutedEventArgs e)
        {
            double importo = double.Parse(txtImporto.Text);
            double percSconto = 0;
            if (txtScontoperc.Text.Length > 0)
                percSconto= double.Parse(txtScontoperc.Text); 
            double sconto = importo  / 100 * percSconto;
            txtSconto.Text = String.Format("{0:C}", sconto);

            double percIVA = double.Parse(txtIVAperc.Text);
            double valoreIVA = percIVA * (importo-sconto) /100;
            txtIVA.Text = String.Format("{0:C}", valoreIVA);

            double tot = importo - sconto + valoreIVA;
            txtTotale.Text = String.Format("{0:C}", tot);



        }
    }
}
