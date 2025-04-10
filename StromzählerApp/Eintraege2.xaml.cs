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
    /// Interaktionslogik für Eintraege2.xaml
    /// </summary>
    public partial class Eintraege2 : Window
    {
        private Window _parentWindow;
        public Eintraege2(Window parent)
        {
            InitializeComponent();
            _parentWindow = parent;

        }

        private void zurueckbtn_Click(object sender, RoutedEventArgs e)
        {
            Eintraege eintraege = new Eintraege(this);
            eintraege.Show();
            this.Close();
        }

        private void abbrechenbtn_Click(object sender, RoutedEventArgs e)
        {
            _parentWindow.Show();
            this.Close();
        }
    }
}
