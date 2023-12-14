namespace XPanel.XPanelControllers
{
    partial class XPanelLOD
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
            One = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // One
            // 
            One.BorderColor = Color.DarkGray;
            One.BorderRadius = 10;
            One.BorderThickness = 2;
            One.CustomizableEdges = customizableEdges1;
            One.DisabledState.BorderColor = Color.DarkGray;
            One.DisabledState.CustomBorderColor = Color.DarkGray;
            One.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            One.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            One.FillColor = Color.FromArgb(54, 69, 79);
            One.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            One.ForeColor = Color.White;
            One.Location = new Point(208, 138);
            One.Name = "One";
            One.ShadowDecoration.CustomizableEdges = customizableEdges2;
            One.Size = new Size(220, 70);
            One.TabIndex = 20;
            One.Text = "1mm";
            One.Click += One_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderColor = Color.DarkGray;
            guna2Button1.BorderRadius = 10;
            guna2Button1.BorderThickness = 2;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(54, 69, 79);
            guna2Button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(208, 306);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(220, 70);
            guna2Button1.TabIndex = 21;
            guna2Button1.Text = "2mm";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // XPanelLOD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(guna2Button1);
            Controls.Add(One);
            Name = "XPanelLOD";
            Size = new Size(676, 567);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button One;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
