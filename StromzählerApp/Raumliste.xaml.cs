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

namespace StromzählerApp
{
    /// <summary>
    /// Interaktionslogik für Raumliste.xaml
    /// </summary>

    public partial class Raumliste : Window
    {
        private Window _parentWindow;
        public Raumliste(Window parent)
        {
            InitializeComponent();
            _parentWindow = parent;
        }

        private void neuItem_Click(object sender, RoutedEventArgs e)
        {
            Eintraege eintraege = new Eintraege(this);
            eintraege.Show();
            this.Hide();
        }

        private void zurueckbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
