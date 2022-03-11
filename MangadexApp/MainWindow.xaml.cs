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
		onlyThisDropdown(MangaDropdownMenu);
	}

	#region MangaDropdown

	private void MangaTitles_RightClickDown(object sender, MouseButtonEventArgs e) { }

	private void MangaUpdates_RightClickDown(object sender, MouseButtonEventArgs e) { }

	private void MangaSearch_RightClickDown(object sender, MouseButtonEventArgs e) { }

	private void MangaFeatured_RightClickDown(object sender, MouseButtonEventArgs e) { }

	private void MangaRandom_RightClickDown(object sender, MouseButtonEventArgs e) { }

	private void MangaAdd_RightClickDown(object sender, MouseButtonEventArgs e) { }

	#endregion

	private void Follows_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }

	#region CommunityDropdown

	private void CommunityDropdown_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
		onlyThisDropdown(CommunityDropdownMenu);
	}

	private void onlyThisDropdown(Border DropdownMenu) {
		if (DropdownMenu.Visibility == Visibility.Visible)
			DropdownMenu.Visibility = Visibility.Collapsed;
		else{
			CommunityDropdownMenu.Visibility = Visibility.Collapsed;
			MangaDropdownMenu.Visibility     = Visibility.Collapsed;
			InfoDropdownMenu.Visibility      = Visibility.Collapsed;

			DropdownMenu.Visibility = Visibility.Visible;
		}
	}

	private void CommunityIRC_RightClickDown(object sender, MouseButtonEventArgs e) {
		Process.Start("explorer", "https://www.reddit.com/r/mangadex/");
	}

	private void CommunityTumblr_RightClickDown(object sender, MouseButtonEventArgs e) {
		Process.Start("explorer", "https://www.reddit.com/r/mangadex/");
	}

	private void CommunityReddit_RightClickDown(object sender, MouseButtonEventArgs e) {
		Process.Start("explorer", "https://www.reddit.com/r/mangadex/");
	}

	private void CommunityTwitter_RightClickDown(object sender, MouseButtonEventArgs e) {
		Process.Start("explorer", "https://www.reddit.com/r/mangadex/");
	}

	private void CommunityDiscord_RightClickDown(object sender, MouseButtonEventArgs e) {
		Process.Start("explorer", "https://www.reddit.com/r/mangadex/");
	}

	private void CommunityUsers_RightClickDown(object sender, MouseButtonEventArgs e) { }

	private void CommunityGroups_RightClickDown(object sender, MouseButtonEventArgs e) { }

	private void CommunityForums_RightClickDown(object sender, MouseButtonEventArgs e) { }

	#endregion

	private void InfoDropdown_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
		onlyThisDropdown(InfoDropdownMenu);
	}
}