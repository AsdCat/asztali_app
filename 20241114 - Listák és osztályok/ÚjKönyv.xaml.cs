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

namespace _20241114___Listák_és_osztályok
{
    /// <summary>
    /// Interaction logic for ÚjKönyv.xaml
    /// </summary>
    public partial class ÚjKönyv : Window
    {
        public KönyvModel könyv;

        public ÚjKönyv()
        {
            InitializeComponent();
        }
        public ÚjKönyv(string szerző):this()
        {
            this.Szerző.Text = szerző;   
        }

        private void Mentés_Click(object sender, RoutedEventArgs e)
        {
            this.könyv = new KönyvModel(this.Szerző.Text, this.Cím.Text);
            //this.Hide();
            this.DialogResult = true;
            this.Close();
        }

        private void Mégse_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
