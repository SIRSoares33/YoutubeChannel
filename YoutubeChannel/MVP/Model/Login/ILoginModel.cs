using YoutubeChannel.Services;

namespace YoutubeChannel.MVP.Model.Login
{
    public interface ILoginModel
    {
        /// <summary>
        /// Método que faz o login.
        /// </summary>
        /// <param name="database"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(DbManager database, string email, string password);
    }
}