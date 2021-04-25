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

namespace dependency_property
{
    /// <summary>
    /// Логика взаимодействия для Marsh.xaml
    /// </summary>
    public partial class Marsh : Window
    {
        public Marsh()
        {
            InitializeComponent();
        }
        int i = 0;
        private void Some_Clicked(object sender, MouseButtonEventArgs e)
        {
            i++;
            string message = "--> номер" + i + ":\r\n" +
                "Объект: " + sender.ToString() + "\r\n" ;
            lbInfo.Items.Add(message);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lbInfo.Items.Clear();
        }
    }
}

