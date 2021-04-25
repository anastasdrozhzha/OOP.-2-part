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

namespace dependency_property
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
	private void NewPage_click(object sender, RoutedEventArgs e)
	{
			Marsh marsh = new Marsh();
			marsh.Show();
	}

		private void dependency_click(object sender, RoutedEventArgs e)
		{
			coloPick marshS = new coloPick();
			marshS.Show();
		}

		private void tun_click(object sender, RoutedEventArgs e)
		{
			tun T = new tun();
			T.Show();
		}
		private void ExitCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
			{
				e.CanExecute = true;
			}

			private void ExitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
			{
				Application.Current.Shutdown();
			}
		}

		public static class CustomCommands
		{
			public static readonly RoutedUICommand Exit = new RoutedUICommand
				(
					"Exit",
					"Exit",
					typeof(CustomCommands),
					new InputGestureCollection()
					{
					new KeyGesture(Key.A, ModifierKeys.Alt)
					}
				);

			//Define more commands here, just like the one above
		}
	
}

