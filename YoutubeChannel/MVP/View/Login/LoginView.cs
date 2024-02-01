using YoutubeChannel.MVP.Model.Login;
using YoutubeChannel.MVP.Presenter.Login;
using YoutubeChannel.Services;

namespace YoutubeChannel.MVP.View.Login;

public partial class LoginView : Form, ILoginView
{
    #region Entities
    private readonly LoginPresenter _presenter;
    #endregion

    #region Constructor
    public LoginView()
    {
        InitializeComponent();
        _presenter = new LoginPresenter(this, new DbManager(@"\database\database.db"), new LoginModel());
    }
    #endregion

    #region ILoginView Attributes
    public string Email       { get => txtEmail.Text;    }
    public string Password    { get => txtPassword.Text; }
    public LoginView ThisForm { get => this;             }
    #endregion

    #region ILoginView Events
    public event Action? ButtonLoginWasClicked;
    #endregion

    #region ILoginView Methods
    public void ShowMessage(string message, string caption, MessageBoxButtons button, MessageBoxIcon icon)
    => MessageBox.Show(message, caption, button, icon);
    #endregion

    #region Methods
    private void SendingLoginButton(object sender, EventArgs e)    => ButtonLoginWasClicked?.Invoke();
    #endregion
}
