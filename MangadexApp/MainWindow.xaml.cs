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
		
	}
}