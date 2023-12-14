namespace XPanel
{
    partial class XPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XPanel));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            ConnectButton = new Guna.UI2.WinForms.Guna2Button();
            FirmwareButton = new Guna.UI2.WinForms.Guna2Button();
            ExitButton = new Guna.UI2.WinForms.Guna2Button();
            MinimizeButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(241, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 157);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // ConnectButton
            // 
            ConnectButton.BorderColor = Color.DarkGray;
            ConnectButton.BorderRadius = 10;
            ConnectButton.BorderThickness = 2;
            ConnectButton.CustomizableEdges = customizableEdges1;
            ConnectButton.DisabledState.BorderColor = Color.DarkGray;
            ConnectButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ConnectButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ConnectButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ConnectButton.FillColor = Color.FromArgb(54, 69, 79);
            ConnectButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ConnectButton.ForeColor = Color.White;
            ConnectButton.Location = new Point(290, 355);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ConnectButton.Size = new Size(245, 58);
            ConnectButton.TabIndex = 1;
            ConnectButton.Text = "Connect";
            ConnectButton.Click += ConnectButton_Click;
            // 
            // FirmwareButton
            // 
            FirmwareButton.BorderColor = Color.DarkGray;
            FirmwareButton.BorderRadius = 10;
            FirmwareButton.BorderThickness = 2;
            FirmwareButton.CustomizableEdges = customizableEdges3;
            FirmwareButton.DisabledState.BorderColor = Color.DarkGray;
            FirmwareButton.DisabledState.CustomBorderColor = Color.DarkGray;
            FirmwareButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            FirmwareButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            FirmwareButton.FillColor = Color.FromArgb(54, 69, 79);
            FirmwareButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            FirmwareButton.ForeColor = Color.White;
            FirmwareButton.Location = new Point(575, 484);
            FirmwareButton.Name = "FirmwareButton";
            FirmwareButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            FirmwareButton.Size = new Size(245, 58);
            FirmwareButton.TabIndex = 2;
            FirmwareButton.Text = "Firmware";
            FirmwareButton.Click += FirmwareButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BorderColor = Color.DarkGray;
            ExitButton.BorderRadius = 10;
            ExitButton.BorderThickness = 2;
            ExitButton.CustomizableEdges = customizableEdges5;
            ExitButton.DisabledState.BorderColor = Color.DarkGray;
            ExitButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ExitButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ExitButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ExitButton.FillColor = Color.FromArgb(54, 69, 79);
            ExitButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(758, 12);
            ExitButton.Name = "ExitButton";
            ExitButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ExitButton.Size = new Size(62, 51);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // MinimizeButton
            // 
            MinimizeButton.BorderColor = Color.DarkGray;
            MinimizeButton.BorderRadius = 10;
            MinimizeButton.BorderThickness = 2;
            MinimizeButton.CustomizableEdges = customizableEdges7;
            MinimizeButton.DisabledState.BorderColor = Color.DarkGray;
            MinimizeButton.DisabledState.CustomBorderColor = Color.DarkGray;
            MinimizeButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            MinimizeButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            MinimizeButton.FillColor = Color.FromArgb(54, 69, 79);
            MinimizeButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            MinimizeButton.ForeColor = Color.White;
            MinimizeButton.Location = new Point(690, 12);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            MinimizeButton.Size = new Size(62, 51);
            MinimizeButton.TabIndex = 4;
            MinimizeButton.Text = "-";
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // XPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(832, 551);
            Controls.Add(MinimizeButton);
            Controls.Add(ExitButton);
            Controls.Add(FirmwareButton);
            Controls.Add(ConnectButton);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "XPanel";
            Text = "Form1";
            Load += XPanel_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button ConnectButton;
        private Guna.UI2.WinForms.Guna2Button FirmwareButton;
        private Guna.UI2.WinForms.Guna2Button ExitButton;
        private Guna.UI2.WinForms.Guna2Button MinimizeButton;
    }
}