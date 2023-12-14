namespace XPanel.XPanelControllers
{
    partial class XPanelDongleLED
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            BatteryIndecator = new Guna.UI2.WinForms.Guna2Button();
            DongleStrengthButton = new Guna.UI2.WinForms.Guna2Button();
            TurnOffLEDButton = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // BatteryIndecator
            // 
            BatteryIndecator.BorderColor = Color.DarkGray;
            BatteryIndecator.BorderRadius = 10;
            BatteryIndecator.BorderThickness = 2;
            BatteryIndecator.CustomizableEdges = customizableEdges1;
            BatteryIndecator.DisabledState.BorderColor = Color.DarkGray;
            BatteryIndecator.DisabledState.CustomBorderColor = Color.DarkGray;
            BatteryIndecator.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BatteryIndecator.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BatteryIndecator.FillColor = Color.FromArgb(54, 69, 79);
            BatteryIndecator.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BatteryIndecator.ForeColor = Color.White;
            BatteryIndecator.Location = new Point(213, 124);
            BatteryIndecator.Name = "BatteryIndecator";
            BatteryIndecator.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BatteryIndecator.Size = new Size(220, 70);
            BatteryIndecator.TabIndex = 18;
            BatteryIndecator.Text = "Battery LOD";
            BatteryIndecator.Click += BatteryIndecator_Click;
            // 
            // DongleStrengthButton
            // 
            DongleStrengthButton.BorderColor = Color.DarkGray;
            DongleStrengthButton.BorderRadius = 10;
            DongleStrengthButton.BorderThickness = 2;
            DongleStrengthButton.CustomizableEdges = customizableEdges3;
            DongleStrengthButton.DisabledState.BorderColor = Color.DarkGray;
            DongleStrengthButton.DisabledState.CustomBorderColor = Color.DarkGray;
            DongleStrengthButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            DongleStrengthButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            DongleStrengthButton.FillColor = Color.FromArgb(54, 69, 79);
            DongleStrengthButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DongleStrengthButton.ForeColor = Color.White;
            DongleStrengthButton.Location = new Point(213, 256);
            DongleStrengthButton.Name = "DongleStrengthButton";
            DongleStrengthButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            DongleStrengthButton.Size = new Size(220, 70);
            DongleStrengthButton.TabIndex = 19;
            DongleStrengthButton.Text = "Connection";
            DongleStrengthButton.Click += DongleStrengthButton_Click;
            // 
            // TurnOffLEDButton
            // 
            TurnOffLEDButton.BorderColor = Color.DarkGray;
            TurnOffLEDButton.BorderRadius = 10;
            TurnOffLEDButton.BorderThickness = 2;
            TurnOffLEDButton.CustomizableEdges = customizableEdges5;
            TurnOffLEDButton.DisabledState.BorderColor = Color.DarkGray;
            TurnOffLEDButton.DisabledState.CustomBorderColor = Color.DarkGray;
            TurnOffLEDButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            TurnOffLEDButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            TurnOffLEDButton.FillColor = Color.FromArgb(54, 69, 79);
            TurnOffLEDButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TurnOffLEDButton.ForeColor = Color.White;
            TurnOffLEDButton.Location = new Point(213, 387);
            TurnOffLEDButton.Name = "TurnOffLEDButton";
            TurnOffLEDButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TurnOffLEDButton.Size = new Size(220, 70);
            TurnOffLEDButton.TabIndex = 20;
            TurnOffLEDButton.Text = "Turn off";
            TurnOffLEDButton.Click += TurnOffLEDButton_Click;
            // 
            // XPanelDongleLED
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(TurnOffLEDButton);
            Controls.Add(DongleStrengthButton);
            Controls.Add(BatteryIndecator);
            Name = "XPanelDongleLED";
            Size = new Size(676, 567);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BatteryIndecator;
        private Guna.UI2.WinForms.Guna2Button DongleStrengthButton;
        private Guna.UI2.WinForms.Guna2Button TurnOffLEDButton;
    }
}
