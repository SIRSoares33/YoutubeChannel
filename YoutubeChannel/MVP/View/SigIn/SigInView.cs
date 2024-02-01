using YoutubeChannel.MVP.Model.SigIn;
using YoutubeChannel.MVP.Presenter.SigIn;
using YoutubeChannel.Services;

namespace YoutubeChannel.MVP.View.SigIn;

public partial class SigInView : Form, ISigInView
{
    #region Entities
    private readonly SigInPresenter _presenter;
    #endregion

    #region Constructor
    public SigInView()
    {
        InitializeComponent();
        _presenter = new SigInPresenter(this, new DbManager(@"\database\database.db"), new SigInModel());
    }
    #endregion

    #region ISigInView Attributes
    public string Email    { get => txtEmail.Text;                       }
    public string Password { get => txtPassword.Text;                    }
    public string UserName { get => txtUserName.Text;                    }
    public Label Result    { get => lblResult; set => lblResult = value; }
    #endregion

    #region ISigInView Events
    public event Action? SigIn;
    #endregion

    #region ISigInView Methods
    public void ShowMessage(string message, string caption, MessageBoxButtons button, MessageBoxIcon icon)
    => MessageBox.Show(message, caption, button, icon);
    #endregion

    #region Methods
    private void onSigInClick(object sender, EventArgs e)       => SigIn?.Invoke();
    private void onSeePasswordClick(object sender, EventArgs e) => txtPassword.UseSystemPasswordChar = chbSeePassword.Checked;
    #endregion
}