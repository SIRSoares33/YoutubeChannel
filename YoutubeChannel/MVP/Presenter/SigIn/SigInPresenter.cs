using System.Timers;
using YoutubeChannel.Entities;
using YoutubeChannel.MVP.Model.SigIn;
using YoutubeChannel.MVP.View.SigIn;
using YoutubeChannel.Services;

namespace YoutubeChannel.MVP.Presenter.SigIn
{
    public class SigInPresenter
    {
        #region Entities
        private readonly ISigInView _view;
        private readonly ISigInModel _model;
        private readonly DbManager _database;
        #endregion

        #region Constructor
        public SigInPresenter(ISigInView view, DbManager database, ISigInModel model)
        {
            _view = view;
            _view.SigIn += checkingSigIn;

            _database = database;

            _model = model;
        }
        #endregion

        #region Methods
        private void checkingSigIn()
        {
            try
            {
                if (string.IsNullOrEmpty(_view.Email))
                    throw new Exception("O campo Email está vazio.");
                
                if (string.IsNullOrEmpty(_view.Password))
                    throw new Exception("O Campo Senha está vazio.");
                
                if (string.IsNullOrEmpty(_view.UserName))
                    throw new Exception("O campo Usuário está vazio.");

                User user = new User()
                {
                    Email    = _view.Email,
                    Password = _view.Password,
                    UserName = _view.UserName
                };

                _model.SigIn(_database, user);

                _view.Result.Visible = true;
                
                System.Timers.Timer timer = new System.Timers.Timer(6000);
                timer.Enabled = true;
                timer.Elapsed += onTimerElapsed;
            }
            catch(Exception ex)
            {
                if (ex.Message.Contains("UNIQUE"))
                    _view.ShowMessage("Você já cadastrou esse usuário", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                else
                    _view.ShowMessage(ex.Message, "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void onTimerElapsed(object? sender, ElapsedEventArgs e) => _view.Result.Visible = false;
        #endregion
    }
}