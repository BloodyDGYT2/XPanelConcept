namespace XPanel.XPanelControllers
{
    partial class XPanelMotionSync
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
            TurnOnMotionSync = new Guna.UI2.WinForms.Guna2Button();
            TurnOffMotionSync = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // TurnOnMotionSync
            // 
            TurnOnMotionSync.BorderColor = Color.DarkGray;
            TurnOnMotionSync.BorderRadius = 10;
            TurnOnMotionSync.BorderThickness = 2;
            TurnOnMotionSync.CustomizableEdges = customizableEdges1;
            TurnOnMotionSync.DisabledState.BorderColor = Color.DarkGray;
            TurnOnMotionSync.DisabledState.CustomBorderColor = Color.DarkGray;
            TurnOnMotionSync.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            TurnOnMotionSync.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            TurnOnMotionSync.FillColor = Color.FromArgb(54, 69, 79);
            TurnOnMotionSync.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TurnOnMotionSync.ForeColor = Color.White;
            TurnOnMotionSync.Location = new Point(216, 155);
            TurnOnMotionSync.Name = "TurnOnMotionSync";
            TurnOnMotionSync.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TurnOnMotionSync.Size = new Size(220, 70);
            TurnOnMotionSync.TabIndex = 17;
            TurnOnMotionSync.Text = "Turn On";
            TurnOnMotionSync.Click += TurnOnMotionSync_Click;
            // 
            // TurnOffMotionSync
            // 
            TurnOffMotionSync.BorderColor = Color.DarkGray;
            TurnOffMotionSync.BorderRadius = 10;
            TurnOffMotionSync.BorderThickness = 2;
            TurnOffMotionSync.CustomizableEdges = customizableEdges3;
            TurnOffMotionSync.DisabledState.BorderColor = Color.DarkGray;
            TurnOffMotionSync.DisabledState.CustomBorderColor = Color.DarkGray;
            TurnOffMotionSync.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            TurnOffMotionSync.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            TurnOffMotionSync.FillColor = Color.FromArgb(54, 69, 79);
            TurnOffMotionSync.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TurnOffMotionSync.ForeColor = Color.White;
            TurnOffMotionSync.Location = new Point(216, 314);
            TurnOffMotionSync.Name = "TurnOffMotionSync";
            TurnOffMotionSync.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TurnOffMotionSync.Size = new Size(220, 70);
            TurnOffMotionSync.TabIndex = 18;
            TurnOffMotionSync.Text = "Turn Off";
            TurnOffMotionSync.Click += TurnOffMotionSync_Click;
            // 
            // XPanelMotionSync
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(TurnOffMotionSync);
            Controls.Add(TurnOnMotionSync);
            Name = "XPanelMotionSync";
            Size = new Size(676, 567);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button TurnOnMotionSync;
        private Guna.UI2.WinForms.Guna2Button TurnOffMotionSync;
    }
}
