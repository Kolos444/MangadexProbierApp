using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MangadexAPI;

namespace MangadexApp;

/// <summary>Interaction logic for LoginWindow.xaml</summary>
public partial class LoginWindow : Window{
	public LoginWindow() {
		InitializeComponent();
		}

	private void LoginWindow_OnMouseDown(object sender, MouseButtonEventArgs e) {
		if (e.ChangedButton == MouseButton.Left)
			DragMove();
	}


	private void LoginButton_OnClick(object sender, RoutedEventArgs e) {
		account = new Account(TextBox.Text, PasswordBox.Password);
		Task<APIRequest?> answer = MangadexAPI.MangadexAPI.login(account);

		if (answer.Result.result == "ok"){
			account.token = answer.Result.token;
			loginSuccess();
		}
		else
			StatusBox.Text = answer.Result.result;
	}

	private void loginSuccess() {
		
	}

	private MangadexAPI.Account account;
}