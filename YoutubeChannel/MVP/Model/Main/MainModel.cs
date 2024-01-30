using YoutubeChannel.Services;

namespace YoutubeChannel.MVP.Model.Main
{
    public class MainModel : IMainModel
    {
        public string[] GetingMyChannel(DbManager database)
        => database.ExecuteQuery($"SELECT * FROM CurrentUser", 3);
    }
}
