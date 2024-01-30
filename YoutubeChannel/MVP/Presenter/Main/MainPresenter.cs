using YoutubeChannel.MVP.Model.Main;
using YoutubeChannel.MVP.View.Main;
using YoutubeChannel.Services;

namespace YoutubeChannel.MVP.Presenter.Main;

public class MainPresenter
{
    #region Entities
    private readonly IMainView _view;
    private readonly IMainModel _model;
    private readonly DbManager _database;
    #endregion

    #region Constructor
    public MainPresenter(IMainView view, DbManager database,IMainModel model)
    {
        _view = view;
        _view.SearchButtonWasClicked += checkingSearch;

        _database = database;
        _database.CreateTablesIFNotExist();

        _model = model;

        getMyChannel();
    }
    #endregion

    #region Methods
    private void checkingSearch() => throw new NotImplementedException();
    #endregion

    #region Initial Setup Methods
    private void getMyChannel()
    {
        string[] MyChannelInfo = _model.GetingMyChannel(_database);

        _view.MyChannelName += MyChannelInfo[0];
        _view.MeusInscritos += MyChannelInfo[1];
        _view.MyDate        += MyChannelInfo[2];
    }
    #endregion
}
