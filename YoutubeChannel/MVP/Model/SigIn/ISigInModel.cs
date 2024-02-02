using YoutubeChannel.Entities;
using YoutubeChannel.Services;

namespace YoutubeChannel.MVP.Model.SigIn
{
    public interface ISigInModel
    {
        public void SigIn(DbManager database, User userSigIn);
    }
}