using System.ComponentModel;
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

namespace _20241128___Binding_alapjai
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        #region Szám1
        public int Szám1 { get; set; }

        private void Szám1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this.Szám1.ToString());
        }

        private void Hozzáadás_Click(object sender, RoutedEventArgs e)
        {
            this.Szám1++;
            this.Szám1Textbox.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
        }
        #endregion

        #region Szám2
        private int szám2 = 8;

        public event PropertyChangedEventHandler? PropertyChanged;

        public int Szám2 { get => szám2; set => szám2 = value; }

        private void Szám2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this.Szám2.ToString());
        }

        private void Hozzáadás2_Click(object sender, RoutedEventArgs e)
        {
            this.Szám2++;
            this.Frissítés();
        }

        private void Frissítés()
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs("Szám2"));
        }
        

        private void Szám2Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.Frissítés();
        }

        private void Szám2_2Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Frissítés();
        }
        #endregion

        #region NévEmail

        public class User:INotifyPropertyChanged
        {
            private string name = "";
            public string Name {
                get => this.name;
                set {
                    this.name = value;
                    if (this.PropertyChanged != null)
                        this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
            private string email = "";
            public string Email
            {
                get => this.email;
                set
                {
                    this.email = value;
                    if (this.PropertyChanged != null)
                        this.PropertyChanged(this, new PropertyChangedEventArgs("Email"));
                }
            }

            public event PropertyChangedEventHandler? PropertyChanged;
        }

        private User u1 = new User()
        {
            Name = "Kovács János",
            Email = "kovacs@janos.hu"
        };
        public User U1
        {
            get => u1;
            set => u1 = value;
        }

        private void UserKiiratás_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this.U1.Name + ": " + this.U1.Email);
        }

        private void NévMegváltoztatása_Click(object sender, RoutedEventArgs e)
        {
            this.U1.Name  = "Nagy János";
            this.U1.Email = "nagy@janos.eu";
        }
        #endregion

    }
}