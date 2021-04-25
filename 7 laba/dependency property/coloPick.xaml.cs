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
    /// Логика взаимодействия для coloPick.xaml
    /// </summary>
    public partial class coloPick : Window
    {
        public coloPick()
        {
            InitializeComponent();
        }
        private void ColorPickerPanel_OnColorChanged_(object sender, RoutedEventArgs e)
        {
            ColorPickerPanel.Background = new SolidColorBrush(((ChangeColorEventArgs)e).Color);
        }
    }
}
