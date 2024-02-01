namespace YoutubeChannel.MVP.View.SigIn
{
    partial class SigInView
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
            lblPassword = new Label();
            txtPassword = new TextBox();
            chbSeePassword = new CheckBox();
            lblUserName = new Label();
            txtUserName = new TextBox();
            btnSigIn = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(26, 43);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 25);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(116, 48);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(133, 23);
            txtEmail.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(26, 80);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(71, 25);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Senha:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(116, 82);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(133, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chbSeePassword
            // 
            chbSeePassword.AutoSize = true;
            chbSeePassword.Location = new Point(255, 89);
            chbSeePassword.Name = "chbSeePassword";
            chbSeePassword.Size = new Size(15, 14);
            chbSeePassword.TabIndex = 4;
            chbSeePassword.UseVisualStyleBackColor = true;
            chbSeePassword.Click += onSeePasswordClick;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(26, 113);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(86, 25);
            lblUserName.TabIndex = 5;
            lblUserName.Text = "Usuário:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(116, 114);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(133, 23);
            txtUserName.TabIndex = 6;
            // 
            // btnSigIn
            // 
            btnSigIn.Location = new Point(26, 152);
            btnSigIn.Name = "btnSigIn";
            btnSigIn.Size = new Size(99, 47);
            btnSigIn.TabIndex = 7;
            btnSigIn.Text = "Cadastrar";
            btnSigIn.UseVisualStyleBackColor = true;
            btnSigIn.Click += onSigInClick;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.SpringGreen;
            lblResult.Location = new Point(131, 179);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(148, 20);
            lblResult.TabIndex = 8;
            lblResult.Text = "Usuário cadastrado.";
            lblResult.Visible = false;
            // 
            // SigInView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 211);
            Controls.Add(lblResult);
            Controls.Add(btnSigIn);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(chbSeePassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Name = "SigInView";
            Text = "SigInView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private CheckBox chbSeePassword;
        private Label lblUserName;
        private TextBox txtUserName;
        private Button btnSigIn;
        private Label lblResult;
    }
}