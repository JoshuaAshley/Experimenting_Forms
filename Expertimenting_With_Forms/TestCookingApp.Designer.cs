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
            pbTitleIcon = new PictureBox();
            btnMinimize = new RoundButton();
            lblTitle = new Label();
            btnClose = new RoundButton();
            pnlNavigationMenu = new Panel();
            tbSearch = new TextBox();
            btnDeleteRecipe = new Button();
            button2 = new Button();
            btnViewRecipe = new Button();
            btnAddRecipe = new Button();
            pbSettings = new PictureBox();
            pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTitleIcon).BeginInit();
            pnlNavigationMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSettings).BeginInit();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(244, 132, 70);
            pnlTitle.Controls.Add(pbTitleIcon);
            pnlTitle.Controls.Add(btnMinimize);
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Controls.Add(btnClose);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(763, 65);
            pnlTitle.TabIndex = 1;
            // 
            // pbTitleIcon
            // 
            pbTitleIcon.Image = Properties.Resources.Title_Icon;
            pbTitleIcon.Location = new Point(12, -17);
            pbTitleIcon.Name = "pbTitleIcon";
            pbTitleIcon.Size = new Size(94, 97);
            pbTitleIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTitleIcon.TabIndex = 3;
            pbTitleIcon.TabStop = false;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Yellow;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimize.Image = Properties.Resources.Minimize_Icon;
            btnMinimize.Location = new Point(649, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(40, 40);
            btnMinimize.TabIndex = 4;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(24, 24, 24);
            lblTitle.Location = new Point(109, 4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(422, 51);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Sanele's Cooking Book";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.OrangeRed;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Image = Properties.Resources.Close_Icon;
            btnClose.Location = new Point(695, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 3;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnlNavigationMenu
            // 
            pnlNavigationMenu.Controls.Add(tbSearch);
            pnlNavigationMenu.Controls.Add(btnDeleteRecipe);
            pnlNavigationMenu.Controls.Add(button2);
            pnlNavigationMenu.Controls.Add(btnViewRecipe);
            pnlNavigationMenu.Controls.Add(btnAddRecipe);
            pnlNavigationMenu.Controls.Add(pbSettings);
            pnlNavigationMenu.Dock = DockStyle.Left;
            pnlNavigationMenu.Location = new Point(0, 65);
            pnlNavigationMenu.Name = "pnlNavigationMenu";
            pnlNavigationMenu.Size = new Size(236, 445);
            pnlNavigationMenu.TabIndex = 2;
            // 
            // tbSearch
            // 
            tbSearch.BorderStyle = BorderStyle.FixedSingle;
            tbSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbSearch.ForeColor = SystemColors.ButtonShadow;
            tbSearch.Location = new Point(12, 69);
            tbSearch.Multiline = true;
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(210, 33);
            tbSearch.TabIndex = 3;
            tbSearch.Text = "Search for a Recipe";
            // 
            // btnDeleteRecipe
            // 
            btnDeleteRecipe.Anchor = AnchorStyles.None;
            btnDeleteRecipe.FlatAppearance.BorderSize = 0;
            btnDeleteRecipe.FlatStyle = FlatStyle.Flat;
            btnDeleteRecipe.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteRecipe.Location = new Point(0, 282);
            btnDeleteRecipe.Name = "btnDeleteRecipe";
            btnDeleteRecipe.Size = new Size(236, 52);
            btnDeleteRecipe.TabIndex = 3;
            btnDeleteRecipe.Text = "Remove Recipe";
            btnDeleteRecipe.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(0, 224);
            button2.Name = "button2";
            button2.Size = new Size(236, 52);
            button2.TabIndex = 3;
            button2.Text = "Filter Recipe";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnViewRecipe
            // 
            btnViewRecipe.Anchor = AnchorStyles.None;
            btnViewRecipe.FlatAppearance.BorderSize = 0;
            btnViewRecipe.FlatStyle = FlatStyle.Flat;
            btnViewRecipe.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewRecipe.Location = new Point(0, 166);
            btnViewRecipe.Name = "btnViewRecipe";
            btnViewRecipe.Size = new Size(236, 52);
            btnViewRecipe.TabIndex = 3;
            btnViewRecipe.Text = "View Recipe";
            btnViewRecipe.UseVisualStyleBackColor = true;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.Anchor = AnchorStyles.None;
            btnAddRecipe.FlatAppearance.BorderSize = 0;
            btnAddRecipe.FlatStyle = FlatStyle.Flat;
            btnAddRecipe.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddRecipe.Location = new Point(2, 108);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(234, 52);
            btnAddRecipe.TabIndex = 3;
            btnAddRecipe.Text = "Add Recipe";
            btnAddRecipe.UseVisualStyleBackColor = true;
            btnAddRecipe.Click += btnAddRecipe_Click;
            // 
            // pbSettings
            // 
            pbSettings.Image = Properties.Resources.Settings_Icon;
            pbSettings.Location = new Point(17, 6);
            pbSettings.Name = "pbSettings";
            pbSettings.Size = new Size(55, 46);
            pbSettings.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSettings.TabIndex = 3;
            pbSettings.TabStop = false;
            // 
            // TestCookingApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 510);
            Controls.Add(pnlNavigationMenu);
            Controls.Add(pnlTitle);
            Name = "TestCookingApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test Cooking App";
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbTitleIcon).EndInit();
            pnlNavigationMenu.ResumeLayout(false);
            pnlNavigationMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSettings).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Panel pnlNavigationMenu;
        private Label lblTitle;
        private RoundButton btnClose;
        private RoundButton btnMinimize;
        private PictureBox pbSettings;
        private PictureBox pbTitleIcon;
        private Button btnAddRecipe;
        private Button btnDeleteRecipe;
        private Button button2;
        private Button btnViewRecipe;
        private TextBox tbSearch;
    }
}