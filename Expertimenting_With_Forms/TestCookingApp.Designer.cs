namespace Expertimenting_With_Forms
{
    partial class TestCookingApp
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
            pnlTitle = new Panel();
            lblTitle = new Label();
            btnClose = new RoundButton();
            pnlNavigationMenu = new Panel();
            pnlTitle.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(244, 132, 70);
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Controls.Add(btnClose);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(658, 65);
            pnlTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(24, 24, 24);
            lblTitle.Location = new Point(31, 3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(479, 59);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Sanele's Cooking Book";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.OrangeRed;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(606, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 3;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnlNavigationMenu
            // 
            pnlNavigationMenu.Dock = DockStyle.Left;
            pnlNavigationMenu.Location = new Point(0, 65);
            pnlNavigationMenu.Name = "pnlNavigationMenu";
            pnlNavigationMenu.Size = new Size(153, 385);
            pnlNavigationMenu.TabIndex = 2;
            // 
            // TestCookingApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 450);
            Controls.Add(pnlNavigationMenu);
            Controls.Add(pnlTitle);
            Name = "TestCookingApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test Cooking App";
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Panel pnlNavigationMenu;
        private Label lblTitle;
        private RoundButton btnClose;
    }
}