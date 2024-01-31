using YoutubeChannel.MVP.View.Login;
using YoutubeChannel.MVP.Model.Login;
using YoutubeChannel.Services;

namespace YoutubeChannel.MVP.Presenter.Login;

public class LoginPresenter
{
    #region Entities
    private readonly ILoginView _view;
    private readonly ILoginModel _model;
    private readonly DbManager _database;
    #endregion

    #region Constructor
    public LoginPresenter(ILoginView view, DbManager database, ILoginModel model)
    {
        _view = view;
        _view.ButtonLoginWasClicked += checkingLogin;

        _database = database;
        _database.ExecuteNonQuery("DELETE FROM CurrentUser");

        _model = model;
    }
    #endregion

    #region Methods
    private void checkingLogin()
    {
        try
        {
            if (string.IsNullOrEmpty(_view.Email))
                throw new Exception("O campo EMAIL está vazio.");

            if (string.IsNullOrEmpty(_view.Password))
                throw new Exception("O campo SENHA está vazio.");

            if (!_model.Login(_database, _view.Email, _view.Password))
                throw new Exception("Sua conta não foi encontrada.");
        }
        catch(Exception ex)
        {
            _view.ShowMessage(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    #endregion
}
