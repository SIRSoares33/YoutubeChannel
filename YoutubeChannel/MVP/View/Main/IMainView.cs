namespace YoutubeChannel.MVP.View.Main
{
    public interface IMainView
    {
        string SearchChannel { get;       }
        string MeusInscritos { get; set;  }
        string MyChannelName { get; set;  }
        string MyDate        {  get; set; }

        event Action? SearchButtonWasClicked;

        void ShowMessage(string message, string caption, MessageBoxButtons button, MessageBoxIcon icon);
    }
}