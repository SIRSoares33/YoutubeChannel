namespace YoutubeChannel.MVP.View.Login
{
    public interface ILoginView
    {
        /// <summary>
        /// Recebe o email do usuário.
        /// </summary>
        string Email { get; }
        /// <summary>
        /// Recebe a senha do usuário.
        /// </summary>
        string Password { get; }
        /// <summary>
        /// Evento do botão de login.
        /// </summary>
        event Action? ButtonLoginWasClicked;
        /// <summary>
        /// Evento do botão de cadastro.
        /// </summary>
        event Action? ButtonCadastroWasClicked;
        /// <summary>
        /// Exibe uma mensagem para a view.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="caption"></param>
        /// <param name="button"></param>
        /// <param name="icon"></param>
        void ShowMessage(string message, string caption, MessageBoxButtons button, MessageBoxIcon icon);
    }
}