using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Resources;
using System.Windows.Input;

namespace Wpf_4_5_Word
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			FontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
			this.FontSizeTextBox.Text = this.Font_Size.Value.ToString();
			this.txtBox.AllowDrop = true;
			this.txtBox.AddHandler(RichTextBox.DragOverEvent, new DragEventHandler(this.DragItem), true);
			this.txtBox.AddHandler(RichTextBox.DropEvent, new DragEventHandler(this.DropItem), true);
			StreamResourceInfo sri = Application.GetResourceStream(new Uri("Resources/Arrow.cur", UriKind.Relative));
			Cursor customCursor = new Cursor(sri.Stream);
			this.Cursor = customCursor;
		}


		private void Color_Click(object sender, RoutedEventArgs e)
		{
			System.Windows.Forms.ColorDialog cd = new System.Windows.Forms.ColorDialog();
			TextSelection textSelection = txtBox.Selection;
			var result = cd.ShowDialog();
			if (result == System.Windows.Forms.DialogResult.OK)
			{
				txtBox.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(Color.FromArgb(cd.Color.A, cd.Color.R, cd.Color.G, cd.Color.B)));
			}
		}
		private void FontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (FontFamily.SelectedItem != null)
				txtBox.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, FontFamily.SelectedItem);
		}

		private void MenuItemOpen_Click(object sender, RoutedEventArgs e)
		{

			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "Text Document (*.txt)|*.txt|All files (*.*)|*.*";
			if (dlg.ShowDialog() == true)
			{
				FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open);
				TextRange range = new TextRange(txtBox.Document.ContentStart, txtBox.Document.ContentEnd);
				range.Load(fileStream, DataFormats.Text);
			}

		}
		private void MenuItemSave_Click(object sender, RoutedEventArgs e)
		{
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.Filter = "New Text Document (*.txt)|.txt|All files (*.*)|*.*";
			if (dlg.ShowDialog() == true)
			{
				FileStream fileStream = new FileStream(dlg.FileName, FileMode.Create);
				TextRange range = new TextRange(txtBox.Document.ContentStart, txtBox.Document.ContentEnd);
				range.Save(fileStream, DataFormats.Text);
			}
		}
		private void ChangeFontSize()
		{
			TextRange tr;
			if (!this.txtBox.Selection.IsEmpty)
			{
				tr = new TextRange(this.txtBox.Selection.Start, this.txtBox.Selection.End);
			}
			else
			{
				tr = new TextRange(this.txtBox.CaretPosition, this.txtBox.Document.ContentEnd);
			}
			tr.ApplyPropertyValue(FontSizeProperty, this.Font_Size.Value);
		}


		private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{

			try
			{
				if (this.Font_Size.IsFocused && this.Font_Size.Value > 0)
				{
					ChangeFontSize();
					this.FontSizeTextBox.Text = this.Font_Size.Value.ToString();
					((Slider)sender).SelectionEnd = e.NewValue;
				}
				else if (this.Font_Size.Value == 0)
				{
					MessageBox.Show("error: font size doesn't be negative");
					this.Font_Size.Value = 12;
				}
			}
			catch
			{
				MessageBox.Show("ERROR");
			}
		}
		private void txtBox_SelectionChanged(object sender, RoutedEventArgs e)
		{
			object temp = txtBox.Selection.GetPropertyValue(Inline.FontWeightProperty);
			Bold.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));
			temp = txtBox.Selection.GetPropertyValue(Inline.FontStyleProperty);
			Italic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));
			temp = txtBox.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
			Underline.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(TextDecorations.Underline));
			temp = txtBox.Selection.GetPropertyValue(Inline.FontFamilyProperty);
			FontFamily.SelectedItem = temp;
			temp = txtBox.Selection.GetPropertyValue(Inline.ForegroundProperty);
		}
		private void MenuItem_Click(object sender, RoutedEventArgs e)
		{
			MenuItem menuItem = (MenuItem)sender;
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
			if (dlg.ShowDialog() == true)
			{
				FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open);
				TextRange range = new TextRange(txtBox.Document.ContentStart, txtBox.Document.ContentEnd);
				range.Load(fileStream, DataFormats.Rtf);
			}
		}
		private void txtBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			this.Log.Content = GetLength(this.txtBox);
		}
		private string GetLength(RichTextBox rtb)
		{
			int count_of_symbols = 0, count_of_lines = 0;
			var textRange = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
			foreach (char c in textRange.Text)
			{
				if (!c.Equals('\n') && (int)c != 13)
				{
					count_of_symbols++;
				}
				else if (c.Equals('\n'))
				{
					count_of_lines++;
				}
			}
			return "count of symbols " + count_of_symbols + ", count of lines " + count_of_lines;
		}

		private void DragItem(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effects = DragDropEffects.All;
			}
			else
			{
				e.Effects = DragDropEffects.None;
			}
			e.Handled = false;
		}
		private void DropItem(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				if (e.Data.GetDataPresent(DataFormats.FileDrop))
				{
					string[] docPath = (string[])e.Data.GetData(DataFormats.FileDrop);
					if (System.IO.File.Exists(docPath[0]))
					{
						try
						{
							TextRange range = new TextRange(this.txtBox.Document.ContentStart, this.txtBox.Document.ContentEnd);
							FileStream fStream = new FileStream(docPath[0], FileMode.OpenOrCreate);
							range.Load(fStream, DataFormats.Text);
							fStream.Close();
							this.Title = "Text Editor (" + docPath[0] + ") ";
						}
						catch (Exception)
						{
							MessageBox.Show("File could not be opened. Make sure the file is a text file.");
						}
					}
				}
			}
		}
		private void SetRussian_Click(object sender, RoutedEventArgs e)
			{
				try
				{
					this.Resources = new ResourceDictionary()
					{
						Source = new Uri("pack://application:,,,/Resources/RuLanguage.xaml")
					};
				}
				catch (Exception ex)
				{
					MessageBox.Show("error: " + ex.Message);
				}
			}
		private void SetEnglish_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				this.Resources = new ResourceDictionary()
				{
					Source = new Uri("pack://application:,,,/Resources/Lang.xaml")
				};
			}
			catch (Exception ex)
			{
				MessageBox.Show("error: " + ex.Message);
			}
		}

		private void SelectTheme(object sender, RoutedEventArgs e)
		{
			Uri uri = null;
			bool isTheme = false;
			ListBoxItem lbi = (ListBoxItem)sender;

			switch (lbi.Name)
			{
				case "Night":
					{
						uri = new Uri("/Resources/ThemeNight.xaml", UriKind.Relative);
						Night.IsSelected = false;
						isTheme = true;
						break;
					}
				case "Day":
					{
						uri = new Uri("/Resources/Main.xaml", UriKind.Relative);
						Day.IsSelected = false;
						isTheme = true;
						break;
					}
				default:
					break;
			}
			if (isTheme)
			{
				ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
				Application.Current.Resources.MergedDictionaries.Add(resourceDict);
			}
		}
		#region RecentFile


		#endregion
	}


}

