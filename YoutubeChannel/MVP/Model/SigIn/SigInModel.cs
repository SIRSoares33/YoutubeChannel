using YoutubeChannel.Entities;
using YoutubeChannel.Services;

namespace YoutubeChannel.MVP.Model.SigIn
{
    public class SigInModel : ISigInModel
    {
        public void SigIn(DbManager database, User userSigIn)
        => database.ExecuteNonQuery($"INSERT INTO Login VALUES ('{userSigIn.Email}', '{userSigIn.Password}', '{userSigIn.UserName}', '0', '{DateTime.Now.ToString("dd/MMM/yyyy")}')");
    }
}