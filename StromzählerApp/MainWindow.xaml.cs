using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StromzählerApp
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

        private void eintragenbtn_Click(object sender, RoutedEventArgs e)
        {
            Eintraege eintragen = new Eintraege(this);
            eintragen.Show();
            this.Hide();
        }

        private void listebtn_Click(object sender, RoutedEventArgs e)
        {
            Window raumliste = new Raumliste(this);
            raumliste.Show();
            this.Hide();
        }

        private void progschliessenbtn_Click(object sender, RoutedEventArgs e)
        {
            CloseAllWindows();
        }

        private void CloseAllWindows()
        {
            foreach (Window window in Application.Current.Windows)
            {
                var result = MessageBox.Show("Möchten Sie das Programm wirklich schließen?", "Programm schließen", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    Application.Current.Shutdown();
                }                
            }
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CloseAllWindows();
            Application.Current.Shutdown();
        }
    }
}
