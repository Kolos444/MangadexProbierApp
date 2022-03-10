using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MangadexApp;

public partial class MainWindow : Window{
	public MainWindow() {
		InitializeComponent();
		
	}
	
	private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e) {
		if (e.ChangedButton == MouseButton.Left)
			DragMove();
	}

	private void MangaDropdow_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
		MangaDropdownMenu.Visibility = MangaDropdownMenu.Visibility == Visibility.Collapsed ? Visibility.Visible : Visibility.Collapsed;
	}

	private void UIElement_OnMouseEnter(object sender, MouseEventArgs e) {
		MainBorder.Background = new SolidColorBrush(Colors.Aqua);
	}

	private void UIElement_OnMouseLeave(object sender, MouseEventArgs e) {
		MainBorder.Background = new SolidColorBrush(Colors.Red);
	}
}