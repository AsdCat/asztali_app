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

namespace _20241114___Listák_és_osztályok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            KönyvModel k1 = new KönyvModel("A. A. Milne", "Micimackó");
            this.könyvLista.Items.Add(k1);

            KönyvModel k2 = new KönyvModel("Antoine de Saint-Exupéry", "Kisherceg");
            this.könyvLista.Items.Add(k2);

        }

        private void newBook_Click(object sender, RoutedEventArgs e)
        {
            KönyvModel segéd = null;
            ÚjKönyv úk;
            if (this.könyvLista.SelectedItem != null)
            {
                segéd = this.könyvLista.SelectedItem as KönyvModel;
                úk    = new ÚjKönyv(segéd.Szerző);
            }
            else
            {
                úk = new ÚjKönyv();
            }

            if (úk.ShowDialog() == true)
            {
                this.könyvLista.Items.Add(úk.könyv);
            }

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void modifyBook_Click(object sender, RoutedEventArgs e)
        {
            ÚjKönyv úk = new ÚjKönyv();
            úk.Szerző.Text = (this.könyvLista.SelectedItem as KönyvModel).Szerző;
            úk.Cím.Text    = (this.könyvLista.SelectedItem as KönyvModel).Cím;
            if (úk.ShowDialog() == true)
            {
                (this.könyvLista.SelectedItem as KönyvModel).Szerző = úk.könyv.Szerző;
                (this.könyvLista.SelectedItem as KönyvModel).Cím    = úk.könyv.Cím;
            }
            this.könyvLista.Items.Refresh();
        }
    }
}