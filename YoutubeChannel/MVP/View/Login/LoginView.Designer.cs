namespace YoutubeChannel.MVP.View.Login
{
    partial class LoginView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblSenha = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(21, 38);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 25);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(89, 41);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Seu email aqui.";
            txtEmail.Size = new Size(143, 23);
            txtEmail.TabIndex = 1;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(21, 67);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(71, 25);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(89, 71);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Sua senha aqui.";
            txtPassword.Size = new Size(143, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(89, 114);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(82, 39);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += SendingLoginButton;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 178);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblSenha);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Name = "LoginView";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblSenha;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}