namespace YoutubeChannel.MVP.View.Main;

partial class MainView
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
        pnlViewForm = new Panel();
        txtSearchChannel = new TextBox();
        imgSearchChannel = new PictureBox();
        lblMeuCanal = new Label();
        lblSubscrivers = new Label();
        lblNameMyChannel = new Label();
        lblDate = new Label();
        imgMyUser = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)imgSearchChannel).BeginInit();
        ((System.ComponentModel.ISupportInitialize)imgMyUser).BeginInit();
        SuspendLayout();
        // 
        // pnlViewForm
        // 
        pnlViewForm.BorderStyle = BorderStyle.FixedSingle;
        pnlViewForm.Location = new Point(428, 0);
        pnlViewForm.Name = "pnlViewForm";
        pnlViewForm.Size = new Size(376, 368);
        pnlViewForm.TabIndex = 0;
        // 
        // txtSearchChannel
        // 
        txtSearchChannel.Location = new Point(12, 32);
        txtSearchChannel.Name = "txtSearchChannel";
        txtSearchChannel.Size = new Size(196, 23);
        txtSearchChannel.TabIndex = 1;
        // 
        // imgSearchChannel
        // 
        imgSearchChannel.BorderStyle = BorderStyle.FixedSingle;
        imgSearchChannel.Image = (Image)resources.GetObject("imgSearchChannel.Image");
        imgSearchChannel.Location = new Point(214, 28);
        imgSearchChannel.Name = "imgSearchChannel";
        imgSearchChannel.Size = new Size(28, 31);
        imgSearchChannel.SizeMode = PictureBoxSizeMode.Zoom;
        imgSearchChannel.TabIndex = 2;
        imgSearchChannel.TabStop = false;
        imgSearchChannel.Click += SendingSearchButton;
        // 
        // lblMeuCanal
        // 
        lblMeuCanal.AutoSize = true;
        lblMeuCanal.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblMeuCanal.Location = new Point(12, 115);
        lblMeuCanal.Name = "lblMeuCanal";
        lblMeuCanal.Size = new Size(255, 65);
        lblMeuCanal.TabIndex = 3;
        lblMeuCanal.Text = "Meu canal:";
        // 
        // lblSubscrivers
        // 
        lblSubscrivers.AutoSize = true;
        lblSubscrivers.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblSubscrivers.Location = new Point(12, 206);
        lblSubscrivers.Name = "lblSubscrivers";
        lblSubscrivers.Size = new Size(136, 40);
        lblSubscrivers.TabIndex = 4;
        lblSubscrivers.Text = "Inscritos: ";
        // 
        // lblNameMyChannel
        // 
        lblNameMyChannel.AutoSize = true;
        lblNameMyChannel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblNameMyChannel.Location = new Point(12, 262);
        lblNameMyChannel.Name = "lblNameMyChannel";
        lblNameMyChannel.Size = new Size(110, 40);
        lblNameMyChannel.TabIndex = 5;
        lblNameMyChannel.Text = "Nome: ";
        // 
        // lblDate
        // 
        lblDate.AutoSize = true;
        lblDate.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblDate.Location = new Point(12, 315);
        lblDate.Name = "lblDate";
        lblDate.Size = new Size(163, 40);
        lblDate.TabIndex = 6;
        lblDate.Text = "Entrou em: ";
        // 
        // imgMyUser
        // 
        imgMyUser.Image = (Image)resources.GetObject("imgMyUser.Image");
        imgMyUser.Location = new Point(260, 107);
        imgMyUser.Name = "imgMyUser";
        imgMyUser.Size = new Size(98, 92);
        imgMyUser.SizeMode = PictureBoxSizeMode.Zoom;
        imgMyUser.TabIndex = 7;
        imgMyUser.TabStop = false;
        // 
        // MainView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 368);
        Controls.Add(imgMyUser);
        Controls.Add(lblDate);
        Controls.Add(lblNameMyChannel);
        Controls.Add(lblSubscrivers);
        Controls.Add(lblMeuCanal);
        Controls.Add(imgSearchChannel);
        Controls.Add(txtSearchChannel);
        Controls.Add(pnlViewForm);
        Name = "MainView";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)imgSearchChannel).EndInit();
        ((System.ComponentModel.ISupportInitialize)imgMyUser).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel pnlViewForm;
    private TextBox txtSearchChannel;
    private PictureBox imgSearchChannel;
    private Label lblMeuCanal;
    private Label lblSubscrivers;
    private Label lblNameMyChannel;
    private Label lblDate;
    private PictureBox imgMyUser;
}
