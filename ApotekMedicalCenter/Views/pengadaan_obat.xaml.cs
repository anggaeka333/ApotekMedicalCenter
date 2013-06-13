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
using ApotekMedicalCenter.Controllers;

namespace ApotekMedicalCenter.Views
{
    /// <summary>
    /// Interaction logic for dataobat.xaml
    /// </summary>
    public partial class dataobat : Window
    {
        public dataobat()
        {
            InitializeComponent();

        }

        private bool IsValid()
        {
            bool validation = true;

            if (TextBoxIDObat.Text == "")
            {
                TextBlock.Text += "- ID Obat wajib diisi untuk memasukkan ke daftar pembelian.\n";
                validation = false;
            }

            return validation;
        }

        private void ButtonEntry_Click(object sender, RoutedEventArgs e)
        {
            TextBlock.Text = "";

            if (!IsValid())
            {
                return;
            }
        }

    }
}
