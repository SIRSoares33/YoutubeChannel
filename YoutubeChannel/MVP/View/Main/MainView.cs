using YoutubeChannel.Services;
using YoutubeChannel.MVP.Presenter.Main;
using YoutubeChannel.MVP.Model.Main;

namespace YoutubeChannel.MVP.View.Main;

public partial class MainView : Form, IMainView
{
    #region Entities
    private readonly MainPresenter _presenter;
    #endregion

    #region Constructor
    public MainView()
    {
        InitializeComponent();
        _presenter = new MainPresenter(this, new DbManager(@"\database\database.db"), new MainModel());
    }
    #endregion

    #region IMainView Attributes
    public string SearchChannel { get => txtSearchChannel.Text;                                       }
    public string MeusInscritos { get => lblSubscrivers.Text; set => lblSubscrivers.Text = value;     }
    public string MyChannelName { get => lblNameMyChannel.Text; set => lblNameMyChannel.Text = value; }
    public string MyDate        { get => lblDate.Text; set => lblDate.Text = value;                   }
    #endregion

    #region IMainView Events
    public event Action? SearchButtonWasClicked;
    #endregion

    #region IMainView Methods
    public void ShowMessage(string message, string caption, MessageBoxButtons button, MessageBoxIcon icon)
    => MessageBox.Show(message, caption, button, icon);
    #endregion

    #region Methods
    private void SendingSearchButton(object sender, EventArgs e) => SearchButtonWasClicked?.Invoke();
    #endregion
}