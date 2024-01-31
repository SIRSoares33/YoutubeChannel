using YoutubeChannel.Services;

namespace YoutubeChannel.MVP.Model.Login
{
    public class LoginModel : ILoginModel
    {
        public bool Login(DbManager database, string email, string password)
        {
            string[] currentUserInfos = database.ExecuteQuery($"SELECT * FROM Login WHERE email='{email}' AND password='{password}'", 5);

            if (currentUserInfos[2] is null || currentUserInfos[3] is null || currentUserInfos[4] is null)
                return false;

            SetCurrentUser(database, currentUserInfos);
            return true;   
        }

        private void SetCurrentUser(DbManager database, string[] currentUserInfos)
        => database.ExecuteNonQuery($"INSERT INTO CurrentUser VALUES ('{currentUserInfos[2]}', '{currentUserInfos[3]}', '{currentUserInfos[4]}')");
    }
}