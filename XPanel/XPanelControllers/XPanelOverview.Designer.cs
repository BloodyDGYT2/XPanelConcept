namespace XPanel.XPanelControllers
{
    partial class XPanelOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XPanelOverview));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ProgressBarOne = new Guna.UI2.WinForms.Guna2ProgressBar();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(297, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 288);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(123, 145);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 2;
            label1.Text = "DPI: 800";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(65, 204);
            label2.Name = "label2";
            label2.Size = new Size(196, 25);
            label2.TabIndex = 3;
            label2.Text = "Polling Rate: 1000Hz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(77, 256);
            label3.Name = "label3";
            label3.Size = new Size(156, 25);
            label3.TabIndex = 4;
            label3.Text = "MotionSync: On";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(105, 296);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 5;
            label4.Text = "LOD: 1mm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(70, 341);
            label5.Name = "label5";
            label5.Size = new Size(191, 25);
            label5.TabIndex = 6;
            label5.Text = "Dongle LED: Battery";
            // 
            // ProgressBarOne
            // 
            ProgressBarOne.BorderColor = Color.FromArgb(54, 69, 79);
            ProgressBarOne.BorderRadius = 10;
            ProgressBarOne.BorderThickness = 2;
            ProgressBarOne.CustomizableEdges = customizableEdges1;
            ProgressBarOne.FillColor = Color.Black;
            ProgressBarOne.Location = new Point(608, 60);
            ProgressBarOne.Name = "ProgressBarOne";
            ProgressBarOne.ProgressColor = Color.FromArgb(54, 69, 79);
            ProgressBarOne.ProgressColor2 = Color.FromArgb(54, 69, 79);
            ProgressBarOne.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ProgressBarOne.Size = new Size(33, 464);
            ProgressBarOne.TabIndex = 7;
            ProgressBarOne.Text = "guna2ProgressBar1";
            ProgressBarOne.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(608, 527);
            label6.Name = "label6";
            label6.Size = new Size(34, 25);
            label6.TabIndex = 8;
            label6.Text = "⚡";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGray;
            label7.Location = new Point(607, 32);
            label7.Name = "label7";
            label7.Size = new Size(39, 25);
            label7.TabIndex = 9;
            label7.Text = "0%";
            // 
            // XPanelOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(ProgressBarOne);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "XPanelOverview";
            Size = new Size(676, 567);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Guna.UI2.WinForms.Guna2ProgressBar ProgressBarOne;
        private Label label6;
        private Label label7;
    }
}
