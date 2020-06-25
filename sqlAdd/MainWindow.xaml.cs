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

namespace sqlAdd
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public class Coucou : ContentControl
    {
        public string Salutation { get; set; }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //button.HorizontalAlignment = HorizontalAlignment.Left;

            //var b = new Button();
            //b.Content = "Coucou";
            //b.HorizontalAlignment = HorizontalAlignment.Left;
            //b.Margin = new Thickness(204, 170, 0, 0);
            //maGrille.Children.Add(b);
        }
    }
}
