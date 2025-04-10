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
    /// Interaktionslogik für Eintraege.xaml
    /// </summary>
    public partial class Eintraege : Window
    {
        private Window _parentWindow;
        public Eintraege(Window parent)
        {
            InitializeComponent();
            _parentWindow = parent;
        }

        private void weiterbtn_Click(object sender, RoutedEventArgs e)
        {
            Eintraege2 eintraege2 = new Eintraege2(this);
            eintraege2.Show();
            this.Hide();
        }

        private void abbrechenbtn_Click(object sender, RoutedEventArgs e)
        {
            Window mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }
    }
}
