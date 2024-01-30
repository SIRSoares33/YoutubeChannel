using YoutubeChannel.Services;

namespace YoutubeChannel.MVP.Model.Main
{
    public interface IMainModel
    {
        string[] GetingMyChannel(DbManager database);
    }
}