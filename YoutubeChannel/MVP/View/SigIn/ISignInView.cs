namespace YoutubeChannel.MVP.View.SigIn
{
    public interface ISigInView
    {
        /// <summary>
        /// Pega o email do usuário.
        /// </summary>
        string Email    { get; }
        /// <summary>
        /// Pega a senha do usuário.
        /// </summary>
        string Password { get; }
        /// <summary>
        /// Pega o nome do usuário.
        /// </summary>
        string UserName { get; }
        /// <summary>
        /// Exibe o resultado do cadastro do usuário.
        /// </summary>
        Label Result    { get; set; }
        /// <summary>
        /// Evento do botão cadastrar.
        /// </summary>
        event Action? SigIn;
        /// <summary>
        /// Envia uma mensagem para a view.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="caption"></param>
        /// <param name="button"></param>
        /// <param name="icon"></param>
        void ShowMessage(string message, string caption, MessageBoxButtons button, MessageBoxIcon icon);
    }
}