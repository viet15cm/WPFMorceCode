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
using WpfMorceCode;
namespace WpfMorceCode
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

        public bool FixBug()
        {
            if (txbBits.Text.Equals(""))
                return false;

            return true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (FixBug() == false)
            {
                MessageBox.Show("Ban chua nhap cuoi bits");
            }
            else
            {
                txblTranslaterMorse.Text = TranslaterMorseBit.decodeBitsAdvanced(txbBits.Text.ToString());
                txblTranslaterCharaters.Text = TranslaterMorseCharacters.decodeMorse(txblTranslaterMorse.Text);
            }
           
            
           


        }
    }
}
