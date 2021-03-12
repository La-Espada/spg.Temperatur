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

namespace spg.Temperatur
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

        private void tempSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(e.NewValue < 0)
            {
                celsius.Foreground = Brushes.White;
                fahrenheit.Foreground = Brushes.White;
                
            }
            else if(e.NewValue >= 0 && e.NewValue <=25)
            {
                celsius.Foreground = Brushes.Black;
                fahrenheit.Foreground = Brushes.Black;
            }
            else if(e.NewValue > 25)
            {
                celsius.Foreground = Brushes.Red;
                fahrenheit.Foreground = Brushes.Red;
            }
        }
    }
}
